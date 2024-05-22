using GoLibrary;
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
            InitializePageColor();
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

        private void UnSubscribeEventsAndRemoveMemory()
        {
            pictureBox1.Image?.Dispose();
            pictureBoxUpload.Image?.Dispose();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            commitTextBox.ForeColor = button1.BackColor = button2.BackColor = panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            button1.ForeColor = button2.ForeColor = label1.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.PrimaryI);
            commitTextBox.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            label2.ForeColor = label3.ForeColor = ThemeManager.GetTextColor(BackColor);

            pictureBox1.Image?.Dispose();
            pictureBoxUpload.Image?.Dispose();

            pictureBoxUpload.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Upload : UserInterface.Properties.Resources.Heat_Upload;
            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light : UserInterface.Properties.Resources.Heat_Close_Light;
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
            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light_Hover : UserInterface.Properties.Resources.Heat_Close_Light_Hover;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light : UserInterface.Properties.Resources.Heat_Close_Light;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
