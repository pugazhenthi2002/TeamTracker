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

            Point[] p1 = { new Point(Width * 312 / 900  , Height * 327 / 900), new Point(Width * 328 / 900  , Height * 343 / 900), new Point(Width * 542 / 900 , Height * 343 / 900), new Point(Width * 559 / 900 , Height * 327 / 900) };
            Point[] p2 = { new Point(Width * 337 / 900 , Height * 352 / 900), new Point(Width * 355 / 900 , Height * 370 / 900), new Point(Width * 517 / 900  , Height * 369 / 900), new Point(Width * 534 / 900  , Height * 352 / 900) };
            Point[] p3 = { new Point(Width * 402 / 900, Height * 338 / 900 ), new Point(Width * 402 / 900, Height * 562 / 900 ), new Point(Width * 419 / 900, Height * 581 / 900 ), new Point(Width * 419 / 900, Height * 338 / 900 ) };
            Point[] p4 = { new Point(Width * 428 / 900, Height * 338 / 900 ), new Point(Width * 427 / 900, Height * 590 / 900 ), new Point(Width * 436 / 900, Height * 600 / 900 ), new Point(Width * 445 / 900, Height * 590 / 900 ), new Point(Width * 444 / 900, Height * 338 / 900 ) };
            Point[] p5 = { new Point(Width * 452 / 900, Height * 338 / 900 ), new Point(Width * 452 / 900, Height * 581 / 900 ), new Point(Width * 469 / 900, Height * 563 / 900 ), new Point(Width * 469 / 900, Height * 338 / 900 ) };

            
            g.FillPolygon(new SolidBrush(logoColor), p1);
            g.FillPolygon(new SolidBrush(logoColor), p2);
            g.FillPolygon(new SolidBrush(logoColor), p3);
            g.FillPolygon(new SolidBrush(logoColor), p4);
            g.FillPolygon(new SolidBrush(logoColor), p5);
            

        }
    }
}
