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
        public Dictionary<string, ProjectVersion> OverviewCollection
        {
            set
            {
                InitializePageColor();
                if (value != null && value.Count > 0)
                {
                    panel5.Visible = true;
                    collection = value;
                    projectNameLabel.Text = value.Last().Key;
                    overviewMilestoneContent1.Version = value.Last().Value;
                }
                else
                {
                    panel5.Visible = false;
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
        public Overview()
        {
            InitializeComponent();
        }

        public new void Dispose()
        {
            if(dropDownPicBox.Image != null) { dropDownPicBox.Image.Dispose(); }

            label1.Dispose();   label2.Dispose();
            dropDownPicBox.Dispose(); projectNameLabel.Dispose();
            panel1.Dispose(); panel2.Dispose(); panel3.Dispose();   panel4.Dispose();   panel5.Dispose();   panel6.Dispose();   panel7.Dispose();
            overviewMilestoneContent1.Dispose();    ucNotFound1.Dispose();
        }

        private void InitializePageColor()
        {
            label1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = ThemeManager.GetTextColor(label1.BackColor);
            BackColor = panel6.BackColor = overviewMilestoneContent1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            label2.ForeColor = ThemeManager.GetTextColor(BackColor);
            panel7.BackColor = ThemeManager.CurrentTheme.PrimaryII;
            projectNameLabel.ForeColor = ThemeManager.GetTextColor(panel7.BackColor);
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
            form.BackColor = ThemeManager.CurrentTheme.PrimaryIII;
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
        
        private void OnVersionSwitchPanelPaint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, panel7.Width - 1, panel7.Height - 1));
            e.Graphics.DrawLine(pen, new Point(dropDownPicBox.Location.X, 0), new Point(dropDownPicBox.Location.X, panel7.Height - 1));
            pen.Dispose();
        }

        private void OnDropDownMouseLEave(object sender, EventArgs e)
        {
            if (dropDownPicBox.Image != null)
                dropDownPicBox.Image.Dispose();

            dropDownPicBox.Image = Properties.Resources.Down_Dark_Blue;
            panel7.Invalidate();
        }

        private void OnDropDownMouseEnter(object sender, EventArgs e)
        {
            if (dropDownPicBox.Image != null)
                dropDownPicBox.Image.Dispose();

            dropDownPicBox.Image = Properties.Resources.Down_Dark_Blue_Hover;
            panel7.Invalidate();
        }

        private Dictionary<string, ProjectVersion> collection = new Dictionary<string, ProjectVersion>();
        private Color borderColor = Color.Blue;
    }
}
