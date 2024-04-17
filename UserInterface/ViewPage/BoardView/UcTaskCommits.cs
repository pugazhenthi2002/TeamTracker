using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class UcTaskCommits : UserControl
    {

        private string commitName;
        private int sourceCodeId = 4;

        public UcTaskCommits()
        {
            InitializeComponent();
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

        public string CommitName
        {
            get { return commitName; }
            set
            {
                commitName = value;
                SetCommitName();
            }
        }

        private void SetCommitName()
        {
            labelCommitName.Text = commitName ;
        }

        private void SetSourceCodeId()
        {
            labelSourceCodeId.Text = sourceCodeId + "";
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
