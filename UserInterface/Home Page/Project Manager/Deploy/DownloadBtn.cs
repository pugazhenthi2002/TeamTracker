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
    public class DownloadBtn : UserControl
    {
        
        public DownloadBtn()
        {
            this.Size = new Size(250, 50);
            this.DoubleBuffered = true;
        }

        Timer timer;
        private int changeX = 5;
        private int changeY = 5;
        private bool clicked = false;
        private bool downloaded = false;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);

            Graphics g = pevent.Graphics;
            GraphicsPath gPath = new GraphicsPath();
            g.Clear(this.Parent.BackColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;


            Rectangle left = new Rectangle(0, 0, this.Height, this.Height);
            Rectangle right = new Rectangle(this.Width - this.Height, 0, this.Height, this.Height);
            


            gPath.AddArc(right, 270, 180);
            gPath.AddArc(left, 90, 180);

            g.FillPath(new SolidBrush(Color.FromArgb(157, 178, 191)), gPath);

            string btnText = "Download Zip ";
            

            Size textSize = TextRenderer.MeasureText(btnText, new Font("Ebrima",10));

            int x = (this.Width - textSize.Width) / 2;
            int y = (this.Height - textSize.Height) / 2;

            //TextRenderer.DrawText(pevent.Graphics, btnText, new Font("Ebrima", 10), new Point(x, y), this.ForeColor);

            if (downloaded)
            {
                g.DrawString("Download again", new Font("Ebrima", 10,FontStyle.Bold), new SolidBrush(this.ForeColor), new Point(x, y));

            }
            else
            {
                g.DrawString(btnText, new Font("Ebrima", 10,FontStyle.Bold), new SolidBrush(this.ForeColor), new Point(x, y));
                
            }

            if (timer == null || !timer.Enabled)
            {
                timer = new Timer();
                timer.Interval = 10;
                timer.Tick += OnTick;


            }

            if (clicked)
            {
                timer.Start();
                downloaded = false;
                Color sh = Color.FromArgb(50, Color.Black);
                Rectangle fillReg = new Rectangle(0, 0, changeX, this.Height);

                Region r = new Region(gPath);
                r.Intersect(fillReg);
                g.FillRegion(new SolidBrush(sh), r);

            }


        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            clicked = true;
            changeX = 5;
            changeY = 5;
            Invalidate();



        }

        private void OnTick(object sender, EventArgs e)
        {
            if (changeX >= this.Width)
            {
                downloaded = true;
                Invalidate();
                timer.Stop();
                clicked = false;
                
                return;
            }

            changeX += 10;
            changeY += 10;
            Invalidate();


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DownloadBtn
            // 
            this.Name = "DownloadBtn";
            this.Size = new System.Drawing.Size(254, 50);
            this.ResumeLayout(false);

        }
    }
}
