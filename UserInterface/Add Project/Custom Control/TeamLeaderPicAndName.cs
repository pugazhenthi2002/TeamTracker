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
    public partial class TeamLeaderPicAndName : UserControl
    {
        public delegate void EmployeeHandler(Employee employee);
        public event EmployeeHandler TeamLeaderClick;

        public Employee EmployeeProfile
        {
            get
            {
                return employee;
            }

            set
            {
                employee = value;
                if (value != null)
                {
                    teamLeaderName.Text = value.EmployeeFirstName + " " + value.EmployeeLastName;
                    try
                    {
                        profilePictureBox2.Image = Image.FromFile(value.EmpProfileLocation);
                    }
                    catch
                    {
                        ProjectManagerMainForm.notify.AddNotification("Error", "Couldn't able to load the Profile Image");
                    }
                }
            }
        }

        public TeamLeaderPicAndName()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            panel1.Paint -= OnRoundBorderPaint;
            teamLeaderName.Click -= OnProfileClicked;   teamLeaderName.MouseEnter -= OnMouseEnter;  teamLeaderName.MouseLeave -= OnMouseLeave;
            profilePictureBox2.Click -= OnProfileClicked; profilePictureBox2.MouseEnter -= OnMouseEnter; profilePictureBox2.MouseLeave -= OnMouseLeave;

            if (profilePictureBox2.Image != null)
                profilePictureBox2.Image.Dispose();
        }

        private void InitializePageColor()
        {
            panel1.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            teamLeaderName.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, panel1.Height, panel1.Height));
        }

        private void OnProfileClicked(object sender, EventArgs e)
        {
            TeamLeaderClick?.Invoke(employee);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = ThemeManager.GetHoverColor(panel1.BackColor);
            teamLeaderName.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);
            profilePictureBox2.ParentColor = panel1.BackColor;
            panel1.Invalidate();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            teamLeaderName.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);
            profilePictureBox2.ParentColor = panel1.BackColor;
            panel1.Invalidate();
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

        private void OnRoundBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1), panel1.Height/2));
            border.Dispose();
        }

        private Employee employee;
    }
}
