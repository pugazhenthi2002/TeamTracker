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
    public partial class UcDeploy : UserControl
    {
        public delegate void DeployHandler(string name, ProjectVersion project);
        public event DeployHandler Deployment;

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
            profilePicAndNameSquare1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profilePicAndNameSquare1.Width, profilePicAndNameSquare1.Height, 20, 20));
            tableLayoutPanel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width, tableLayoutPanel3.Height, 20, 20));

        }

        private ProjectVersion version;
        public ProjectVersion Version
        {
            set
            {
                if (value != null)
                {
                    version = value;
                    proj = VersionManager.FetchProjectFromID(value.ProjectID);
                    if (proj != null)
                    {
                        labelProjectName.Text = proj.ProjectName + "\n" + value.VersionName;
                    }
                    DateLabel.Text = value.StartDate.ToShortDateString() + " - " + value.EndDate.ToShortDateString();
                    profilePicAndNameSquare1.empProfile = EmployeeManager.FetchEmployeeFromProjectID(proj.ProjectID);
                    downloadBtn1.TypeOfFile = FileType.Zip;
                    versionSourceCode = DataHandler.FetchVersionSourceCodeByVersionID(value.VersionID);
                }
            }
        }

        private Projects proj;
        private VersionSourceCode versionSourceCode;
        public UcDeploy()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void OnDownloaded(object sender, EventArgs e)
        {
            string fileNetworkPath = DataHandler.FetchVersionSourceCodeByVersionID(version.VersionID).VersionLocation;
            string savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "ZIP files (*.zip)|*.zip";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }

            try
            {
                string fileName = System.IO.Path.GetFileName(fileNetworkPath);
                string filePath = System.IO.Path.Combine(savePath, savePath);
                System.IO.File.Copy(fileNetworkPath, filePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", proj.ProjectName + "\n" + version.VersionName);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", proj.ProjectName + "\n" + version.VersionName);
            }
        }

        private void OnDeployClick(object sender, EventArgs e)
        {
            VersionManager.VersionCompletion(version);
            Deployment?.Invoke(proj.ProjectName, version);
        }
    }
}
