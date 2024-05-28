using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Project_Manager_Main_Page
{
    class ToggleButton:Panel
    {
        private bool condition = false;
        private int initial = 0;
        private int borderRadius = 1;
        private int prevThumpX = 2;
        private Timer transitionTimer;
        private int Diameter;
        private Color BorderColorForOn = Color.DarkGreen;
        private Color BorderColorForOff = Color.DarkRed;
        private Color SkinColorForOn = Color.MediumSeaGreen;
        private Color SkinColorForOff = Color.IndianRed;


        public bool Checked
        {
            get { return condition; }
            set
            {
                condition = value;

                if (condition) this.prevThumpX = (Width - Height) + BorderRadius1;
                else this.prevThumpX = 1 + BorderRadius1;

                Diameter = Height - 1 - (2 * BorderRadius1);

                Invalidate();
            }

            //
            //transitionTimer.Start(); }
        }

        public int BorderRadius1
        {

            get { return borderRadius; }
            set
            {
                borderRadius = value; Diameter = 2 * (Height / 2 - 1 - (BorderRadius1));
                if (condition) this.prevThumpX = (Width - Height) + BorderRadius1;
                else this.prevThumpX = 1 + BorderRadius1;
                Invalidate();
            }
        }

        public Color BorderColorForOn1 { get => BorderColorForOn; set { BorderColorForOn = value; Invalidate(); } }
        public Color BorderColorForOff1 { get => BorderColorForOff; set { BorderColorForOff = value; Invalidate(); } }

        public Color SkinColorForOn1 { get => SkinColorForOn; set { SkinColorForOn = value; Invalidate(); } }
        public Color SkinColorForOff1 { get => SkinColorForOff; set { SkinColorForOff = value; Invalidate(); } }

        public ToggleButton()
        {

            //this.FlatStyle = FlatStyle.Flat;
            //this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
            //this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            DoubleBuffered = true;
        }

        private void InitializeTimer()
        {
            transitionTimer = new Timer();
            transitionTimer.Interval = 10; // Adjust the interval for smoother transition
            transitionTimer.Tick += TransitionTimer_Tick;
        }

        private double Variant = 0;


        private void TransitionTimer_Tick(object sender, EventArgs e)
        {
            int step = (Width - (Height - 1)) / 20; // Adjust the step for smoother transition
            if (condition && prevThumpX < Width - (Height - 1) + BorderRadius1 - step)
            {
                prevThumpX += step;
            }
            else if (condition && prevThumpX >= Width - (Height - 1) + BorderRadius1 - step)
            {
                prevThumpX = (Width - (Height - 1)) + BorderRadius1;
                transitionTimer.Stop();
            }
            else if (!condition && prevThumpX > (1 + BorderRadius1 + step))
            {
                prevThumpX -= step;
            }
            else if (!condition || prevThumpX < 1 + (BorderRadius1))
            {
                prevThumpX = 1 + BorderRadius1;
                transitionTimer.Stop();
            }
            else
            {
                transitionTimer.Stop();
                transitionTimer = null;

            }

            Invalidate();
        }


        private Rectangle OuterRec;
        private Rectangle InnerRec;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (initial == 0)
            {
                if (condition) this.prevThumpX = (Width - Height) + BorderRadius1 - 1;
                else this.prevThumpX = 1 + BorderRadius1;
            }


            OuterRec = ClientRectangle;
            InnerRec = Rectangle.Inflate(OuterRec, -BorderRadius1, -BorderRadius1);
            GraphicsPath Outer = GetGraphicsPath(0);
            GraphicsPath Inner = GetGraphicsPath(1);



            if (condition)
            {

                using (Brush brushInner = new SolidBrush(SkinColorForOn1))
                {
                    using (Brush brushOuter = new SolidBrush(BorderColorForOn1))
                    {
                        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        pevent.Graphics.FillPath(brushOuter, Outer);
                        pevent.Graphics.FillPath(brushInner, Inner);
                        //   pevent.Graphics.DrawPath(pen, path);
                    }
                }
            }
            else
            {
                using (Brush brushInner = new SolidBrush(SkinColorForOff1))
                {
                    using (Brush brushOuter = new SolidBrush(BorderColorForOff1))
                    {
                        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        pevent.Graphics.FillPath(brushOuter, Outer);
                        pevent.Graphics.FillPath(brushInner, Inner);
                        // pevent.Graphics.DrawPath(pen, path);
                    }
                }
            }



            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.FillEllipse(Brushes.White, prevThumpX, BorderRadius1 + 1, Diameter, Diameter);
            //pevent.Graphics.FillEllipse(Brushes.White, prevThumpX, (Height / 20), Height - (Height / 10), Height - (Height / 10));
            initial = 1;

        }
        public EventHandler<bool> ToggleClicked;
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            //    initial = 1;
            if (condition) condition = false;
            else condition = true;

            ToggleClicked?.Invoke(this, condition);
            // Uncomment the following line if you want to handle the button click event
            // ToggleClicked?.Invoke(this, condition);
            InitializeTimer();
            transitionTimer.Start();
            // Math1();
            this.Invalidate();
        }

        private GraphicsPath GetGraphicsPath(int r)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            if (r == 1)
            {
                path.AddArc(BorderRadius1, BorderRadius1, OuterRec.Height - 2 * BorderRadius1, OuterRec.Height - 2 * BorderRadius1, 90, 180);
                path.AddArc(Width - Height + BorderRadius1 - 1,
                    BorderRadius1, InnerRec.Height, InnerRec.Height, 270, 180);


            }
            else
            {

                path.AddArc(0, 0, Height, Height, 90, 180);
                path.AddArc(Width - Height - 1, 0, Height, Height, 270, 180);
            }
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (Width < Height + 60 + BorderRadius1) Width = Height + 60 + BorderRadius1;
            if (Height < 20 + BorderRadius1) Height = 20 + BorderRadius1;
            if (prevThumpX < 5) prevThumpX = 5;
            if (BorderRadius1 > InnerRec.Height) InnerRec.Height = 10;
            if (Checked) prevThumpX = Width - Height - 1;
            else prevThumpX = 1 + BorderRadius1;
            Diameter = Height - 1 - (2 * BorderRadius1);
        }

    }
}
