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
    public partial class TaskInfoForm : Form
    {
        public event EventHandler InfoFormClose;
        public TaskInfoForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            this.Location = new Point(700, 300);
            toolTip1.SetToolTip(pictureBoxFlag, "Priority");
            toolTip1.SetToolTip(animatedLabelMilestone, "Milestone");
        }

        public TeamTracker.Task selectedTask;

        public TeamTracker.Task SelectedTask
        {
            set
            {
                selectedTask = value;
                InitializePage();
            }
        }

        public List<SourceCode> SourceCodeList
        {
            get { return SourceCodeList; }
            set
            {
                sourceCodeList = value;
                SetCommits();
            }
        }

        public int SourceCodeID { get; set; }
        public int TaskID { get; set; }
        public string CommitName { get; set; }
        public string SourceCodeLocation { get; set; }
        public DateTime SubmittedDate { get; set; }

        private List<SourceCode> sourceCodeList;

        public new void Dispose()
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            if (pictureBoxDownloadAttachment.Image != null) pictureBoxDownloadAttachment.Image.Dispose();
            if (pictureBoxFlag.Image != null) pictureBoxFlag.Image.Dispose();

            pictureBox1.Dispose(); pictureBoxDownloadAttachment.Dispose(); pictureBoxFlag.Dispose();
            label1.Dispose();   animatedLabelMilestone.Dispose();   animatedLabelStatus.Dispose();  labelTitle.Dispose();
            tableLayoutPanel1.Dispose();    tableLayoutPanel3.Dispose();
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();   panel4.Dispose();   panel5.Dispose();   panel6.Dispose();
            startDate.Dispose();    endDate.Dispose();  ucTaskDescription1.Dispose();
            profileAssignedBy.Dispose();    ucNotFound1.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetCommits();
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



        private void SetCommits()
        {
            sourceCodeList = DataHandler.FetchSourceCodeByTaskID(selectedTask.TaskID);
            if (sourceCodeList == null || sourceCodeList.Count == 0)
            {
                ucNotFound1.Visible = true;
                panelCommits.Visible = false;
                return;
            }

            Dictionary<DateTime, List<SourceCode>> dateWiseDict = sourceCodeList.GroupBy(s => s.SubmittedDate).ToDictionary(g => g.Key, g => g.ToList());

            foreach (var entry in dateWiseDict)
            {
                int commitCount = dateWiseDict[entry.Key].Count;
                UcTaskCommitsHead head = new UcTaskCommitsHead();
                head.CommitCount = commitCount;
                head.CommitDate = entry.Key;
                head.Dock = DockStyle.Top;
                head.BackColor = Color.FromArgb(211, 220, 227);
                panelCommits.Controls.Add(head);

                foreach (SourceCode srcCode in dateWiseDict[entry.Key])
                {
                    UcTaskCommits commit = new UcTaskCommits();
                    commit.CommitName = srcCode.CommitName;
                    commit.CommitOwner = EmployeeManager.FetchEmployeeFromID(srcCode.CommitedBy);
                    
                    commit.Dock = DockStyle.Top;
                    panelCommits.Controls.Add(commit);
                }
            }

            foreach (Control ctr in panelCommits.Controls)
            {
                ctr.BringToFront();
            }


        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void OnMouseClickClose(object sender, MouseEventArgs e)
        {
            InfoFormClose?.Invoke(this, EventArgs.Empty);
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close;
        }

        private void OnPaintTotalCommitsPanel(object sender, PaintEventArgs e)
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
            if (pictureBoxDownloadAttachment.Image != null) pictureBoxDownloadAttachment.Image.Dispose();

            pictureBoxDownloadAttachment.Image = UserInterface.Properties.Resources.Download_Dark_Blue;
        }

        private void OnMouseEnterDownloadPicBox(object sender, EventArgs e)
        {
            if (pictureBoxDownloadAttachment.Image != null) pictureBoxDownloadAttachment.Image.Dispose();

            pictureBoxDownloadAttachment.Image = UserInterface.Properties.Resources.Download_Light_Blue_Hover;
        }

        private void InitializePage()
        {
            labelTitle.Text = VersionManager.FetchProjectName(selectedTask.VersionID) + "\n" + VersionManager.FetchVersionFromTaskID(selectedTask.VersionID).VersionName;
            profileAssignedBy.EmployeeProfile = EmployeeManager.FetchEmployeeFromID(selectedTask.AssignedBy);
            ucTaskDescription1.TopLabelText = selectedTask.TaskName;
            ucTaskDescription1.CenterLabelText = selectedTask.TaskDesc;
            animatedLabelMilestone.Text = MilestoneManager.FetchMilestoneFromID(selectedTask.MilestoneID).MileStoneName;
            startDate.Value = selectedTask.StartDate;
            endDate.Value = selectedTask.EndDate;

            switch (selectedTask.TaskPriority)
            {
                case Priority.Critical: pictureBoxFlag.Image = UserInterface.Properties.Resources.Critical; break;
                case Priority.Hard: pictureBoxFlag.Image = UserInterface.Properties.Resources.Hard; break;
                case Priority.Medium: pictureBoxFlag.Image = UserInterface.Properties.Resources.Medium; break;
                default: pictureBoxFlag.Image = UserInterface.Properties.Resources.Easy; break;
            }
            animatedLabelStatus.Text = selectedTask.StatusOfTask.ToString();
            animatedLabelStatus.BackColor = ColorManager.FetchTaskStatusColor(selectedTask.StatusOfTask);
        }

        private void AttachmentDownloadClick(object sender, EventArgs e)
        {
            TaskAttachment attachment = DataHandler.GetTaskAttachment(selectedTask.TaskID);
            if(attachment == null)
            {
                ProjectManagerMainForm.notify.AddNotification("No Attachments Found", "No Attachments Found");
                return;
            }

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
            string fileNetworkPath = attachment.TaskAttachmentLocation;
            try
            {
                string fileName = System.IO.Path.GetFileName(fileNetworkPath);
                string filePath = System.IO.Path.GetDirectoryName(savePath);
                filePath = System.IO.Path.Combine(filePath, attachment.TaskAttachmentName);
                System.IO.File.Copy(fileNetworkPath, filePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", attachment.TaskAttachmentName);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", attachment.TaskAttachmentName);
            }
        }
    }
}

