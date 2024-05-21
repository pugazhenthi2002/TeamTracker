using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace TeamTracker
{
    public partial class ProjectInfoForm : Form
    {
        public event EventHandler InfoFormClose;
        public ProjectInfoForm()
        {
            InitializeComponent();
            InitializePageColor();
            InitializeBorder();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void InitializePageColor()
        {
            startDate.BorderColor = startDate.DueLabelcolor = startDate.ForeColor = panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            endDate.BorderColor = endDate.DueLabelcolor = endDate.ForeColor = ucTaskDescription1.TopLabelColor = ucTaskDescription1.BorderColor = ThemeManager.CurrentTheme.PrimaryI;
            startDate.HeaderForecolor = startDate.BackColor = endDate.HeaderForecolor = endDate.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            tableLayoutPanel5.BackColor = panelAttachment.BackColor = panelSourceCode.BackColor = label3.BackColor = label8.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            labelTaskCount.ForeColor = labelSourceCode.ForeColor = labelAttachment.ForeColor = label2.ForeColor = ThemeManager.GetTextColor(label8.BackColor);
            ucNotFound1.BackColor = BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label4.ForeColor = label5.ForeColor = label6.ForeColor = label7.ForeColor = label1.ForeColor = ThemeManager.GetTextColor(BackColor);
            labelTitle.ForeColor = profileAssignedTo.ProfileTextColor = ThemeManager.GetTextColor(panel1.BackColor);
            label3.ForeColor = label8.ForeColor = ThemeManager.GetTextColor(label8.BackColor);

            pictureBoxAttachment.Image?.Dispose();  pictureBoxClose.Image?.Dispose();   pictureBoxSoureCode.Image?.Dispose();   backBtn.Image?.Dispose();   nextBtn.Image?.Dispose();

            pictureBoxSoureCode.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download: UserInterface.Properties.Resources.Heat_Download;
            pictureBoxAttachment.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download: UserInterface.Properties.Resources.Heat_Download;
            pictureBoxClose.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light: UserInterface.Properties.Resources.Heat_Close_Light;
            ResetButton();
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;

            if (backBtn.Image != null) backBtn.Image.Dispose();
            if (nextBtn.Image != null) nextBtn.Image.Dispose();
            if (pictureBoxAttachment.Image != null) pictureBoxAttachment.Image.Dispose();
            if (pictureBoxSoureCode.Image != null) pictureBoxSoureCode.Image.Dispose();
            if (pictureBoxClose.Image != null) pictureBoxClose.Image.Dispose();
        }

        private bool isBackEnable = false, isNextEnable = true;
        private int flag;
        private ProjectVersion selectedVersion;
        public ProjectVersion SelectedVersion
        {
            set
            {
                selectedVersion = value;
                InitializeForm();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorder();
            int topBottom = (panel5.Height - 150) / 2;
            panel5.Padding = new Padding(0, topBottom, 0, topBottom);
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

        private void InitializeBorder()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            tableLayoutPanel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel5.Width, tableLayoutPanel5.Height, 20, 20));
            panelSourceCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelSourceCode.Width, panelSourceCode.Height, 20, 20));
            panelAttachment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelAttachment.Width, panelAttachment.Height, 20, 20));
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close;

        }

        private void InitializeForm()
        {
            labelTitle.Text = VersionManager.FetchProjectName(selectedVersion.VersionID) + "\n" + selectedVersion.VersionName;
            profileAssignedTo.EmployeeProfile = EmployeeManager.FetchEmployeeFromProjectID(selectedVersion.ProjectID);
            ucTaskDescription1.CenterLabelText = selectedVersion.VersionDescription;
            startDate.DueDate = selectedVersion.StartDate; endDate.DueDate = selectedVersion.EndDate;
            labelTaskCount.Text = TaskManager.FetchTaskCount(selectedVersion.VersionID)[0].ToString();
            var attachments = DataHandler.FetchAttachmentsByVersionID(selectedVersion.VersionID);

            if(attachments == null || attachments.Count == 0)
            {
                labelAttachment.Visible = pictureBoxAttachment.Visible = false;
            }

            if (!(selectedVersion.StatusOfVersion == ProjectStatus.Completed))
            {
                labelSourceCode.Visible = pictureBoxSoureCode.Visible = false;
            }

            if (selectedVersion.StatusOfVersion == ProjectStatus.UpComing || selectedVersion.StatusOfVersion == ProjectStatus.OnStage)
            {
                ucNotFound1.BringToFront();
                return;
            }

            milestoneView1.MilestoneCollection = MilestoneManager.FetchMilestones(selectedVersion.VersionID);
            flag = milestoneView1.ChangeMilestoneUI(true);

            ResetButton();
        }

        private void BackMilestoneClick(object sender, EventArgs e)
        {
            if (isBackEnable)
                flag = milestoneView1.ChangeMilestoneUI(false);

            if (flag < 0) isBackEnable = false;
            else { isBackEnable = true; }
            isNextEnable = true;

            if (backBtn.Image != null) backBtn.Image.Dispose();
            if (nextBtn.Image != null) nextBtn.Image.Dispose();

            ResetButton();
        }

        private void OnClose(object sender, EventArgs e)
        {
            InfoFormClose?.Invoke(this, EventArgs.Empty);
        }

        private void SourceCodeDownload(object sender, EventArgs e)
        {
            VersionSourceCode sourceCode = DataHandler.FetchVersionSourceCodeByVersionID(selectedVersion.VersionID);

            string savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ZIP Folders(.ZIP)| *.zip";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }

            string fileNetworkPath = sourceCode.VersionLocation;
            try
            {
                System.IO.File.Copy(fileNetworkPath, savePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", sourceCode.DisplayName);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", sourceCode.DisplayName);
            }
        }

        private void AttachmentDownload(object sender, EventArgs e)
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
            try
            {
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
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("File Already in Use for Application", Path.GetFileName(zipFilePath));
            }
            
        }

        private void OnLegendPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Brush brush;
            if ((sender as Panel).Name == "donePanel") brush = new SolidBrush(ThemeManager.CurrentTheme.MilestoneStatusColorCollection[MilestoneStatus.Completed]);
            else if ((sender as Panel).Name == "delayPanel") brush = new SolidBrush(ThemeManager.CurrentTheme.MilestoneStatusColorCollection[MilestoneStatus.Delay]);
            else if ((sender as Panel).Name == "currentPanel") brush = new SolidBrush(ThemeManager.CurrentTheme.MilestoneStatusColorCollection[MilestoneStatus.OnProcess]);
            else brush = new SolidBrush(ThemeManager.CurrentTheme.MilestoneStatusColorCollection[MilestoneStatus.Upcoming]);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, new Rectangle(0, 0, (sender as Panel).Width - 2, (sender as Panel).Height - 2));
            brush.Dispose();
        }

        private void OnDownloadMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();

            (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download_Hover : UserInterface.Properties.Resources.Heat_Download_Hover;
        }

        private void OnDownloadMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();

            (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download : UserInterface.Properties.Resources.Heat_Download;
        }

        private void OnDownloadEdgePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1), 10));
            border.Dispose();
        }

        private void OnMilestoneNavMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "backBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = UserInterface.Properties.Resources.Cold_Left_Dark_Hover;
                }
                else
                {
                    backBtn.Image = UserInterface.Properties.Resources.Heat_Left_Dark_Hover;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = UserInterface.Properties.Resources.Cold_Right_Dark_Hover;
                }
                else
                {
                    nextBtn.Image = UserInterface.Properties.Resources.Heat_Right_Dark_Hover;
                }
            }
        }

        private void OnMilestoneNavMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "backBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Dark : UserInterface.Properties.Resources.Cold_Left_Light;
                }
                else
                {
                    backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Heat_Left_Dark : UserInterface.Properties.Resources.Heat_Left_Medium;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Dark : UserInterface.Properties.Resources.Cold_Right_Light;
                }
                else
                {
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Dark : UserInterface.Properties.Resources.Heat_Right_Medium;
                }
            }
        }

        private void NextMilestoneClick(object sender, EventArgs e)
        {
            if (isNextEnable)
                flag = milestoneView1.ChangeMilestoneUI(true);

            if (flag > 0) isNextEnable = false;
            else { isNextEnable = true; }
            isBackEnable = true;

            ResetButton();
        }

        private void ResetButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Dark : UserInterface.Properties.Resources.Cold_Left_Light;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Dark : UserInterface.Properties.Resources.Cold_Right_Light;
            }
            else
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Heat_Left_Dark : UserInterface.Properties.Resources.Heat_Left_Medium;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Dark : UserInterface.Properties.Resources.Heat_Right_Medium;
            }
        }

        private const int CSDropShadow = 0x00020000;

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.Image?.Dispose();
            pictureBoxClose.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light_Hover : UserInterface.Properties.Resources.Heat_Close_Light_Hover;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.Image?.Dispose();
            pictureBoxClose.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light : UserInterface.Properties.Resources.Heat_Close_Light;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }
    }
}
