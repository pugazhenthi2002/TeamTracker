﻿using GoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class SourceCodeSubmitionForm : Form
    {
        public SourceCodeSubmitionForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            this.Location = new Point(700, 300);
        }

        public Task SourceCodeTask;
        public SourceCode TaskSourceCode;
        public EventHandler<SourceCode> DoneClick;
        private string selectedFileName = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public new void Dispose()
        {
            if(pictureBox1.Image != null)   pictureBox1.Image.Dispose();
            if(pictureBoxUpload.Image != null) pictureBoxUpload.Image.Dispose();

            pictureBox1.Dispose();  pictureBoxUpload.Dispose();
            label1.Dispose();   label2.Dispose();   label3.Dispose();
            button1.Dispose();  button2.Dispose();
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();   panel4.Dispose();   panel5.Dispose();
            tableLayoutPanel1.Dispose();    tableLayoutPanel2.Dispose();
            commitTextBox.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void OnMouseClickUpload(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Source Code Name";
            openFileDialog1.Filter = "ZIP Folders(.ZIP)| *.zip";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                string safeFile = openFileDialog1.SafeFileName;
                TaskSourceCode = new SourceCode()
                {
                    TaskID = SourceCodeTask.TaskID,
                    SourceCodeName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".zip",
                    SourceCodeLocation = selectedFilePath,
                    SubmittedDate = DateTime.Now.Date
                };
                label3.Text = safeFile;
            }
        }

        private void OnClickClear(object sender, EventArgs e)
        {
            label3.Text = "UPLOAD";
            TaskSourceCode = null;
        }

        private void OnClickDone(object sender, EventArgs e)
        {
            BooleanMsg message = new BooleanMsg();
            message = EligibleToUpload();
            if (message)
            {
                TaskSourceCode.CommitName = commitTextBox.Text;
                TaskSourceCode.CommitedBy = EmployeeManager.CurrentEmployee.EmployeeID;
                DoneClick?.Invoke(this, TaskSourceCode);
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Warning", message.Message);
            }
        }

        private BooleanMsg EligibleToUpload()
        {
            if(TaskSourceCode == null)
            {
                return "File Not Selected\nKindly Upload a File";
            }

            if(commitTextBox.Text == "")
            {
                return "Commit Name is Invalid\nPlease Enter Commit Name";
            }

            foreach(var Iter in commitTextBox.Text)
            {
                if(!((Iter<='z' && Iter >='a') ||  (Iter<='Z' && Iter>='A') || Iter==' '))
                {
                    return "Commit Name is Invalid\n Should Contains only Letters and Spaces";
                }
            }
            return true;
        }

        private void OnClose(object sender, EventArgs e)
        {
            DoneClick?.Invoke(this, null);
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = UserInterface.Properties.Resources.Close_Dark_Blue_Hover;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = UserInterface.Properties.Resources.Close_30;
        }
    }
}
