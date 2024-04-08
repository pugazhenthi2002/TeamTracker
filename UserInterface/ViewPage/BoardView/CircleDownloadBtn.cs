using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UserInterface.ViewPage.BoardView
{
    public partial class CircleDownloadBtn : UserControl
    {
        public CircleDownloadBtn()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
            this.Size = new Size(Math.Min(this.Height, this.Width), Math.Min(this.Height, this.Width));
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rec = new Rectangle(0, 0, this.Width - 2, this.Height - 2);


            // Draw circle
            g.DrawEllipse(new Pen(Color.FromArgb(150, 170, 190), 7), rec);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, this.Width, this.Height));

        }
        
    }
}
