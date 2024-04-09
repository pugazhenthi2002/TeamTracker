using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using TeamTracker;

namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class Overview : UserControl
    {

        private Dictionary<string, ProjectVersion> collection = new Dictionary<string, ProjectVersion>();
        private Color borderColor = Color.Blue;

        public Overview()
        {
            InitializeComponent();
        }

        public Dictionary<string, ProjectVersion> OverviewCollection
        {
            set
            {
                if (value != null)
                {
                    if (value.Count == 0) overviewMilestoneContent1.Visible = false;
                    else
                    {
                        collection = value;
                        projectNameLabel.Text = value.Last().Key;
                        overviewMilestoneContent1.Version = value.Last().Value;
                    }
                }
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Point pt1 = new Point(9, 9);
            Point pt2 = new Point(Width - 11, 9);
            Point pt3 = new Point(Width - 11, Height - 11);
            Point pt4 = new Point(9, Height - 11);
            Pen border = new Pen(borderColor, 3);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void OnOverviewClick(object sender, EventArgs e)
        {
            OverviewDropDownForm form = new OverviewDropDownForm();
            form.BackColor = Color.FromArgb(231, 240, 250);
            form.Location = panel7.PointToScreen(new Point(0, panel7.Height));
            form.Size = new Size(panel7.Width, 50);
            form.CurrentVersionCollection = collection;
            form.OverviewSelected += OnVersionSelected;
            form.Show();
        }

        private void OnVersionSelected(string name, ProjectVersion version)
        {
            overviewMilestoneContent1.Version = version;
            projectNameLabel.Text = name;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            projectNameLabel.BackColor = Color.FromArgb(39, 55, 77);
            projectNameLabel.ForeColor = Color.FromArgb(221, 230, 237);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            projectNameLabel.BackColor = Color.FromArgb(157, 178, 191);
            projectNameLabel.ForeColor = Color.Black;
        }

        private void OnVersionSwitchPanelPaint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, panel7.Width - 1, panel7.Height - 1));
            pen.Dispose();
        }

        private void OnDropDownMouseLEave(object sender, EventArgs e)
        {
            dropDownPicBox.BackColor = Color.FromArgb(231, 240, 250);
            panel7.Invalidate();
        }

        private void OnDropDownMouseEnter(object sender, EventArgs e)
        {
            dropDownPicBox.BackColor = Color.FromArgb(221, 230, 237);
            panel7.Invalidate();
        }
    }
}
