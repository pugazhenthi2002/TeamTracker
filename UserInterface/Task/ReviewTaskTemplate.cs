using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;
using UserInterface.ViewPage;
using UserInterface.Task.CreateTask;
using System.Runtime.InteropServices;

namespace UserInterface.Task
{
    public partial class ReviewTaskTemplate : UserControl
    {
        private TransparentForm transparentForm;
        public event EventHandler TaskReviewed;
        public ReviewTaskTemplate()
        {
            InitializeComponent();
        }

        private TeamTracker.Task selectedTask;
        public TeamTracker.Task SelectedTask
        {
            get
            {
                return selectedTask;
            }
            set
            {
                selectedTask = value;
                SetReviewUI();
            }
        }

        private void InitializePageColor()
        {
            profilePictureBox1.ParentColor = tableLayoutPanel1.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            taskNameLabel.ForeColor = projectName.ForeColor = dueDate.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.SecondaryI);
            downloadSourceCodeButton.BackColor = reassignButton.BackColor = doneButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            downloadSourceCodeButton.ForeColor = reassignButton.ForeColor = doneButton.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.PrimaryI);
        }

        private void SetReviewUI()
        {
            InitializePageColor();
            projectName.Text = VersionManager.FetchProjectName(selectedTask.VersionID);
            taskNameLabel.Text = selectedTask.TaskName;
            dueDate.Text = selectedTask.EndDate.ToShortDateString();

            switch (selectedTask.TaskPriority)
            {
                case Priority.Critical:
                    pictureBox1.Image = UserInterface.Properties.Resources.Critical;
                    break;
                case Priority.Hard:
                    pictureBox1.Image = UserInterface.Properties.Resources.Hard;
                    break;
                case Priority.Medium:
                    pictureBox1.Image = UserInterface.Properties.Resources.Medium;
                    break;
                case Priority.Easy:
                    pictureBox1.Image = UserInterface.Properties.Resources.Easy;
                    break;
                default:
                    pictureBox1.Image = UserInterface.Properties.Resources.flag_empty;
                    break;
            }
        }

        private void OnDownloadSourceCOde(object sender, EventArgs e)
        {
            SourceCode sourceCode = DataHandler.GetTaskSource(selectedTask.TaskID);

            string savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ZIP Folders(.ZIP)| *.zip";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }

            string fileNetworkPath = sourceCode.SourceCodeLocation;
            try
            {
                System.IO.File.Copy(fileNetworkPath, savePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", savePath);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", savePath);
            }
        }

        private void OnDoneClick(object sender, EventArgs e)
        {
            WarningForm form = new WarningForm();
            form.Content = "Are you sure, you want move the Task to Done Status?";
            form.WarningStatus += OnDoneWarningStatus;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnDoneWarningStatus(object sender, bool e)
        {
            (sender as WarningForm).Dispose();
            (sender as WarningForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (e)
            {
                TaskManager.UpdateTask(selectedTask.TaskID, selectedTask.TaskName, selectedTask.TaskDesc, selectedTask.StartDate, selectedTask.EndDate, TeamTracker.TaskStatus.Done, selectedTask.MilestoneID, selectedTask.TaskPriority, selectedTask.AssignedTo, null);
                TaskReviewed?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnReassignClick(object sender, EventArgs e)
        {
            WarningForm form = new WarningForm();
            form.Content = "Are you sure, you want to Reassign the Task?";
            form.WarningStatus += OnReassignWarningStatus;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnReassignWarningStatus(object sender, bool e)
        {
            (sender as WarningForm).Dispose();
            (sender as WarningForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (e)
            {
                CreateTaskForm form = new CreateTaskForm();
                form.SelectedTask = selectedTask;
                form.TaskCreate += OnUpdated;
                form.TaskFormClose += OnTaskFormClosed;

                transparentForm = new TransparentForm();
                transparentForm.Show();
                transparentForm.ShowForm(form);
            }
        }

        private void OnTaskFormClosed(object sender, EventArgs e)
        {
            (sender as CreateTaskForm).Dispose();
            (sender as CreateTaskForm).Close();

            if (ParentForm != null)
                ParentForm.Show();
        }

        private void OnUpdated(object sender, EventArgs e)
        {
            TaskReviewed?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
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

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            Pen border1 = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 10));
            border1.Dispose();
        }
    }
}
