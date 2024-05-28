using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using TeamTracker;
using System.Windows.Forms;
using System.Reflection;

namespace UserInterface.Task.Timeline
{
    public partial class CurrentTimelineContent : UserControl
    {
        public event EventHandler Reset;
        private List<TeamTracker.Task> taskCollection;
        private List<TeamTracker.Task> viewTaskCollection;
        private bool isBackEnable, isNextEnable;
        private List<string> monthCollections;
        private List<Label> labelCollections;
        private TimeSpan dateDifference;
        private DateTime startViewDate, endViewDate, iterDate;
        private ProjectVersion version;
        private TimelineTask taskTimeline;
        private TeamTracker.Task edgedTask = null;

        public CurrentTimelineContent()
        {
            InitializeComponent();
            InitializeLabels();
            InitializePageColor();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, timelineControlPanel, new object[] { true });
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        public ProjectVersion Version
        {
            set
            {
                if (value != null)
                {
                    version = value;
                    iterDate = startViewDate = value.StartDate;
                    dateDifference = value.EndDate - value.StartDate;
                    isBackEnable = false;
                    isNextEnable = true;
                    endViewDate = startViewDate.AddDays(20);
                    taskCollection = TaskManager.FetchTasksByVersionID(version.VersionID);
                    InitializeTimeline();
                    InitializeLabels();
                    SetViewTaskCollection();
                }
            }
        }

        public List<Milestone> MilestoneCollection { get; internal set; }

        private void InitializePageColor()
        {
            for (int ctr = 0; ctr < 20; ctr++)
            {
                (tableLayoutPanel1.GetControlFromPosition(ctr, 0) as Label).BackColor = ThemeManager.CurrentTheme.PrimaryI;
                (tableLayoutPanel1.GetControlFromPosition(ctr, 0) as Label).ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            timelineControlPanel.BackColor = backBtn.BackColor = nextBtn.BackColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            backBtn.Image?.Dispose();   nextBtn.Image?.Dispose();

            ResetButton();

        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
            if(version != null)
            {
                SetViewTaskCollection();
            }
        }

        private void TimelineControlPaint(object sender, PaintEventArgs e)
        {
            int width, x, y, stepWidth;
            width = tableLayoutPanel1.Width; x = 0; stepWidth = tableLayoutPanel1.Width / 20; y = timelineControlPanel.Height;
            Pen border = new Pen(ThemeManager.CurrentTheme.SecondaryI, 2);
            border.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            while (x < width)
            {
                e.Graphics.DrawLine(border, x - 1, 0, x - 1, y);
                x += stepWidth;
            }
            border.Dispose();
        }

        private void OnNextDayClick(object sender, EventArgs e)
        {
            if (isNextEnable)
            {
                startViewDate = iterDate = startViewDate.AddDays(1);
                endViewDate = endViewDate.AddDays(1);
                InitializeTimeline();
                SetViewTaskCollection();
            }
        }

        private void OnPrevDayClick(object sender, EventArgs e)
        {
            if (isBackEnable)
            {
                startViewDate = iterDate = startViewDate.AddDays(-1);
                endViewDate = endViewDate.AddDays(-1);
                InitializeTimeline();
                SetViewTaskCollection();
            }
        }

        private void InitializeTimeline()
        {
            isBackEnable = iterDate == version.StartDate ? false : true;

            for (int ctr = 0; ctr < labelCollections.Count; ctr++)
            {
                labelCollections[ctr].BackColor = GetColorForLabel(iterDate);
                labelCollections[ctr].ForeColor = ThemeManager.GetTextColor(labelCollections[ctr].BackColor);
                labelCollections[ctr].Text = monthCollections[iterDate.Month - 1] + "\n" + iterDate.Day;
                iterDate = iterDate.AddDays(1);
            }

            isNextEnable = iterDate > version.EndDate ? false : true;

            if (backBtn.Image != null) { backBtn.Image.Dispose(); }
            if (nextBtn.Image != null) { nextBtn.Image.Dispose(); }

            ResetButton();
        }

        private Color GetColorForLabel(DateTime iterDate)
        {
            int ctr = 0;
            foreach(var Iter in MilestoneCollection)
            {
                if(Iter.StartDate<=iterDate && iterDate <= Iter.EndDate)
                {
                    return ThemeManager.CurrentTheme.MilestoneFadingOutColorCollection[ctr];
                    //return ColorManager.MilestoneColorFadingOut[ctr];
                }
                ctr++;
            }

            return ThemeManager.CurrentTheme.MilestoneFadingOutColorCollection[0];
        }

        private void InitializeLabels()
        {
            labelCollections = new List<Label>();
            for (int ctr = 0; ctr < 20; ctr++)
            {
                labelCollections.Add(tableLayoutPanel1.GetControlFromPosition(ctr, 0) as Label);
            }

            monthCollections = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
        }

        private void SetViewTaskCollection()
        {
            int ptr = 0;
            if (timelineControlPanel.Controls != null)
            {
                for (int idx = 0; idx < timelineControlPanel.Controls.Count; idx++)
                {
                    if ((edgedTask != null && (timelineControlPanel.Controls[idx] as TimelineTask).SelectedTask.TaskID != edgedTask.TaskID) || edgedTask == null)
                    {
                        (timelineControlPanel.Controls[idx] as TimelineTask).TimeLineMovement -= OnTimeLineMovement;
                        (timelineControlPanel.Controls[idx] as TimelineTask).TaskTimelineCheck -= OnTimelineDateChecked;
                        (timelineControlPanel.Controls[idx] as TimelineTask).TaskDateChange -= OnTaskDateChanged;
                        (timelineControlPanel.Controls[idx] as TimelineTask).Reset -= OnReset;
                        (timelineControlPanel.Controls[idx] as TimelineTask).Dispose();
                        idx--;
                    }
                }
            }

            viewTaskCollection = new List<TeamTracker.Task>();
            foreach (var Iter in taskCollection)
            {
                if ((startViewDate <= Iter.EndDate && Iter.EndDate <= endViewDate) || (startViewDate <= Iter.StartDate && Iter.StartDate <= endViewDate) || (Iter.StartDate <= startViewDate && endViewDate <= Iter.EndDate))
                {
                    viewTaskCollection.Add(Iter);
                }
            }

            if (edgedTask != null)
            {
                viewTaskCollection.Add(edgedTask);
            }

            viewTaskCollection.Sort((v1, v2) => v1.StartDate.CompareTo(v2.StartDate));

            DateTime prevStartDate = DateTime.MinValue, prevEndDate = DateTime.MinValue;
            int height = 50, width = tableLayoutPanel1.Width / 20, x = 0, y = 0, controlWidth = 0;

            int ctr = 0;
            foreach (var Iter in viewTaskCollection)
            {
                x = GetTimelinePosition(Iter.StartDate, width);
                controlWidth = GetTimelineWidth(Iter.StartDate, Iter.EndDate, width);
                if (prevStartDate <= Iter.StartDate && Iter.StartDate <= prevEndDate)
                {
                    prevEndDate = prevEndDate < Iter.EndDate ? Iter.EndDate : prevEndDate;
                    y = y + height;
                }
                else if (prevStartDate <= Iter.EndDate && Iter.EndDate <= prevEndDate)
                {
                    prevStartDate = Iter.StartDate < prevStartDate ? Iter.EndDate : prevStartDate;
                    y = y + height;
                }
                else if (Iter.StartDate <= prevStartDate && prevEndDate <= Iter.EndDate)
                {
                    prevStartDate = Iter.StartDate; prevEndDate = Iter.EndDate;
                    y = y + height;
                }
                else
                {
                    prevStartDate = Iter.StartDate; prevEndDate = Iter.EndDate;
                    y = 0;
                }

                if ((edgedTask != null && Iter.TaskID != edgedTask.TaskID) || edgedTask == null)
                {
                    taskTimeline = new TimelineTask()
                    {
                        Location = new Point(x, y),
                        Height = height,
                        Width = controlWidth,
                        SelectedTask = Iter,
                        StatusColor = ThemeManager.GetTaskStatusColor(Iter.StatusOfTask),
                        StepWidth = tableLayoutPanel1.Width / 20,
                        DisplayMode = SetDisplayMode(Iter.StartDate, Iter.EndDate)
                    };
                    taskTimeline.TimeLineMovement += OnTimeLineMovement;
                    taskTimeline.TaskTimelineCheck += OnTimelineDateChecked;
                    taskTimeline.TaskDateChange += OnTaskDateChanged;
                    taskTimeline.Reset += OnReset;
                    timelineControlPanel.Controls.Add(taskTimeline);
                }
                ctr++;
            }
        }

        private void OnReset(object sender, EventArgs e)
        {
            Reset?.Invoke(this, EventArgs.Empty);
        }

        private bool OnTimelineDateChecked(TimelineTask control)
        {
            int start = control.Location.X / (tableLayoutPanel1.Width / 20), end = (control.Location.X + control.Width) / (tableLayoutPanel1.Width / 20); end--;
            DateTime startDate = startViewDate.AddDays(start);
            DateTime endDate = startViewDate.AddDays(end);

            if(startDate.Date <= version.StartDate.Date)
            {
                ;
            }

            if(startDate.Date <= version.StartDate.Date || endDate.Date.AddDays(1).Date == version.EndDate.Date)
            {
                return true;
            }
            return false;
        }

        private int GetTimelinePosition(DateTime date, int width)
        {
            dateDifference = date - startViewDate;
            if (dateDifference.Days <= 0)
            {
                return 0;
            }
            else
            {
                return dateDifference.Days * width;
            }

        }

        private int GetTimelineWidth(DateTime startdate, DateTime endDate, int width)
        {
            dateDifference = startdate - startViewDate;
            if (dateDifference.Days <= 0)
            {
                startdate = startViewDate;
            }

            dateDifference = endViewDate - endDate;
            if (dateDifference.Days <= 0)
            {
                endDate = endViewDate.AddDays(-1);
            }

            return ((endDate - startdate).Days + 1) * width;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = ThemeManager.CurrentTheme.SecondaryII;
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "backBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = Properties.Resources.Cold_Left_Dark_Hover;
                }
                else
                {
                    backBtn.Image = Properties.Resources.Heat_Left_Dark_Hover;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = Properties.Resources.Cold_Right_Dark_Hover;
                }
                else
                {
                    nextBtn.Image = Properties.Resources.Heat_Right_Dark_Hover;
                }
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "backBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Dark : UserInterface.Properties.Resources.Cold_Left_Medium;
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
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Dark : UserInterface.Properties.Resources.Cold_Right_Medium;
                }
                else
                {
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Dark : UserInterface.Properties.Resources.Heat_Right_Medium;
                }
            }
        }

        private void OnTimeLineMovement(TimelineTask control, TeamTracker.Task selectedTask, int direction)
        {
            foreach(var Iter in taskCollection)
            {
                if(selectedTask.TaskID == Iter.TaskID)
                {
                    dateCollection1.Add(startViewDate);
                    if (direction == -1)
                    {
                        iterDate = startViewDate = startViewDate.AddDays(-1);
                        Iter.StartDate = startViewDate;
                        endViewDate = endViewDate.AddDays(-1);
                        edgedTask = Iter;
                    }
                    if(direction == 1)
                    {
                        iterDate = startViewDate = startViewDate.AddDays(1);
                        Iter.EndDate = endViewDate;
                        endViewDate = endViewDate.AddDays(1);
                        edgedTask = Iter;
                    }
                    if(direction == -2)
                    {
                        iterDate = startViewDate = startViewDate.AddDays(-1);
                        var x = (Iter.EndDate - Iter.StartDate).Days;
                        Iter.StartDate = startViewDate;
                        Iter.EndDate = Iter.StartDate.AddDays(x);
                        endViewDate = endViewDate.AddDays(-1);
                        edgedTask = Iter;
                    }
                    if(direction == 2)
                    {
                        cnt++;
                        iterDate = startViewDate = startViewDate.AddDays(1);
                        var x = (Iter.EndDate - Iter.StartDate).Days;
                        Iter.EndDate = endViewDate;
                        Iter.StartDate = Iter.EndDate.AddDays(-x);
                        endViewDate = endViewDate.AddDays(1);
                        edgedTask = Iter;
                    }
                    dateCollection2.Add(startViewDate);
                    InitializeTimeline();
                    SetViewTaskCollection();
                    control.DisplayMode = SetDisplayMode(Iter.StartDate, Iter.EndDate);
                    break;
                }
            }
            edgedTask = null;
        }

        private TimelineDisplayMode SetDisplayMode(DateTime taskStartDate, DateTime taskEndDate)
        {
            if(startViewDate < taskStartDate && taskEndDate < endViewDate)
            {
                return TimelineDisplayMode.Full;
            }
            else if(taskStartDate <= startViewDate)
            {
                return TimelineDisplayMode.LeftPartial;
            }
            else if(endViewDate <= taskEndDate)
            {
                return TimelineDisplayMode.RightPartial;
            }
            else
            {
                return TimelineDisplayMode.Outer;
            }
        }

        private void OnTaskDateChanged(TimelineTask control, TeamTracker.Task selectedTask, int direction)
        {
            int start = control.Location.X / (tableLayoutPanel1.Width / 20), end = (control.Location.X + control.Width) / (tableLayoutPanel1.Width / 20);   end--;
            foreach (var Iter in taskCollection)
            {
                if (selectedTask.TaskID == Iter.TaskID)
                {
                    DateTime startDate, endDate;
                    if (direction == 1)
                    {
                        startDate = selectedTask.StartDate;
                        endDate = startViewDate.AddDays(end);
                    }
                    else if(direction == -1)
                    {
                        startDate = startViewDate.AddDays(start);
                        endDate = selectedTask.EndDate;
                    }
                    else
                    {
                        int duration = (Iter.EndDate - Iter.StartDate).Days;
                        //duration++;
                        if(Iter.StartDate < startViewDate)
                        {
                            endDate = startViewDate.AddDays(end);
                            startDate = endDate.AddDays(-duration);
                        }
                        else if(endViewDate < Iter.EndDate)
                        {
                            startDate = startViewDate.AddDays(start);
                            endDate = startDate.AddDays(duration);
                        }
                        else
                        {
                            startDate = startViewDate.AddDays(start);
                            endDate = startViewDate.AddDays(end);
                        }
                    }

                    if (MilestoneManager.IsTaskWithinTheMilestone(startDate, endDate, selectedTask.MilestoneID))
                    {
                        iterDate = startViewDate;
                        Iter.StartDate = startDate;
                        Iter.EndDate = endDate;
                        TaskManager.UpdateTask(Iter.TaskID, Iter.TaskName, Iter.TaskDesc, Iter.StartDate, Iter.EndDate, Iter.StatusOfTask, Iter.MilestoneID, Iter.TaskPriority, Iter.AssignedTo, null);
                        //ProjectManagerMainForm.notify.AddNotification("Task Updation", "Task Date has been Updated");
                    }
                    else
                    {
                        ProjectManagerMainForm.notify.AddNotification("Warning", "Task Deadline is not within the Milestone Deadline");
                        TeamTracker.Task task = TaskManager.FetchTaskByTaskID(Iter.TaskID);
                        startViewDate = Iter.StartDate = iterDate = task.StartDate;
                        endViewDate = startViewDate.AddDays(20);
                        if (endViewDate > version.EndDate)
                        {
                            endViewDate = version.EndDate.AddDays(1);
                            startViewDate = iterDate = endViewDate.AddDays(-20);
                        }
                        Iter.EndDate = task.EndDate;
                        cnt = 0;
                        dateCollection1 = new List<DateTime>();
                        dateCollection2 = new List<DateTime>();
                    }

                    InitializeTimeline();
                    SetViewTaskCollection();
                    control.DisplayMode = SetDisplayMode(Iter.StartDate, Iter.EndDate);
                    break;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //SetViewTaskCollection();
        }

        private void ResetButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                backBtn.Image = isBackEnable ? Properties.Resources.Cold_Left_Dark : Properties.Resources.Cold_Left_Medium;
                nextBtn.Image = isNextEnable ? Properties.Resources.Cold_Right_Dark : Properties.Resources.Cold_Right_Medium;
            }
            else
            {
                backBtn.Image = isBackEnable ? Properties.Resources.Heat_Left_Dark : Properties.Resources.Heat_Left_Medium;
                nextBtn.Image = isNextEnable ? Properties.Resources.Heat_Right_Dark : Properties.Resources.Heat_Right_Medium;
            }
        }

        private void TimelineControlClear()
        {
            for (int ctr = 0; ctr < timelineControlPanel.Controls.Count; ctr++)
            {
                (timelineControlPanel.Controls[ctr] as TimelineTask).TimeLineMovement -= OnTimeLineMovement;
                (timelineControlPanel.Controls[ctr] as TimelineTask).TaskTimelineCheck -= OnTimelineDateChecked;
                (timelineControlPanel.Controls[ctr] as TimelineTask).TaskDateChange -= OnTaskDateChanged;
                (timelineControlPanel.Controls[ctr] as TimelineTask).Reset -= OnReset;
                (timelineControlPanel.Controls[ctr] as TimelineTask).Dispose();
                ctr--;
            }
        }

        int cnt = 0;
        private List<DateTime> dateCollection1 = new List<DateTime>();
        private List<DateTime> dateCollection2 = new List<DateTime>();
    }
}
