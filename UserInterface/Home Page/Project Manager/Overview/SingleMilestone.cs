using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Home_Page.Project_Manager.Overview;

namespace TeamTracker
{
    public class SingleMilestone: Panel
    {
        public Milestone MilestoneContent
        {
            get
            {
                return milestone;
            }

            set
            {
                if (value != null)
                {
                    milestone = value;
                    name = value.MileStoneName;
                    this.Invalidate();
                }
            }
        }

        public Color MilestoneColor
        {
            get { return milestoneColor; }
            set
            {
                milestoneColor = value;
                this.Invalidate();
            }
        }

        public SingleMilestone()
        {
            DoubleBuffered = true;
            Width = Height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rec = new Rectangle(4, 4, Width - 9, Width - 9);
            Pen border = new Pen(MilestoneColor, 2);
            Brush brush = new SolidBrush(milestoneColor);
            Brush textBrush = new SolidBrush(Color.White);
            StringFormat SFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Font headerFont = new Font(new FontFamily("Ebrima"), 12, FontStyle.Bold);

            e.Graphics.DrawEllipse(border, new Rectangle(0, 0, Width - 1, Width - 1));
            e.Graphics.FillEllipse(brush, rec);
            e.Graphics.DrawString(name, headerFont, textBrush, rec, SFormat);
            border.Dispose();
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Width = Height;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            form = new MilestoneDetailsForm();
            form.Location = this.PointToScreen(new Point((Width - form.Width) / 2, -form.Height));
            form.TaskCounts = EmployeeManager.FetchTaskCountByMilestoneForEmployee(milestone.MileStoneID);
            form.EndDate = MilestoneManager.MilestoneLastCompletedTaskDate(milestone.MileStoneID);
            form.Show();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            form.Dispose();
            form.Close();
        }

        private string name;
        private MilestoneDetailsForm form;
        private Milestone milestone;
        private Color milestoneColor;
    }
}
