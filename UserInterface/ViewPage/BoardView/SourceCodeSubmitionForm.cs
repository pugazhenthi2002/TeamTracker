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
            labelWarning.Hide();
        }

        public Task SourceCodeTask;
        public SourceCode TaskSourceCode;
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

            openFileDialog1.Title = "Commit Name";
            openFileDialog1.Filter = "ZIP files (*.zip)|*.zip";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (DataHandler.CommitNameAlreadyExists(SourceCodeTask.TaskID, openFileDialog1.Title))
                {
                    ProjectManagerMainForm.notify.AddNotification("Submission Failed", "Source Code Commit Name Already Exists\nTry Some Other Name");
                    return;
                }

                string selectedFilePath = openFileDialog1.FileName;
                string safeFile = openFileDialog1.SafeFileName;
                TaskSourceCode = new SourceCode()
                {
                    TaskID = SourceCodeTask.TaskID,
                    SubmittedDate = DateTime.Now,
                    SourceCodeLocation = safeFile,
                    CommitName = openFileDialog1.Title
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
            if(selectedFileName=="")
            {
                labelWarning.Show();
                return;
            }
            DoneClick?.Invoke(sender, e);
            this.Close();
        }

    }
}
