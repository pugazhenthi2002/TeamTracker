using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public enum PathStyle
    {
        Start,
        Middle,
        End
    }
    public class StartPathAndDate: Panel
    {


        private PathStyle style;
        private Color milestoneColor;
        private DateTime milestoneDate;

        public DateTime MilestoneDate
        {
            get { return milestoneDate; }

            set
            {
                milestoneDate = value;
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

        public PathStyle SytleOfPath
        {
            get
            {
                return style;
            }

            set
            {
                style = value;
                this.Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rec = new Rectangle(0, 0, Width, Height * 45 / 100);
            Brush brush = new SolidBrush(MilestoneColor);
            Brush textBrush = new SolidBrush(Color.Black);
            GraphicsPath path = new GraphicsPath();
            StringFormat SFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Far
            };
            Font headerFont = new Font(new FontFamily("Ebrima"), 12, FontStyle.Bold);

            path.StartFigure();
            if (SytleOfPath == PathStyle.Start)
            {
                path.AddArc(new Rectangle(0, Height * 45 / 100, Height / 10, Height / 10), 90, 180);
                path.AddLine(new Point(Width, Height * 45 / 100), new Point(Width, Height * 55 / 100));
            }
            else if (SytleOfPath == PathStyle.End)
            {
                path.AddArc(new Rectangle(Width * 9 / 10, Height * 45 / 100, Height / 10, Height / 10), 270, 180);
                path.AddLine(new Point(0, Height * 55 / 100), new Point(0, Height * 45 / 100));
            }
            else
            {
                path.AddRectangle(new Rectangle(0, Height * 45 / 100, Width, Height / 10));
                path.CloseAllFigures();
            }

            e.Graphics.FillPath(brush, path);
            e.Graphics.DrawString(milestoneDate.ToShortDateString(), headerFont, textBrush, rec, SFormat);
        }

    }
}
