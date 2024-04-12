using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace TeamTracker
{
    public class ProfilePictureBox:PictureBox
    {
        private Color parentColor;
        public Color ParentColor
        {
            get { return parentColor; }
            set
            {
                parentColor = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                Region = new Region(gp);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(parentColor), 1), 0, 0, this.Width - 1, this.Height - 1);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Width = Height;
        }
        protected override void OnLoadCompleted(AsyncCompletedEventArgs e)
        {
            base.OnLoadCompleted(e);
            parentColor = Parent.BackColor;
        }
    }
}
