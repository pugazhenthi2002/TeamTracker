using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using UserInterface.Task.CreateTask;
using UserInterface.Task.Timeline;
using UserInterface.ViewPage;

namespace TeamTracker
{
    public enum TimelineDisplayMode
    {
        LeftPartial,
        RightPartial,
        Full,
        Outer
    }

    public partial class TimelineTask : UserControl
    {
        public delegate bool TimelineDateHandler(TimelineTask control);
        public event TimelineDateHandler TaskTimelineCheck;

        public delegate void TimelineHandler(TimelineTask control, Task selectedTask, int direction);
        public event TimelineHandler TimeLineMovement;
        public event TimelineHandler TaskDateChange;

        public int StepWidth = 20;
        private Color statusColor;
        public Color StatusColor
        {
            get
            {
                return statusColor;
            }

            set
            {
                statusColor = value;
                label1.Invalidate();
            }
        }

        private Task selectedTask;
        public Task SelectedTask
        {
            get { return selectedTask; }
            set
            {
                if (value != null)
                {
                    selectedTask = value;
                    label1.Text = selectedTask.TaskName;
                }
            }
        }

        private bool isRightEdged, isLeftEdged, isDragLeftEdged, isDragRightEdged;
        private bool isHovered, isDragging;
        private bool isRightSliderClicked, isLeftSliderClicked;
        private bool? isEndDateReached, isStartDateReached;

        public TimelineDisplayMode DisplayMode { get; set; }

        public TimelineTask()
        {
            InitializeComponent();
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, label1, new object[] { true });
            DoubleBuffered = true;
            Height = 30;
        }

        private void SliderPanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(StatusColor, 2);

            if (isHovered)
            {
                Point pt1, pt2, pt3, pt4;
                Rectangle rec1 = new Rectangle(0, 0, 15, Height);
                int width = rec1.Width, height = rec1.Height;

                if (!(DisplayMode == TimelineDisplayMode.LeftPartial || DisplayMode == TimelineDisplayMode.Outer))
                {
                    pt1 = new Point(width * 2 / 7 + 5, height * 3 / 10); pt2 = new Point(width * 2 / 7 + 5, height * 7 / 10);
                    pt3 = new Point(width * 5 / 7 + 5, height * 3 / 10); pt4 = new Point(width * 5 / 7 + 5, height * 7 / 10);

                    e.Graphics.DrawLine(border, pt1, pt2);
                    e.Graphics.DrawLine(border, pt3, pt4);
                }

                Rectangle rec2 = new Rectangle(Width - 15, 0, 15, Height);
                width = rec2.Width; height = rec2.Height;

                if (!(DisplayMode == TimelineDisplayMode.RightPartial || DisplayMode == TimelineDisplayMode.Outer))
                {
                    pt1 = new Point(rec2.X + width * 2 / 7 - 5, height * 3 / 10); pt2 = new Point(rec2.X + width * 2 / 7 - 5, height * 7 / 10);
                    pt3 = new Point(rec2.X + width * 5 / 7 - 5, height * 3 / 10); pt4 = new Point(rec2.X + width * 5 / 7 - 5, height * 7 / 10);

                    e.Graphics.DrawLine(border, pt1, pt2);
                    e.Graphics.DrawLine(border, pt3, pt4);
                }
                border.Width = 3;

            }
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(5,5,Width-10, Height-10), 10));
            border.Dispose();
        }

        private void OnTimelineTaskMouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            Point pt = (e as MouseEventArgs).Location;
            if(0<=pt.X && pt.X <= 15 && DisplayMode == TimelineDisplayMode.LeftPartial)
            {
                Cursor = Cursors.SizeWE;
            }
            else if(Width - 15 <= pt.X && pt.X <= Width && DisplayMode == TimelineDisplayMode.RightPartial)
            {
                Cursor = Cursors.SizeWE;
            }
            else
            {
                Cursor = Cursors.Hand;
            }
            label1.Invalidate();
        }

        private void OnTimelineTaskMouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            Cursor = Cursors.Default;
            label1.Invalidate();
        }

        private void OnResize(object sender, EventArgs e)
        {
            leftRec = new Rectangle(0, 0, 15, Height);
            rightRec = new Rectangle(Width - 15, 0, 15, Height);
        }

        private int rightOffSetX, leftOffSetX;

        private void OnTaskMouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                TaskOperationForm form = new TaskOperationForm();
                form.Location = PointToScreen(new Point(Width, 0));
                form.Operate += OnTaskOperation;
                form.Show();
            }
        }

        private void OnTaskOperation(object sender, OperateType e)
        {
            if(e == OperateType.Update)
            {
                CreateTaskForm form1 = new CreateTaskForm();
                form1.SelectedTask = selectedTask;
                form1.Show();
            }
            else
            {
                WarningForm form2 = new WarningForm();
                form2.Content = "Are you sure, you want delete the task?";
                form2.WarningStatus += OnWarningStatus;
                form2.Show();
            }
        }

        private void OnWarningStatus(object sender, bool e)
        {
            if(e)
            {
                TaskManager.DeleteTask(selectedTask.TaskID);
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            var x = selectedTask;
            if (e.X >= rightRec.X && e.X <= Width && (DisplayMode != TimelineDisplayMode.RightPartial && DisplayMode != TimelineDisplayMode.Outer))
            {
                isRightSliderClicked = true;
                rightOffSetX = Width - e.X;
            }
            else if (e.X >= 0 && e.X <= 15 && (DisplayMode != TimelineDisplayMode.LeftPartial && DisplayMode != TimelineDisplayMode.Outer))
            {
                isLeftSliderClicked = true;
                leftOffSetX = e.X;
            }
            else
            {
                isDragging = true;
                offSet = e.Location;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (isDragLeftEdged || isDragRightEdged || isLeftEdged || isRightEdged)
                edgeTimer.Stop();

            TaskDateChange?.Invoke(this, selectedTask, 0);

            var x = Location;
            isRightSliderClicked = false;
            isLeftSliderClicked = false;
            isDragging = false;
        }

        private void OnEdgeTick(object sender, EventArgs e)
        {
            if(isRightEdged)
            {
                if (!Convert.ToBoolean(isEndDateReached))
                {
                    Location = new Point(Location.X - StepWidth, Location.Y);
                    Width = Width + StepWidth;
                    TimeLineMovement?.Invoke(this, selectedTask, 1);
                }
            }

            if (isLeftEdged)
            {
                if (!Convert.ToBoolean(isStartDateReached))
                {
                    Width = Width + StepWidth;
                    TimeLineMovement?.Invoke(this, selectedTask, -1);
                }
            }

            if(isDragLeftEdged)
            {
                if (!Convert.ToBoolean(isStartDateReached))
                {
                    TimeLineMovement?.Invoke(this, selectedTask, -1);
                }
            }

            if (isDragRightEdged)
            {
                if (!Convert.ToBoolean(isEndDateReached))
                {
                    TimeLineMovement?.Invoke(this, selectedTask, 1);
                }
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            this.SuspendLayout();
            if (isRightSliderClicked)
            {
                isEndDateReached = TaskTimelineCheck?.Invoke(this);
                if ((Location.X + e.X + rightOffSetX) >= Parent.Width)
                {
                    isRightEdged = true;
                    edgeTimer.Start();
                }
                else
                {
                    if(isRightEdged)
                    {
                        isRightEdged = false;   edgeTimer.Stop();
                    }

                    if (e.X + rightOffSetX > StepWidth)
                        Width = e.X + rightOffSetX;
                }
            }

            if (isLeftSliderClicked)
            {
                isStartDateReached = TaskTimelineCheck?.Invoke(this);
                if (Location.X - (leftOffSetX - e.X) <= 0)
                {

                    isLeftEdged = true;
                    edgeTimer.Start();
                }
                else
                {
                    if (isLeftEdged)
                    {
                        isLeftEdged = false; edgeTimer.Stop();
                    }
                    if (Width + (leftOffSetX - e.X) > StepWidth)
                    {
                        Width = Width + (leftOffSetX - e.X);
                        Location = new Point(Location.X - (leftOffSetX - e.X), Location.Y);
                    }
                }
            }

            if (isDragging)
            {
                isStartDateReached = TaskTimelineCheck?.Invoke(this);
                isEndDateReached = TaskTimelineCheck?.Invoke(this);
                if (Location.X + (e.X - offSet.X) <= 0)
                {
                    isDragLeftEdged = true;
                    edgeTimer.Start();
                }
                else if (Location.X + (e.X - offSet.X) + Width >= Parent.Width)
                {
                    isDragRightEdged = true;
                    edgeTimer.Start();
                }
                else
                {
                    if (isDragRightEdged)
                        edgeTimer.Stop();
                    if (isDragLeftEdged)
                        edgeTimer.Stop();

                    Location = new Point(Location.X + (e.X - offSet.X), Location.Y + (e.Y - offSet.Y));
                }
            }

            this.ResumeLayout();
        }

        private Point offSet;
        private Rectangle leftRec, rightRec;
    }
}
