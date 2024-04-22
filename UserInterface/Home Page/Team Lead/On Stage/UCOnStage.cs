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
using System.Windows;

namespace TeamTracker
{
    public partial class UcOnStage : UserControl
    {
        public event EventHandler ResetHomePage;
        private List<Milestone> MilestoneCollection;
        private ProjectVersion selectedVersion;
        private AddMilestoneForm addMilestoneForm;
        private List<UcMilestone> milestoneList = new List<UcMilestone>();

        public ProjectVersion SelectedVersion
        {
            set
            {
                if (value != null)
                {
                    MilestoneCollection = new List<Milestone>();
                    selectedVersion = value;
                    InitializeOnStageControl();
                }
                else
                {
                    tableLayoutPanel1.Visible = false;
                }
            }
        }

        public UcOnStage()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            toolTip1.SetToolTip(pictureBoxDownload, "Download Attachements");
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            tableLayoutPanel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width, tableLayoutPanel3.Height, 20, 20));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
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
        
        private void OnClickDownloadAttachement(object sender, EventArgs e)
        {
            List<VersionAttachment> attachments = DataHandler.FetchAttachmentsByVersionID(selectedVersion.VersionID);

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

            for (int ctr = 0; ctr < attachments.Count; ctr++)
            {
                string fileNetworkPath = attachments[ctr].AttachmentLocation;
                try
                {
                    string fileName = System.IO.Path.GetFileName(fileNetworkPath);
                    string filePath = System.IO.Path.GetDirectoryName(savePath);
                    filePath = System.IO.Path.Combine(filePath, attachments[ctr].DisplayName);
                    System.IO.File.Copy(fileNetworkPath, filePath, true);
                    ProjectManagerMainForm.notify.AddNotification("Download Completed", attachments[ctr].DisplayName);
                }
                catch
                {
                    ProjectManagerMainForm.notify.AddNotification("Download Failed", attachments[ctr].DisplayName);
                }
            }
        }



        private void OnMouseEnterDownload(object sender, EventArgs e)
        {
            pictureBoxDownload.BackColor = labelDownload.BackColor = Color.FromArgb(62, 89, 110);

            if (pictureBoxDownload.Image != null) pictureBoxDownload.Image.Dispose();

            pictureBoxDownload.Image = UserInterface.Properties.Resources.Download_Medium_Blue_Color;
        }

        private void OnMouseLeaveDownload(object sender, EventArgs e)
        {
            pictureBoxDownload.BackColor = labelDownload.BackColor = Color.FromArgb(82, 109, 130);

            if (pictureBoxDownload.Image != null) pictureBoxDownload.Image.Dispose();

            pictureBoxDownload.Image = UserInterface.Properties.Resources.Download_Light_Blue;
        }

        private void OnClickDiscard(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OnClickStageProject(object sender, EventArgs e)
        {
            if (MilestoneCollection != null && MilestoneCollection.Count >= 5 && MilestoneCollection.Count <= 20)
            {
                VersionManager.UpdateVersion(selectedVersion.VersionID,selectedVersion.VersionName, selectedVersion.VersionDescription, ProjectStatus.OnProcess, selectedVersion.StartDate, selectedVersion.EndDate, selectedVersion.ClientEmail, null);
                MilestoneManager.AddMilestones(selectedVersion.VersionID, MilestoneCollection);
                ResetHomePage?.Invoke(this, EventArgs.Empty);
                DataHandler.AddNotification("Project Processed", VersionManager.FetchProjectName(selectedVersion.VersionID) + "  " + selectedVersion.VersionName + "has been started by" + EmployeeManager.FetchEmployeeFromProjectID(selectedVersion.ProjectID), DateTime.Now, EmployeeManager.FetchManagerFromTeamLeadID().EmployeeID);
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Warning", "Milestone Limit Should be within 5 and 20.\nPlease Add Milestones");
            }
        }

        private void InitializeOnStageControl()
        {
            labelProjNameandVersion.Text = VersionManager.FetchProjectName(selectedVersion.VersionID) + "\n" + selectedVersion.VersionName;
            clientLabel.Text = selectedVersion.ClientEmail;
            startDate.Text = selectedVersion.StartDate.ToShortDateString(); endDate.Text = selectedVersion.EndDate.ToShortDateString();
            descTextBox.Text = selectedVersion.VersionDescription;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(62, 89, 110);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(82, 109, 130);
        }

        private void OnSetMilestoneFormClicked(object sender, EventArgs e)
        {
            AddMilestoneForm form = new AddMilestoneForm();
            form.SelectedVersion = selectedVersion;
            form.MilestoneCollection = MilestoneCollection;
            form.MilestoneExtract += OnMilestoneExtraction;
            form.ShowDialog(this);
        }

        private void OnMilestoneExtraction(object sender, List<Milestone> e)
        {
            MilestoneCollection = e;
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(221, 230, 237), 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(rec, 10));
            border.Dispose();
        }

        private void BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(221, 230, 237), 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(rec, 10));
            border.Dispose();
        }

        private void OnDescriptionPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(221, 230, 237), 2);
            e.Graphics.DrawLine(border, new System.Drawing.Point(0,(sender as Control).Height - 2), new System.Drawing.Point((sender as Control).Width, (sender as Control).Height - 2));
            border.Dispose();
        }
    }
}
