using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class IssueInfoForm : Form
    {

        private Issue issueData;

        public IssueInfoForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(pictureBoxFlag, "Priority");
            toolTip1.SetToolTip(animatedLabelPriority, "Priority");
            toolTip1.SetToolTip(animatedLabelType, "Issue Type");
            toolTip1.SetToolTip(pictureBoxDownloadAttachment, "Download Attachment");
            toolTip1.SetToolTip(profilePostedBy, "Posted By");
            ucIssueDescription1.EnableEdit = false;
        }

        public Issue IssueData
        {
            get
            {
                return issueData;
            }
            set
            {
                issueData = value;
                SetIssueData();
            }
        }

        private const int CSDropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

        private void SetIssueData()
        {
            profilePostedBy.EmployeeProfile = EmployeeManager.FetchEmployeeFromID(issueData.PostedBy);
            ucIssueDescription1.TopLabelText = issueData.IssueName;
            ucIssueDescription1.CenterLabelText = issueData.IssueDesc;
            IssueDate.Value = issueData.PostedDate.Date;
            animatedLabelPriority.Text = issueData.Priority + "";
            animatedLabelType.Text = issueData.Type + "";

            pictureBoxFlag.Image = (issueData.Priority == Issue.IssuePriority.High) ? UserInterface.Properties.Resources.flag_stuck : (issueData.Priority == Issue.IssuePriority.Medium) ? UserInterface.Properties.Resources.flag_OnProcess : UserInterface.Properties.Resources.flag_done;
            SetTags();

        }

        private void SetTags()
        {
            foreach(string tg in issueData.Tags)
            {
                Panel spacePanel = new Panel()
                {
                    BackColor = Color.Transparent,
                    Dock = DockStyle.Top,
                    Height = 5
                };
                AnimatedLabel tags = new AnimatedLabel()
                {
                    Text = tg,
                    BackColor = Color.FromArgb(82, 109, 130),
                    ForeColor = Color.FromArgb(211, 220, 227),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = panelTags.Height / 5

                };
                
                panelTags.Controls.Add(tags);
                panelTags.Controls.Add(spacePanel);

            }
        }

        private void OnMouseClickClose(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_Alice_Blue_30;

        }

        private void OnPaintTagsPanel(object sender, PaintEventArgs e)
        {


            Point pt1 = new Point(4, 4);
            Point pt2 = new Point(panel2.Width - 6, 4);
            Point pt3 = new Point(panel2.Width - 6, panel2.Height - 6);
            Point pt4 = new Point(4, panel2.Height - 6);
            Pen border = new Pen(Color.Black, 2);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });

        }

        private void OnMouseLeaveDownloadPicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void OnMouseEnterDownloadPicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void OnClickDownloadAttachment(object sender, EventArgs e)
        {
            if(issueData== null)
            {
                return;
            }

            List<IssueAttachment> attachments = DataHandler.FetchIssueAttachementById(issueData.IssueID);

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
                string fileNetworkPath = attachments[ctr].IssueAttachmentLocation;
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

        private void OnClickAddSolution(object sender, EventArgs e)
        {
            if (issueData != null)
            {
                SolveNotesForm solutionForm = new SolveNotesForm(issueData);
                solutionForm.Show();
            }
        }
    }
}
