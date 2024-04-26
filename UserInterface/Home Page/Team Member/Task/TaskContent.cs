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

namespace TeamTracker
{
    public partial class TaskContent : UserControl
    {
        public TaskContent()
        {
            InitializeComponent();
            InitializeRoundedEdge();
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

        public void InitializePage()
        {
            if(VersionManager.CurrentVersion == null)
            {
                tableLayoutPanelBase.Visible = false;
            }
            else
            {
                List<int> result = TaskManager.FetchTaskCountByEmployee(VersionManager.CurrentVersion.VersionID);

                taskCountLabel.Text = result[0].ToString();
                completedTaskLabel.Text = result[1].ToString();
                dueTaskLabel.Text = result[2].ToString();
                incompleteTaskLabel.Text = result[3].ToString();
            }
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, 20, 20));
            panel11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel11.Width, panel11.Height, 20, 20));
        }

        private void BorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(221, 230, 237));
            e.Graphics.DrawLine(pen, new Point(tableLayoutPanel4.Width / 20, tableLayoutPanel4.Height / 2), new Point(tableLayoutPanel4.Width * 19 / 20, tableLayoutPanel4.Height / 2));
            System.Drawing.Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            e.Graphics.DrawPath(pen, BorderGraphicsPath.GetRoundRectangle(rec, 10));
            pen.Dispose();
        }

        
    }
}
