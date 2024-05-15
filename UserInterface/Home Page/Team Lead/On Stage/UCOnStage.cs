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
using UserInterface;
using System.IO;
using System.IO.Compression;

namespace TeamTracker
{
    public partial class UcOnStage : UserControl
    {
        public event EventHandler ResetHomePage;
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
            InitializePageColor();
            transparentForm = new TransparentForm();
            toolTip1.SetToolTip(pictureBoxDownload, "Download Attachements");
        }

        public new void Dispose()
        {
            if (pictureBoxDownload.Image != null) pictureBoxDownload.Image.Dispose();

            buttonOnStage.Dispose();    clientLabel.Dispose();  descTextBox.Dispose();  endDate.Dispose();
            label2.Dispose();   label3.Dispose();   label4.Dispose();   label5.Dispose();   labelDownload.Dispose();    labelProjNameandVersion.Dispose();
            panel1.Dispose();   panel3.Dispose();   panel4.Dispose();   panel5.Dispose();   panel6.Dispose();   panelDownloadAttachement.Dispose();
            pictureBoxDownload.Dispose();   startDate.Dispose();    setMilestoneButton.Dispose();

            tableLayoutPanel1.Dispose();    tableLayoutPanel2.Dispose();    tableLayoutPanel3.Dispose();    tableLayoutPanel4.Dispose();    tableLayoutPanel5.Dispose();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            descTextBox.BackColor = tableLayoutPanel3.BackColor = panel1.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label4.ForeColor = label5.ForeColor = labelProjNameandVersion.ForeColor = clientLabel.ForeColor = label2.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);
            descTextBox.ForeColor = startDate.ForeColor = endDate.ForeColor = label3.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);
            panelDownloadAttachement.BackColor = setMilestoneButton.BackColor = buttonOnStage.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            labelDownload.ForeColor = setMilestoneButton.ForeColor = buttonOnStage.ForeColor = ThemeManager.GetTextColor(buttonOnStage.BackColor);
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
        
        private void OnClickDownloadAttachement(object sender, EventArgs e)
        {
            List<VersionAttachment> attachments = DataHandler.FetchAttachmentsByVersionID(selectedVersion.VersionID);
            string zipFilePath = "", fileNetworkPath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ZIP Folders(.ZIP)| *.zip";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                zipFilePath = saveFileDialog.FileName;
            }

            using (var zipArchive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
            {
                foreach (var fileToZip in attachments)
                {
                    fileNetworkPath = fileToZip.AttachmentLocation;
                    if (File.Exists(fileNetworkPath))
                    {
                        zipArchive.CreateEntryFromFile(fileNetworkPath, Path.GetFileName(fileToZip.DisplayName));
                    }
                    else
                    {
                        ProjectManagerMainForm.notify.AddNotification("File not found", fileNetworkPath);
                    }
                }
            }

            ProjectManagerMainForm.notify.AddNotification("Download Completed", Path.GetFileName(zipFilePath));
        }



        private void OnMouseEnterDownload(object sender, EventArgs e)
        {
            panelDownloadAttachement.BackColor = ThemeManager.GetHoverColor(panelDownloadAttachement.BackColor);
            labelDownload.BackColor = ThemeManager.GetTextColor(panelDownloadAttachement.BackColor);

            if (pictureBoxDownload.Image != null) pictureBoxDownload.Image.Dispose();

            pictureBoxDownload.Image = UserInterface.Properties.Resources.Download_Medium_Blue_Color;
        }

        private void OnMouseLeaveDownload(object sender, EventArgs e)
        {
            panelDownloadAttachement.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            labelDownload.BackColor = ThemeManager.GetTextColor(panelDownloadAttachement.BackColor);

            if (pictureBoxDownload.Image != null) pictureBoxDownload.Image.Dispose();

            pictureBoxDownload.Image = UserInterface.Properties.Resources.Download_Light_Blue;
        }

        private void OnClickDiscard(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OnClickStageProject(object sender, EventArgs e)
        {
            if (MilestoneCollection != null && MilestoneCollection.Count >= 5 && MilestoneCollection.Count <= 8)
            {
                VersionManager.UpdateVersion(selectedVersion.VersionID,selectedVersion.VersionName, selectedVersion.VersionDescription, ProjectStatus.OnProcess, selectedVersion.StartDate, selectedVersion.EndDate, selectedVersion.ClientEmail, null);
                VersionManager.CurrentVersion = selectedVersion;
                MilestoneManager.AddMilestones(selectedVersion.VersionID, MilestoneCollection);
                ResetHomePage?.Invoke(this, EventArgs.Empty);
                DataHandler.AddNotification("Milestone Alert: New Project Milestone Set by Team Leader!", "Hello [Project Manager's Name],\r\n\r\nWe're thrilled to inform you that a new milestone has been set for the project" + VersionManager.FetchProjectName(selectedVersion.VersionID) + "by your team leader" + EmployeeManager.FetchEmployeeFromProjectID(selectedVersion.ProjectID).EmployeeFirstName + ". As the project manager, staying informed about key developments is crucial for effective project oversight and coordination.", DateTime.Now, EmployeeManager.FetchManagerFromTeamLeadID().EmployeeID);
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Warning", "Milestone Limit Should be within 5 and 8.\nPlease Add Milestones");
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
            (sender as Control).BackColor = ThemeManager.GetHoverColor((sender as Control).BackColor);
            (sender as Control).ForeColor = ThemeManager.GetTextColor((sender as Control).BackColor);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = ThemeManager.CurrentTheme.SecondaryI;
            (sender as Control).ForeColor = ThemeManager.GetTextColor((sender as Control).BackColor);
        }

        private void OnSetMilestoneFormClicked(object sender, EventArgs e)
        {
            AddMilestoneForm form = new AddMilestoneForm();
            form.SelectedVersion = selectedVersion;
            form.MilestoneCollection = MilestoneCollection;
            form.MilestoneExtract += OnMilestoneExtraction;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnMilestoneExtraction(object sender, List<Milestone> e)
        {
            MilestoneCollection = e;
            (sender as AddMilestoneForm).Dispose();
            (sender as AddMilestoneForm).Close();
            ParentForm.Show();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            Pen border;
            string name = (sender as Control).Name;
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (name == "panel1" || name == "tableLayoutPanel3")
                border = new Pen(ThemeManager.CurrentTheme.SecondaryIII, 2);
            else
                border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(rec, 10));
            border.Dispose();
        }

        private void OnDescriptionPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new System.Drawing.Point(0,(sender as Control).Height - 2), new System.Drawing.Point((sender as Control).Width, (sender as Control).Height - 2));
            border.Dispose();
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

        private List<Milestone> MilestoneCollection;
        private ProjectVersion selectedVersion;
        private AddMilestoneForm addMilestoneForm;
        private TransparentForm transparentForm;
    }
}
