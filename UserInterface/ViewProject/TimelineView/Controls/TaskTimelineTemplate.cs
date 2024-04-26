using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeamTracker;
using UserInterface;

namespace TeamTracker
{
    public partial class TaskTimelineTemplate : UserControl
    {
        private TransparentForm transparentForm;
        private bool isHovered = false;
        private Color timelineColor;
        private Task timelineTask;

        public TaskTimelineTemplate()
        {
            InitializeComponent();
        }

        public Color TimelineColor
        {
            get
            {
                return timelineColor;
            }

            set
            {
                timelineColor = value;
                taskLabel.ForeColor = value;
                Invalidate();
            }
        }

        public event EventHandler<Task> TaskSelect;

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

        private void OnClicked(object sender, EventArgs e)
        {
            TaskInfoForm form = new TaskInfoForm();
            form.SelectedTask = timelineTask;
            form.InfoFormClose += OnInforFormClosed;

            transparentForm = new TransparentForm();
            transparentForm.Show(ParentForm);
            transparentForm.ShowForm(form);
        }

        private void OnInforFormClosed(object sender, EventArgs e)
        {
            (sender as TaskInfoForm).Dispose();
            (sender as TaskInfoForm).Close();

            if (ParentForm != null)
                ParentForm.Show();
        }

        private void TaskTimelineTemplate_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border;
            if (isHovered)
                border = new Pen(TimelineColor, 4);
            else
                border = new Pen(TimelineColor, 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(5, 5, Width - 10, Height - 10), 10));
            border.Dispose();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            Cursor = Cursors.Hand;
            Invalidate();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            Cursor = Cursors.Default;
            Invalidate();
        }
    }
}
