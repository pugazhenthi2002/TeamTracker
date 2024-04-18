using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.ViewPage.ListView;

namespace TeamTracker
{
    public partial class SingleList : UserControl
    {
        public Task ListTask
        {
            set
            {
                task = value;
                SetTaskUI();
            }
        }

        public event EventHandler Reset;
        private Task task;
        public SingleList()
        {
            InitializeComponent();
        }

        public void SetTaskUI()
        {
            taskName.Text = task.TaskName;
            assignedBy.Profile = EmployeeManager.FetchEmployeeFromID(task.AssignedBy);
            statusLabel.Text = task.StatusOfTask.ToString();
            priorityLabel.Text = task.TaskPriority.ToString();
            dueDateLabel.Text = task.EndDate.ToShortDateString();
            SetAnimatedLabelBackColor();
        }

        private void OnStatusClicked(object sender, EventArgs e)
        {
            Point pt = new Point(-(200 - statusLabel.Width) / 2, statusLabel.Height);
            pt = statusLabel.PointToScreen(pt);
            StatusDropDown newForm = new StatusDropDown();
            newForm.Location = pt;
            newForm.StatusChanged += OnStatusChanged;
            newForm.Show();
        }

        private void OnStatusChanged(object sender, string e)
        {
            if (e == "Under Review")
            {
                SourceCodeSubmitionForm newForm = new SourceCodeSubmitionForm();
                newForm.SourceCodeTask = task;
                newForm.DoneClick += OnSourceCodeSubmission;
                newForm.Show();
            }
            else
            {
                if(task.StatusOfTask == TaskStatus.UnderReview)
                {
                    StatusChangeWarningForm form = new StatusChangeWarningForm();
                    form.PrevStatus = e;
                    form.WarningStatus += OnWarningStatusClicked;
                    form.Show();
                }
                else
                {
                    if (e == "Stuck") task.StatusOfTask = TaskStatus.Stuck;
                    if (e == "Working On It") task.StatusOfTask = TaskStatus.OnProcess;
                    if (e == "Not Yet Started") task.StatusOfTask = TaskStatus.NotYetStarted;

                    TaskManager.UpdateTask(task.TaskID, task.TaskName, task.TaskDesc, task.StartDate, task.EndDate, task.StatusOfTask, task.MilestoneID, task.TaskPriority, task.AssignedTo, null);
                    SetTaskUI();

                    Reset?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void OnSourceCodeSubmission(object sender, SourceCode e)
        {
            task.StatusOfTask = TaskStatus.UnderReview;
            DataHandler.SubmitSourceCode(e);
            TaskManager.UpdateTask(task.TaskID, task.TaskName, task.TaskDesc, task.StartDate, task.EndDate, TaskStatus.UnderReview, task.MilestoneID, task.TaskPriority, task.AssignedTo, null);
            SetTaskUI();
            Reset?.Invoke(this, EventArgs.Empty);
        }

        private void SetAnimatedLabelBackColor()
        {
            switch (task.StatusOfTask)
            {
                case TaskStatus.UnderReview: statusLabel.BackColor = Color.Green; break;
                case TaskStatus.Stuck: statusLabel.BackColor = Color.Red; break;
                case TaskStatus.OnProcess: statusLabel.BackColor = Color.Yellow; break;
                default: statusLabel.BackColor = Color.Gray; break;
            }

            switch (task.TaskPriority)
            {
                case Priority.Critical: priorityLabel.BackColor = Color.FromArgb(181, 23, 158); break;
                case Priority.Hard: priorityLabel.BackColor = Color.FromArgb(114, 9, 183); break;
                case Priority.Medium: priorityLabel.BackColor = Color.FromArgb(72, 12, 168); break;
                default: priorityLabel.BackColor = Color.FromArgb(63, 55, 201); break;
            }
        }

        private void OnWarningStatusClicked(string e, bool result)
        {
            if (result)
            {
                if (e == "Stuck") task.StatusOfTask = TaskStatus.Stuck;
                if (e == "Working On It") task.StatusOfTask = TaskStatus.OnProcess;
                if (e == "Not Yet Started") task.StatusOfTask = TaskStatus.NotYetStarted;

                TaskManager.UpdateTask(task.TaskID, task.TaskName, task.TaskDesc, task.StartDate, task.EndDate, task.StatusOfTask, task.MilestoneID, task.TaskPriority, task.AssignedTo, null);
                DataHandler.DeleteSourceCode(task.TaskID);
                SetTaskUI();
                Reset?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Pen border = new Pen(Color.FromArgb(39, 55, 77));
            Rectangle rec = new Rectangle(0, 0, (Width / 6)-1, Height - 1);
            
            for(int ctr=0; ctr < 6; ctr++)
            {
                e.Graphics.DrawRectangle(border, rec);
                rec.X = rec.X + (Width / 6);
            }
            border.Dispose();
        }

        private void ViewTaskClick(object sender, EventArgs e)
        {
            TaskInfoForm form = new TaskInfoForm();
            form.SelectedTask = task;
            form.Show();
        }
    }
}
