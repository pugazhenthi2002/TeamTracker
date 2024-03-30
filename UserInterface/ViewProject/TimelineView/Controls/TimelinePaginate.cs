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

namespace UserInterface.ViewProject.TimelineView.Controls
{
    public partial class TimelinePaginate : UserControl
    {
        public TimelinePaginate()
        {
            InitializeComponent();
            InitializeLabels();
        }

        private List<Task> taskCollection;
        private List<Task> viewTaskCollection;
        private List<TaskTimelineTemplate> timeLineCollection;
        public ProjectVersion Version
        {
            set
            {
                version = value;
                iterDate = startViewDate = value.StartDate;
                dateDifference = value.EndDate - value.StartDate;
                isBackEnable = false;
                isNextEnable = true;
                endViewDate = startViewDate.AddDays(20);
                taskCollection = TaskManager.FetchTasksByVersionID(version.VersionID);
                viewTaskCollection = SetViewTaskCollection();
                InitializeTimeline();
            }
        }

        private bool isBackEnable, isNextEnable;
        private List<string> monthCollections;
        private List<Label> labelCollections;
        private TimeSpan dateDifference;
        private DateTime startViewDate, endViewDate, iterDate;
        private ProjectVersion version;

        private void TimelineControlPaint(object sender, PaintEventArgs e)
        {
            int width, x, y, stepWidth;
            width = tableLayoutPanel1.Width; x = 0; stepWidth = label1.Width; y = timelineControlPanel.Height;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            border.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            while(x < width)
            {
                e.Graphics.DrawLine(border, x, 0, x, y);
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
            }
        }

        private void OnPrevDayClick(object sender, EventArgs e)
        {
            if (isBackEnable)
            {
                startViewDate = iterDate = startViewDate.AddDays(-1);
                endViewDate = endViewDate.AddDays(-1);
                InitializeTimeline();
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

            if (backPictureBox.Image != null) { backPictureBox.Image.Dispose(); }
            if (nextPictureBox.Image != null) { nextPictureBox.Image.Dispose(); }

            backPictureBox.Image = isBackEnable ? UserInterface.Properties.Resources.Back : UserInterface.Properties.Resources.Back_Hover;
            nextPictureBox.Image = isNextEnable ? UserInterface.Properties.Resources.Next : UserInterface.Properties.Resources.Next_Hover;
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
            viewTaskCollection = new List<Task>();
            foreach(var Iter in taskCollection)
            {
                if((startViewDate <= Iter.EndDate && Iter.EndDate <= endViewDate) || (startViewDate <= Iter.StartDate && Iter.StartDate <= endViewDate) || (Iter.StartDate <= startViewDate && endViewDate <= Iter.EndDate))
                {
                    viewTaskCollection.Add(Iter);
                }
            }
        }
    }
}
