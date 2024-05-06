using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class IssueInfoForm : Form
    {
        public event EventHandler IssueInfoFormClose;

        private Issue issueData;
        private IssueSolutionAttachment issueSolutionAttachment;

        public IssueInfoForm()
        {
            InitializeComponent();
        }

        public new void Dispose()
        {
            ;
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
            ucIssueDescription1.Text = issueData.IssueDesc;
            IssueTitleTextBox.Text = issueData.IssueName;
            IssueDate.Value = issueData.PostedDate.Date;
            BtnSetPriority.Text = issueData.Priority + "";
            BtnSetType.Text = issueData.Type + "";
            var result = DataHandler.FetchIssueAttachementById(issueData.IssueID);
            if (result == null || result.Count == 0)
            {
                label4.Visible = pictureBox1.Visible = false;
                ucNotFound1.Visible = true;
            }
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
            IssueInfoFormClose?.Invoke(this, EventArgs.Empty);
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
            if (solutionTextBox.Text == "")
            {
                ProjectManagerMainForm.notify.AddNotification("Warning", "Invalid Solution Input\nPlease enter some Solutions");
                return;
            }

            IssueSolution soln = new IssueSolution()
            {
                IssueID = issueData.IssueID,
                Solution = solutionTextBox.Text,
                SolvedByID = EmployeeManager.CurrentEmployee.EmployeeID
            };


            IssueManager.AddSolution(soln, issueSolutionAttachment);

            IssueInfoFormClose?.Invoke(this, EventArgs.Empty);
        }

        private void OnAddAttachment(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open File";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string safeFile = openFileDialog.SafeFileName;

                string extension = System.IO.Path.GetExtension(selectedFilePath);

                issueSolutionAttachment = new IssueSolutionAttachment()
                {
                    IssueSolutionID = issueData.IssueID,
                    DisplayName = safeFile,
                    IssueSolnAttachmentName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + extension,
                    IssueSolnAttachmentLocation = selectedFilePath
                };

                labelAttachment.Show();

            }
            else
            {
                labelAttachment.Hide();
            }
        }
        private void OnClickAttachmentCount(object sender, EventArgs e)
        {
            labelAttachment.Hide();
            issueSolutionAttachment = null;
        }
    }
}
