using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeamTracker;
using GoLibrary;

namespace TeamTracker
{
    public partial class TimelinePaginate : UserControl
    {

        public List<Milestone> milestoneCollection;
        private List<Task> taskCollection;
        private List<Task> viewTaskCollection;
        private bool isBackEnable, isNextEnable;
        private List<string> monthCollections;
        private List<Label> labelCollections;
        private List<Color> colorCollections;
        private List<Color> viewColorCollections;
        private TimeSpan dateDifference;
        private DateTime startViewDate, endViewDate, iterDate;
        private ProjectVersion version;
        private TaskTimelineTemplate taskTimeline;
        private Employee filteredEmployee;

        public TimelinePaginate()
        {
            InitializeComponent();
            InitializeLabels();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void InitializePageColor()
        {
            for (int ctr = 0; ctr < 20; ctr++)
            {
                (tableLayoutPanel1.GetControlFromPosition(ctr, 0) as Label).BackColor = ThemeManager.CurrentTheme.PrimaryI;
                (tableLayoutPanel1.GetControlFromPosition(ctr, 0) as Label).ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            ucNotFound1.BackColor = backBtn.BackColor = nextBtn.BackColor =  BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            backBtn.Image?.Dispose(); nextBtn.Image?.Dispose();

            ResetButton();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        public List<Color> Colors
        {
            set
            {
                colorCollections = value;
            }
        }

        public ProjectVersion Version
        {
            set
            {
                version = value;
                if (version != null)
                {
                    iterDate = startViewDate = value.StartDate;
                    dateDifference = value.EndDate - value.StartDate;
                    isBackEnable = false;
                    isNextEnable = true;
                    endViewDate = startViewDate.AddDays(20);
                    if (filteredEmployee == null) taskCollection = TaskManager.FetchTasksByVersionID(version.VersionID);
                    else
                    {
                        taskCollection = TaskManager.FetchTaskByEmployee(filteredEmployee, version.VersionID);
                    }
                    if (taskCollection != null && taskCollection.Count > 0)
                    {
                        ucNotFound1.Visible = false;
                        panel1.Visible = true;
                        milestoneCollection = MilestoneManager.FetchMilestones(value.VersionID);
                        InitializeTimeline();
                        SetViewTaskCollection();
                    }
                    else
                    {
                        panel1.Visible = false;
                        ucNotFound1.Visible = true;
                    }
                }
            }
        }


        public Employee FilteredEmployee
        {
            get
            {
                return filteredEmployee;
            }
            set
            {
                filteredEmployee = value;

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
            isBackEnable = iterDate == version.StartDate?false:true;

            for(int ctr=0; ctr< labelCollections.Count; ctr++)
            {
                labelCollections[ctr].Text = monthCollections[iterDate.Month - 1]+"\n"+iterDate.Day;
                iterDate = iterDate.AddDays(1);
            }

            isNextEnable = iterDate > version.EndDate ? false : true;

            if (backBtn.Image != null) { backBtn.Image.Dispose(); }
            if (nextBtn.Image != null) { nextBtn.Image.Dispose(); }

            ResetButton();
        }

        private void InitializeLabels()
        {
            labelCollections = new List<Label>();
            for (int ctr=0; ctr< 20; ctr++)
            {
                labelCollections.Add(tableLayoutPanel1.GetControlFromPosition(ctr, 0) as Label);
            }

            monthCollections = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
        }

        private void SetViewTaskCollection()
        {
            TimelineControlClear();

            viewTaskCollection = new List<Task>();
            viewColorCollections = new List<Color>();

            foreach(var Iter in taskCollection)
            {
                if((startViewDate <= Iter.EndDate && Iter.EndDate <= endViewDate) || (startViewDate <= Iter.StartDate && Iter.StartDate <= endViewDate) || (Iter.StartDate <= startViewDate && endViewDate <= Iter.EndDate))
                {
                    viewTaskCollection.Add(Iter);
                }
            }

            viewTaskCollection.Sort((v1, v2) => v1.StartDate.CompareTo(v2.StartDate));

            foreach (var Iter in viewTaskCollection)
            {
                viewColorCollections.Add(FetchColorFromMilestoneID(Iter.MilestoneID));
            }


            DateTime prevStartDate = DateTime.MinValue, prevEndDate = DateTime.MinValue;
            int height = 50, width = tableLayoutPanel1.Width / 20 , x = 0, y = 0, controlWidth = 0;

            int ctr = 0;
            foreach(var Iter in viewTaskCollection)
            {
                x = GetTimelinePosition(Iter.StartDate, width);
                controlWidth = GetTimelineWidth(Iter.StartDate, Iter.EndDate, width);
                if (prevStartDate <= Iter.StartDate && Iter.StartDate <= prevEndDate)
                {
                    prevEndDate = prevEndDate < Iter.EndDate ? Iter.EndDate : prevEndDate;
                    y = y + height;
                }
                else if(prevStartDate <= Iter.EndDate && Iter.EndDate <= prevEndDate)
                {
                    prevStartDate = Iter.StartDate < prevStartDate ? Iter.EndDate : prevStartDate;
                    y = y + height;
                }
                else if(Iter.StartDate <= prevStartDate && prevEndDate <= Iter.EndDate)
                {
                    prevStartDate = Iter.StartDate; prevEndDate = Iter.EndDate;
                    y = y + height;
                }
                else
                {
                    prevStartDate = Iter.StartDate; prevEndDate = Iter.EndDate;
                    y = 0;
                }
                taskTimeline = new TaskTimelineTemplate()
                {
                    Location = new Point(x, y),
                    Height = height,
                    Width = controlWidth,
                    TimelineTask = Iter,
                    TimelineColor = viewColorCollections[ctr]
                };
                timelineControlPanel.Controls.Add(taskTimeline);
                ctr++;
            }
        }

        private void OnPaginateMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = ThemeManager.CurrentTheme.SecondaryII;
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

        private void OnPaginateMouseLeave(object sender, EventArgs e)
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

        private int GetTimelinePosition(DateTime date, int width)
        {
            dateDifference = date - startViewDate;
            if(dateDifference.Days <= 0)
            {
                return 0;
            }
            else
            {
                return dateDifference.Days * width ;
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

        private Color FetchColorFromMilestoneID(int milestonID)
        {
            int ctr = 0;
            foreach(var Iter in milestoneCollection)
            {
                if(Iter.MileStoneID == milestonID)
                {
                    return colorCollections[ctr];
                }
                ctr++;
            }

            return ThemeManager.CurrentTheme.PrimaryI;
        }

        private void ResetButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Dark : UserInterface.Properties.Resources.Cold_Left_Medium;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Dark : UserInterface.Properties.Resources.Cold_Right_Medium;
            }
            else
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Heat_Left_Dark : UserInterface.Properties.Resources.Heat_Left_Medium;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Dark : UserInterface.Properties.Resources.Heat_Right_Medium;
            }
        }

        private void TimelineControlClear()
        {
            for(int ctr=0; ctr < timelineControlPanel.Controls.Count; ctr++)
            {
                (timelineControlPanel.Controls[ctr] as TaskTimelineTemplate).Dispose();
                ctr--;
            }
        }
    }
}
