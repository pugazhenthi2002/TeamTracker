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

        private ProjectVersion version;
        private Projects proj;
        private VersionSourceCode versionSourceCode;


        public UcDeploy()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        

        public delegate void DeployHandler(string name, ProjectVersion project);
        public event DeployHandler Deployment;
        public event EventHandler SourceCodeDownlload;

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
                        labelProjNameandVersion.Text = proj.ProjectName + "\n" + value.VersionName;
                    }
                    labelClientName.Text = value.ClientEmail;
                    ucStartDate1.DueDate = value.StartDate;
                    ucToDate1.DueDate = value.EndDate;
                    profilePicAndNameSquare1.empProfile = EmployeeManager.FetchEmployeeFromProjectID(proj.ProjectID);
                    //downloadBtn1.TypeOfFile = FileType.Zip;
                    versionSourceCode = DataHandler.FetchVersionSourceCodeByVersionID(value.VersionID);
                }
            }
        }

        

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }


        private void InitializeRoundedEdge()
        {
            profilePicAndNameSquare1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profilePicAndNameSquare1.Width, profilePicAndNameSquare1.Height, 10, 10));
            buttonDeploy.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDeploy.Width, buttonDeploy.Height, 10, 10));
            panelDownloadAttachement.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDownloadAttachement.Width, panelDownloadAttachement.Height, 5, 5));
            labelProjNameandVersion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelProjNameandVersion.Width, labelProjNameandVersion.Height, 5, 5));
            labelClientName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelClientName.Width, labelClientName.Height, 5, 5));
            tableLayoutPanel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width, tableLayoutPanel3.Height, 20, 20));
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

        private void OnDownloaded(object sender, EventArgs e)
        {
            SourceCodeDownlload?.Invoke(this, e);
        }

        private void OnDeployClick(object sender, EventArgs e)
        {
            VersionManager.VersionCompletion(version);
            Deployment?.Invoke(proj.ProjectName, version);
        }

        private void OnPaintTlBase(object sender, PaintEventArgs e)
        {
            Point pt1 = new Point(4, 4);
            Point pt2 = new Point((sender as Panel).Width - 6, 4);
            Point pt3 = new Point((sender as Panel).Width - 6, (sender as Panel).Height - 6);
            Point pt4 = new Point(4, (sender as Panel).Height - 6);
            Pen border = new Pen(Color.Black, 2);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void OnMouseEnterDownload(object sender, EventArgs e)
        {
            labelDownload.Font = new Font(labelDownload.Font.FontFamily, 10, labelDownload.Font.Style);
            pictureBoxDownload.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void OnMouseLeaveDownload(object sender, EventArgs e)
        {
            labelDownload.Font = new Font(labelDownload.Font.FontFamily, 9, labelDownload.Font.Style);
            pictureBoxDownload.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void OnClickDownloadSourceCode(object sender, MouseEventArgs e)
        {

        }
    }
}
