using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.ViewProject.TimelineView.Controls
{
    public partial class TaskTimelineTemplate : UserControl
    {
        public Task TimelineTask
        {
            get
            {
                return timelineTask;
            }

            set
            {
                timelineTask = value;
                taskLabel.Text = value.TaskName;
            }
        }

        private Task timelineTask;
        public TaskTimelineTemplate()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Color.Gray,2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(pen, new Rectangle(-1,-1,Width, Height));
            pen.Dispose();
        }
    }
}
