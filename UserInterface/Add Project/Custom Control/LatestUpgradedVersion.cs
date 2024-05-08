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
    public partial class LatestUpgradedVersion : UserControl
    {
        public ProjectVersion LatestVersion
        {
            set
            {
                if (value != null)
                {
                    tableLayoutPanel1.Visible = true;
                    versionName.Text = value.VersionName;
                    startDateLabel.Text = value.StartDate.ToShortDateString();
                    endDateLabel.Text = value.EndDate.ToShortDateString();
                    descTextBox.Text = value.VersionDescription;
                }
                else
                {
                    tableLayoutPanel1.Visible = false;
                }
            }
        }
        public LatestUpgradedVersion()
        {
            InitializeComponent();
            InitializeBorders();
            InitializePageColor();
        }

        public new void Dispose()
        {
            label1.Dispose();   label2.Dispose();   label3.Dispose();   label6.Dispose(); label7.Dispose();
            panel1.Dispose(); panel2.Dispose() ; panel3.Dispose(); panel4.Dispose();    panel7.Dispose();   panel8.Dispose();
            tableLayoutPanel1.Dispose();    tableLayoutPanel3.Dispose();
            startDateLabel.Dispose(); endDateLabel.Dispose(); descTextBox.Dispose(); versionName.Dispose();
        }

        private void InitializePageColor()
        {
            label6.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label6.ForeColor = ThemeManager.GetTextColor(label6.BackColor);
            panel2.BackColor = panel3.BackColor = panel4.BackColor = panel7.BackColor = descTextBox.BackColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryII);
            label1.ForeColor = label2.ForeColor = label3.ForeColor = startDateLabel.ForeColor = endDateLabel.ForeColor = versionName.ForeColor = label7.ForeColor = ThemeManager.GetTextColor(panel2.BackColor);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorders();
        }
        
        private void InitializeBorders()
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
        }

        private void BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1);
            Pen border1 = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 10));

            border1.Dispose();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI);
            e.Graphics.DrawLine(border, new Point(0, (sender as Control).Height -2), new Point((sender as Control).Width, (sender as Control).Height - 2));
            border.Dispose();
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
    }
}
