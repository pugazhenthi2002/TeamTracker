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
    public partial class LogoAnimation : UserControl
    {
        
        private List<Point[]> polygons = new List<Point[]>();
        private int interval = 1;
        private Color logoColor = Color.FromArgb(39, 55, 77);
        private Timer timer = new Timer();
        private int ind = 1;
        private int diff = 30;
        private bool start = false;

        public LogoAnimation()
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

        public bool Start
        {
            get { return start; }
            set
            {
                start = value;
                StartTimer();
            }
        }


        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(Math.Min(Width, Height), Math.Min(Width, Height));
        }

        private void StartTimer()
        {
            if(!start)
            {
                timer.Stop();
                return;
            }
            timer = new Timer();
            timer.Interval = interval;
            timer.Tick += OnTick;
            timer.Start();
        }

        

        private void OnPaint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            Graphics g = e.Graphics;

            Point[] p1 = { new Point(Width * 312 / 900 - diff, Height * 327 / 900), new Point(Width * 328 / 900 - diff, Height * 343 / 900), new Point(Width * 542 / 900 - diff, Height * 343 / 900), new Point(Width * 559 / 900 - diff, Height * 327 / 900) };
            Point[] p2 = { new Point(Width * 337 / 900 +diff -4, Height * 352 / 900), new Point(Width * 355 / 900 +diff-4, Height * 370 / 900), new Point(Width * 517 / 900 +diff-4, Height * 369 / 900), new Point(Width * 534 / 900 +diff-4, Height * 352 / 900) };
            Point[] p3 = { new Point(Width * 402 / 900, Height * 338 / 900 +diff), new Point(Width * 402 / 900, Height * 562 / 900 +diff), new Point(Width * 419 / 900, Height * 581 / 900 +diff), new Point(Width * 419 / 900, Height * 338 / 900 +diff) };
            Point[] p4 = { new Point(Width * 428 / 900, Height * 338 / 900 +diff), new Point(Width * 427 / 900, Height * 590 / 900 +diff), new Point(Width * 436 / 900, Height * 600 / 900 +diff), new Point(Width * 445 / 900, Height * 590 / 900 +diff), new Point(Width * 444 / 900, Height * 338 / 900 +diff) };
            Point[] p5 = { new Point(Width * 452 / 900, Height * 338 / 900 +diff), new Point(Width * 452 / 900, Height * 581 / 900 +diff), new Point(Width * 469 / 900, Height * 563 / 900 +diff), new Point(Width * 469 / 900, Height * 338 / 900 +diff) };

            

            if (ind == 1)
            {
                g.FillPolygon(new SolidBrush(logoColor), p1);
                if (diff == 2)
                {
                    polygons.Add(p1);
                }
            }

            if (ind == 2)
            {
                g.FillPolygon(new SolidBrush(logoColor), p2);
                if (diff == 2)
                {
                    polygons.Add(p2);
                }
            }
            if (ind == 3)
            {
                g.FillPolygon(new SolidBrush(logoColor), p3);
                if (diff == 2)
                {
                    polygons.Add(p3);
                }
            }
            if (ind == 4)
            {
                g.FillPolygon(new SolidBrush(logoColor), p4);
                if (diff == 2)
                {
                    polygons.Add(p4);
                }
            }
            if (ind == 5)
            {
                g.FillPolygon(new SolidBrush(logoColor), p5);
                if (diff == 2)
                {
                    polygons.Add(p5);
                }
            }

            foreach (Point[] p in polygons)
            {
                g.FillPolygon(new SolidBrush(logoColor), p);
            }

        }

        private void OnLoad(object sender, EventArgs e)
        {
           

        }

        private void OnTick(object sender, EventArgs e)
        {

            diff -= 2;
            Invalidate();

            if (diff <= 0)
            {
                diff = 30;
                ind++;
                
            }

            if (ind == 7 )
            {
                ind = 1;
                polygons.Clear();
            }

        }
    }
}
