using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.ViewPage.ListView
{
    class CustomDonutChart:Panel
    {
        public CustomDonutChart()
        {
            Width = Height = Math.Min(Height, Width);
        }

        public bool IsValueAssigned = false;
        public Dictionary<Color, int> values;
        public Dictionary<Color, int> Values
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    values = value;
                    IsValueAssigned = true;
                    foreach(var Iter in values)
                    {
                        total += Iter.Value;
                    }


                    this.Invalidate();
                }
            }
        }

        private int total = 0, percentage, startAngle, sweepAngle;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (IsValueAssigned)
            {
                startAngle = 0;
                sweepAngle = 0;
                base.OnPaint(e);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Brush outerBrush = new SolidBrush(Color.FromArgb(221, 230, 237));
                Brush innerBrush;
                Rectangle outerRec = new Rectangle(0, 0, Width, Height);
                Rectangle innerRec = new Rectangle(Width / 10, Height / 10, Width * 8 / 10, Height * 8 / 10);
                e.Graphics.FillEllipse(outerBrush, outerRec);
                foreach (var Iter in values)
                {
                    innerBrush = new SolidBrush(Iter.Key);
                    percentage = Iter.Value * 100 / total;
                    sweepAngle = 360 * percentage / 100;

                    if (sweepAngle > 0)
                        e.Graphics.FillPie(innerBrush, innerRec, startAngle, sweepAngle);

                    startAngle = startAngle + sweepAngle;
                }
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Width = Height = Math.Min(Height, Width);
        }
    }
}
