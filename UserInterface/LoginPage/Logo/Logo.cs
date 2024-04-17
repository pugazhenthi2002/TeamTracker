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
    public partial class Logo : UserControl
    {
        private Color logoColor = Color.FromArgb(39, 55, 77);

        public Logo()
        {
            InitializeComponent();
        }

        public Color LogoColor
        {
            get { return logoColor; }
            set
            {
                logoColor = value;
                this.Invalidate();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(Math.Min(Width, Height), Math.Min(Width, Height));
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            Graphics g = e.Graphics;

            Point[] p1 = { new Point(Width * 25 / 300, Height * 20 / 300), new Point(Width * 42 / 300, Height * 38 / 300), new Point(Width * 257 / 300, Height * 38 / 300), new Point(Width * 274 / 300, Height * 20 / 300) };
            Point[] p2 = { new Point(Width * 50 / 300, Height * 45 / 300), new Point(Width * 67 / 300, Height * 65 / 300), new Point(Width * 231 / 300, Height * 65 / 300), new Point(Width * 249 / 300, Height * 45 / 300) };
            Point[] p3 = { new Point(Width * 114 / 300, Height * 35 / 300), new Point(Width * 114 / 300, Height * 257 / 300), new Point(Width * 133 / 300, Height * 276 / 300), new Point(Width * 133 / 300, Height * 35 / 300) };
            Point[] p4 = { new Point(Width * 140 / 300, Height * 35 / 300), new Point(Width * 140 / 300, Height * 283 / 300), new Point(Width * 149 / 300, Height * 293 / 300), new Point(Width * 158 / 300, Height * 283 / 300), new Point(Width * 158 / 300, Height * 35 / 300) };
            Point[] p5 = { new Point(Width * 165 / 300, Height * 35 / 300), new Point(Width * 165 / 300, Height * 277 / 300), new Point(Width * 184 / 300, Height * 259 / 300), new Point(Width * 184 / 300, Height * 35 / 300) };


            g.FillPolygon(new SolidBrush(logoColor), p1);
            g.FillPolygon(new SolidBrush(logoColor), p2);
            g.FillPolygon(new SolidBrush(logoColor), p3);
            g.FillPolygon(new SolidBrush(logoColor), p4);
            g.FillPolygon(new SolidBrush(logoColor), p5);


        }
    }
}
