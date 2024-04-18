using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TeamTracker
{
    public partial class UcTaskCommits : UserControl
    {

        private string commitName;
        private Employee commitOwner ;
        private int sourceCodeId;

        public UcTaskCommits()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }


        public string CommitName
        {
            get { return commitName; }
            set
            {
                commitName = value;
                SetCommitName();
            }
        }

        public int SourceCodeId
        {
            get { return sourceCodeId; }
            set
            {
                sourceCodeId = value;
                SetSourceCodeId();
            }
        }

        public Employee CommitOwner
        {
            get { return commitOwner; }
            set
            {
                commitOwner = value;
                SetCommitOwner();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }
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

        private void InitializeRoundedEdge()
        {
            //this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }
        private void SetSourceCodeId()
        {
            
        }
        private void SetCommitName()
        {
            labelCommitName.Text = commitName ;
        }

        private void SetCommitOwner()
        {
            EmpProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            EmpProfilePictureBox.ImageLocation = commitOwner.EmpProfileLocation;
            labelEmpName.Text = commitOwner.EmployeeFirstName;
        }
        

        private void OnMouseLeaveDownloadPicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void OnMouseEnterDownloadPicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void OnClickDownloadSourceCode(object sender, MouseEventArgs e)
        {
            SourceCode sourceCode = DataHandler.GetTaskSourceBySourceCodeID(sourceCodeId);

            string savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }

            string fileNetworkPath = sourceCode.SourceCodeLocation;
            try
            {
                string fileName = System.IO.Path.GetFileName(fileNetworkPath);
                string filePath = System.IO.Path.GetDirectoryName(savePath);
                filePath = System.IO.Path.Combine(filePath, sourceCode.CommitName);
                System.IO.File.Copy(fileNetworkPath, filePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", sourceCode.CommitName);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", sourceCode.CommitName);
            }
        }
    }
}
