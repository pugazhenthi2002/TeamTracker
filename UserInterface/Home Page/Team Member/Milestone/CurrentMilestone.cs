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

        private string milestoneName;

        public CurrentMilestone()
        {
            InitializeComponent();
            labelMilestonename.Location = new Point(65, panelBase.Height / 2-13);
        }

        public string MilestoneName
        {
            get
            {
                return milestoneName;
            }
            set
            {
                milestoneName = value;
                SetMilestoneName();
            }
        }

        

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            labelMilestonename.Location = new Point(65, panelBase.Height / 2-13);

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Point pt1 = new Point(9, 9);
            Point pt2 = new Point(Width - 11, 9);
            Point pt3 = new Point(Width - 11, Height - 11);
            Point pt4 = new Point(9, Height - 11);
            Pen border = new Pen(Color.Black, 3);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void SetMilestoneName()
        {
            labelMilestonename.Text = milestoneName;
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

            e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(39, 55, 77)), points);
        }
    }
}
