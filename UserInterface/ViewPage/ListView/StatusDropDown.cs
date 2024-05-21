using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class StatusDropDown : Form
    {
        private Point endLocation;


        public StatusDropDown()
        {
            InitializeComponent();
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label1.BackColor = ThemeManager.GetTaskStatusColor(TaskStatus.UnderReview);
            label2.BackColor = ThemeManager.GetTaskStatusColor(TaskStatus.OnProcess);
            label3.BackColor = ThemeManager.GetTaskStatusColor(TaskStatus.Stuck);
            label4.BackColor = ThemeManager.GetTaskStatusColor(TaskStatus.NotYetStarted);
        }


        public event EventHandler<string> StatusChanged;

        private void StatusFormLoad(object sender, EventArgs e)
        {
            BackColor = Color.Magenta;
            TransparencyKey = Color.Magenta;

            endLocation = Location;
            Location = new Point(endLocation.X, endLocation.Y - 20);
            formLoadTimer.Start();
        }

        private void StatusDropDownPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            Brush b = new SolidBrush(ThemeManager.CurrentTheme.PrimaryI);
            Rectangle rectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            FillRoundRectangle(e.Graphics, rectangle, b, 5);
            b.Dispose();
        }

        private static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
        {
            int l = 2 * r;
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);

            gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);

            gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);

            gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);

            return gp;
        }

        private void FillRoundRectangle(Graphics g, Rectangle rectangle, Brush b, int r)
        {
            rectangle = new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            g.FillPath(b, GetRoundRectangle(rectangle, r));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StatusChanged?.Invoke(this, (sender as Label).Text);
            this.Close();
        }

        private void OnFormOpenTick(object sender, EventArgs e)
        {
            Location = new Point(Location.X, Location.Y + 1);
            if (this.Location.Y >= endLocation.Y)
            {
                formLoadTimer.Stop();
            }
        }


        private void OnStatusMouseEnter(object sender, EventArgs e)
        {
            Color color = (sender as Label).BackColor;
            int R, G, B;
            R = color.R - 20 >= 0 ? color.R - 20 : 0;
            G = color.G - 20 >= 0 ? color.G - 20 : 0;
            B = color.B - 20 >= 0 ? color.B - 20 : 0;

            (sender as Label).BackColor = Color.FromArgb(R, G, B);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Color color = (sender as Label).BackColor;
            int R, G, B;
            R = color.R + 20 >= 0 ? color.R + 20 : 0;
            G = color.G + 20 >= 0 ? color.G + 20 : 0;
            B = color.B + 20 >= 0 ? color.B + 20 : 0;

            (sender as Label).BackColor = Color.FromArgb(R, G, B);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }
    }
}
