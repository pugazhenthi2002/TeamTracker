using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Home_Page.Team_Member
{
    public partial class TeamMemberReport : UserControl
    {
        public TeamMemberReport()
        {
            InitializeComponent();
        }

        private Color borderColor = Color.Blue;

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


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public void InitializeReport()
        {
            teamMemberReportContent1.isOpened = true;
            teamMemberReportContent1.Month = DateTime.Today.Month; teamMemberReportContent1.Year = DateTime.Today.Year; teamMemberReportContent1.Priority = -1;
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            label1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = ThemeManager.GetTextColor(label1.BackColor);
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            teamMemberReportContent1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
        }
    }
}
