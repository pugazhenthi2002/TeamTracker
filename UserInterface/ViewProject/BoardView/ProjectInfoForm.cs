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

namespace TeamTracker
{
    public partial class ProjectInfoForm : Form
    {
        public ProjectInfoForm()
        {
            InitializeComponent();
            InitializeBorder();
        }

        private bool backEnable = false, frontEnable = true;
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



        private void OnMouseClickClose(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {

        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close;

        }

        private void OnMouseEnterDownloadPicBox(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                if ((sender as Label).Name == "labelAttachment")
                {
                    pictureBoxAttachment.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else
                {
                    pictureBoxSoureCode.SizeMode = PictureBoxSizeMode.Zoom;
                }
                (sender as Label).Font = new Font((sender as Label).Font.FontFamily, 10, FontStyle.Bold);
                return;
            }
            else
            {

                if ((sender as PictureBox).Name == "pictureBoxSoureCode")
                {
                    labelSourceCode.Font = new Font(labelSourceCode.Font.FontFamily, 10, FontStyle.Bold);
                }
                else
                {
                    labelAttachment.Font = new Font(labelAttachment.Font.FontFamily, 10, FontStyle.Bold);
                }


                (sender as PictureBox).SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void OnMouseLeaveDownloadPicBox(object sender, EventArgs e)
        {
            //(sender as Control).BackColor
        }

        private void OnClickDownloadPicBox(object sender, MouseEventArgs e)
        {

        }

        private void OnPaintMilestoneBasePanel(object sender, PaintEventArgs e)
        {
            Point pt1 = new Point(4, 4);
            Point pt2 = new Point((sender as Panel).Width - 6, 4);
            Point pt3 = new Point((sender as Panel).Width - 6, (sender as Panel).Height - 6);
            Point pt4 = new Point(4, (sender as Panel).Height - 6);
            Pen border = new Pen(Color.Black, 2);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void InitializeForm()
        {
            labelTitle.Text = VersionManager.FetchProjectName(selectedVersion.VersionID) + "\n" + selectedVersion.VersionName;
            profileAssignedTo.EmployeeProfile = EmployeeManager.FetchEmployeeFromProjectID(selectedVersion.ProjectID);
            ucTaskDescription1.CenterLabelText = selectedVersion.VersionDescription;
            startDate.DueDate = selectedVersion.StartDate; endDate.DueDate = selectedVersion.EndDate;
            labelTaskCount.Text = TaskManager.FetchTaskCount(selectedVersion.VersionID)[0].ToString();

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
        }

        private void BackMilestoneClick(object sender, EventArgs e)
        {
            if (backEnable)
                flag = milestoneView1.ChangeMilestoneUI(false);

            if (flag < 0) backEnable = false;
            else { backEnable = true; }
            frontEnable = true;

            if (backNavigatePicBox.Image != null) backNavigatePicBox.Image.Dispose();
            if (nextNavPicBox.Image != null) nextNavPicBox.Image.Dispose();

            backNavigatePicBox.Image = backEnable ? UserInterface.Properties.Resources.Back : UserInterface.Properties.Resources.Back_LightBlue;
            nextNavPicBox.Image = frontEnable ? UserInterface.Properties.Resources.Next : UserInterface.Properties.Resources.Next_LightBlue;
        }

        private void OnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnMouseEnterDownloadSource(object sender, EventArgs e)
        {
            pictureBoxSoureCode.BackColor = labelSourceCode.BackColor = Color.FromArgb(201, 210, 217);
        }

        private void OnMouseLeaveDownloadSource(object sender, EventArgs e)
        {
            pictureBoxSoureCode.BackColor = labelSourceCode.BackColor = Color.FromArgb(221, 230, 237);
        }

        private void OnMouseEnterDownloadAttachment(object sender, EventArgs e)
        {
            labelAttachment.BackColor = pictureBoxAttachment.BackColor = Color.FromArgb(201, 210, 217);
        }

        private void OnMouseLeaveDownloadAttachment(object sender, EventArgs e)
        {
            labelAttachment.BackColor = pictureBoxAttachment.BackColor = Color.FromArgb(221, 230, 237);
        }

        private void SourceCodeDownload(object sender, EventArgs e)
        {
            VersionSourceCode sourceCode = DataHandler.FetchVersionSourceCodeByVersionID(selectedVersion.VersionID);

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

            string fileNetworkPath = sourceCode.VersionLocation + "\\" + sourceCode.SourceCodeName;
            try
            {
                string fileName = System.IO.Path.GetFileName(fileNetworkPath);
                string filePath = System.IO.Path.Combine(savePath, savePath);
                System.IO.File.Copy(fileNetworkPath, filePath, true);
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

        private void OnLegendPaint(object sender, PaintEventArgs e)
        {
            Brush brush;

            if ((sender as Panel).Name == "donePanel") brush = new SolidBrush(Color.FromArgb(3, 4, 94));
            else if ((sender as Panel).Name == "delayPanel") brush = new SolidBrush(Color.FromArgb(0, 119, 182));
            else if ((sender as Panel).Name == "currentPanel") brush = new SolidBrush(Color.FromArgb(0, 180, 216));
            else brush = new SolidBrush(Color.FromArgb(144, 224, 239));

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, new Rectangle(0, 0, (sender as Panel).Width, (sender as Panel).Height));
            brush.Dispose();
        }

        private void NextMilestoneClick(object sender, EventArgs e)
        {
            if (frontEnable)
                flag = milestoneView1.ChangeMilestoneUI(true);

            if (flag > 0) frontEnable = false;
            else { frontEnable = true; }
            backEnable = true;

            backNavigatePicBox.Image = backEnable ? UserInterface.Properties.Resources.Back : UserInterface.Properties.Resources.Back_LightBlue;
            nextNavPicBox.Image = frontEnable ? UserInterface.Properties.Resources.Next : UserInterface.Properties.Resources.Next_LightBlue;
        }


    }
}
