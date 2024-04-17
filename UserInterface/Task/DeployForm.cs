﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Task
{
    public partial class DeployForm : Form
    {
        public DeployForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            this.Location = new Point(700, 300);
            labelWarning.Hide();
        }

        public VersionSourceCode SelectedVersionSourceCode;
        public EventHandler CloseClick;
        public EventHandler DoneClick;
        private bool Uploaded = false;
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            buttonClear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonClear.Width, buttonClear.Height, 10, 10));
            buttonDone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDone.Width, buttonDone.Height, 10, 10));


        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close;
        }

        private void OnMouseEnterUpload(object sender, EventArgs e)
        {
            if (selectedFileName == "")
            {
                pictureBoxUpload.Image = UserInterface.Properties.Resources.CloudHover1;
                labelClickUpload.Font = new Font(labelClickUpload.Font, FontStyle.Bold);
            }
        }

        private void OnMouseLeaveUpload(object sender, EventArgs e)
        {
            if (selectedFileName == "")
            {
                pictureBoxUpload.Image = UserInterface.Properties.Resources.CloudBlack1;
                labelClickUpload.Font = new Font(labelClickUpload.Font, FontStyle.Regular);
            }


        }

        private void OnMouseClickUpload(object sender, MouseEventArgs e)
        {
            labelWarning.Hide();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Source Code Name";
            openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                string safeFile = openFileDialog1.SafeFileName;
                SelectedVersionSourceCode = new VersionSourceCode()
                {
                    VersionID = VersionManager.CurrentVersion.VersionID,
                    DisplayName = safeFile,
                    SourceCodeName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".pdf",
                    VersionLocation = selectedFilePath
                };
            }
        }

        private void OnClickClose(object sender, MouseEventArgs e)
        {
            CloseClick?.Invoke(sender, e);
            this.Close();
        }

        private void OnClickClear(object sender, EventArgs e)
        {
            Uploaded = false;
            pictureBoxUpload.Image = UserInterface.Properties.Resources.CloudBlack1;
            labelClickUpload.Text = "Click to Upload";
            selectedFileName = "";
        }

        private void OnClickDone(object sender, EventArgs e)
        {
            if (selectedFileName == "")
            {
                labelWarning.Show();
                return;
            }
            VersionManager.SubmitVersionSourceCode(SelectedVersionSourceCode);
            DoneClick?.Invoke(sender, e);
            this.Close();
        }
    }
}