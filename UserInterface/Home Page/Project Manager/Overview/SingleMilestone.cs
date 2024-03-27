using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public class SingleMilestone: Panel
    {
        public string MilestoneContent
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
                this.Invalidate();
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
            e.Graphics.DrawString(content, headerFont, textBrush, rec, SFormat);
            border.Dispose();
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Width = Height;
        }

        private string content;
        private Color milestoneColor;
    }
}
