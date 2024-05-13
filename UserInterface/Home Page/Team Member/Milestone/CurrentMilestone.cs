using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class CurrentMilestone : UserControl
    {
        public string MilestoneName
        {
            get
            {
                return labelMilestonename.Text;
            }
            set
            {
                labelMilestonename.Text = value;
                InitializePageColor();
            }
        }

        public CurrentMilestone()
        {
            InitializeComponent();
            InitializePageColor();
            labelMilestonename.Location = new Point(65, panelBase.Height / 2-13);
        }

        private void InitializePageColor()
        {
            label1.BackColor = labelMilestonename.ForeColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            label1.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //labelMilestonename.Location = new Point(65, panelBase.Height / 2-13);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Point pt1 = new Point(9, 9);
            Point pt2 = new Point(Width - 11, 9);
            Point pt3 = new Point(Width - 11, Height - 11);
            Point pt4 = new Point(9, Height - 11);
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 3);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
            border.Dispose();
        }

        private void OnPaintBasePanel(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Point[] points =
            {
                new Point(20, 20),
                new Point( 50,panelBase.Height/2),
                new Point(20,panelBase.Height-20),
                new Point(panelBase.Width-50, panelBase.Height-20),
                new Point(panelBase.Width-10, panelBase.Height/2),
                new Point(panelBase.Width-50, 20)
            };
            Brush brush = new SolidBrush(ThemeManager.CurrentTheme.PrimaryI);
            e.Graphics.FillPolygon(brush, points);
            brush.Dispose();
        }
    }
}
