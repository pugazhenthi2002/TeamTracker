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
using UserInterface;

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

        private TransparentForm transparentForm;
        public event EventHandler Reset;
        private Task task;
        public SingleList()
        {
            InitializeComponent();
        }

        public void SetTaskUI()
        {
            InitializePageColor();
            taskName.Text = task.TaskName;
            assignedBy.Profile = EmployeeManager.FetchEmployeeFromID(task.AssignedBy);
            statusLabel.Text = task.StatusOfTask.ToString();
            priorityLabel.Text = task.TaskPriority.ToString();
            dueDateLabel.Text = task.EndDate.ToShortDateString();
        }

        public void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            statusLabel.BackColor = ThemeManager.GetTaskStatusColor(task.StatusOfTask);
            statusLabel.LabelCornerColor = priorityLabel.LabelCornerColor = BackColor;
            priorityLabel.BackColor = ThemeManager.GetTaskPriorityColor(task.TaskPriority);
            statusLabel.ForeColor = ThemeManager.GetTextColor(statusLabel.BackColor);
            priorityLabel.ForeColor = ThemeManager.GetTextColor(priorityLabel.BackColor);
            priorityLabel.ParentColor = statusLabel.ParentColor = assignedBy.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
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

                transparentForm = new TransparentForm();
                transparentForm.Show();
                transparentForm.ShowForm(newForm);
            }
            else
            {
                if(task.StatusOfTask == TaskStatus.UnderReview)
                {
                    StatusChangeWarningForm form = new StatusChangeWarningForm();
                    form.PrevStatus = e;
                    form.WarningStatus += OnWarningStatusClicked;

                    transparentForm = new TransparentForm();
                    transparentForm.Show();
                    transparentForm.ShowForm(form);
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
            (sender as SourceCodeSubmitionForm).Dispose();
            (sender as SourceCodeSubmitionForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (e != null)
            {
                task.StatusOfTask = TaskStatus.UnderReview;
                DataHandler.SubmitSourceCode(e);
                TaskManager.UpdateTask(task.TaskID, task.TaskName, task.TaskDesc, task.StartDate, task.EndDate, TaskStatus.UnderReview, task.MilestoneID, task.TaskPriority, task.AssignedTo, null);
                SetTaskUI();
                Reset?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnWarningStatusClicked(object sender, string e, bool result)
        {
            (sender as StatusChangeWarningForm).Dispose();
            (sender as StatusChangeWarningForm).Close();
            transparentForm.Close();

            if (ParentForm != null)
                ParentForm.Show();

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

        private void ViewTaskClick(object sender, EventArgs e)
        {
            TaskInfoForm form = new TaskInfoForm();
            form.SelectedTask = task;
            form.InfoFormClose += OnTaskInfoFormClosed;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnTaskInfoFormClosed(object sender, EventArgs e)
        {
            (sender as TaskInfoForm).Dispose();
            (sender as TaskInfoForm).Close();

            if (ParentForm != null)
                ParentForm.Show();
        }

        private void EdgePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawRectangle(border, new Rectangle(0, 0,(sender as Control).Width-1, (sender as Control).Height-1));
            border.Dispose();
        }
    }
}
