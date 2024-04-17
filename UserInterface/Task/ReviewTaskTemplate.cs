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

namespace UserInterface.Task
{
    public partial class ReviewTaskTemplate : UserControl
    {
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

        private void SetReviewUI()
        {
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
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }

            string fileNetworkPath = sourceCode.SourceCodeLocation;
            try
            {
                string fileName = System.IO.Path.GetFileName(fileNetworkPath);
                string filePath = System.IO.Path.GetDirectoryName(savePath);
                filePath = System.IO.Path.Combine(filePath, sourceCode.CommitName);
                System.IO.File.Copy(fileNetworkPath, filePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", sourceCode.CommitName);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", sourceCode.CommitName);
            }
        }

        private void OnDoneClick(object sender, EventArgs e)
        {
            WarningForm form = new WarningForm();
            form.Content = "Are you sure, you want move the Task to Done Status?";
            form.WarningStatus += OnDoneWarningStatus;
            form.Show();
        }

        private void OnDoneWarningStatus(object sender, bool e)
        {
            TaskManager.UpdateTask(selectedTask.TaskID, selectedTask.TaskName, selectedTask.TaskDesc, selectedTask.StartDate, selectedTask.EndDate, TeamTracker.TaskStatus.Done, selectedTask.MilestoneID, selectedTask.TaskPriority, selectedTask.AssignedTo, null);
        }

        private void OnReassignClick(object sender, EventArgs e)
        {
            WarningForm form = new WarningForm();
            form.Content = "Are you sure, you want to Reassign the Task?";
            form.WarningStatus += OnReassignWarningStatus;
            form.Show();
            TaskReviewed?.Invoke(this, EventArgs.Empty);
        }

        private void OnReassignWarningStatus(object sender, bool e)
        {
            CreateTaskForm form = new CreateTaskForm();
            form.SelectedTask = selectedTask;
            form.TaskCreate += OnUpdated;
            form.Show();
        }

        private void OnUpdated(object sender, EventArgs e)
        {
            TaskReviewed?.Invoke(this, EventArgs.Empty);
        }
    }
}
