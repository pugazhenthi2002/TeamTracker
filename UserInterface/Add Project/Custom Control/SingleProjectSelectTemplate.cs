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
using UserInterface.Home_Page.Project_Manager;
using System.Runtime.InteropServices;

namespace UserInterface.Add_Project.Custom_Control
{
    public partial class SingleProjectSelectTemplate : UserControl
    {
        public event EventHandler<Projects> ProjectClick;

        public Projects Project
        {
            get { return project; }
            set
            {
                if (value != null)
                {
                    project = value;
                    InitializeTemplate();
                }
            }
        }

        public bool IsClicked
        {
            get { return isClicked; }
            set
            {
                isClicked = value;
                if (value)
                {
                    BackColor = ThemeManager.CurrentTheme.PrimaryI;
                    projectLabel.ForeColor = versionLabel.ForeColor = teamLeadLabel.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.PrimaryI);
                }
                else
                {
                    BackColor = ThemeManager.CurrentTheme.SecondaryII;
                    projectLabel.ForeColor = versionLabel.ForeColor = teamLeadLabel.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.SecondaryIII);
                }
                profilePictureBox1.ParentColor = BackColor;
                this.Invalidate();
            }
        }


        public SingleProjectSelectTemplate()
        {
            DoubleBuffered = true;
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        public new void Dispose()
        {
            if(profilePictureBox1.Image != null)
            {
                profilePictureBox1.Image.Dispose();
            }

            ThemeManager.ThemeChange -= OnThemeChanged;
            profilePictureBox1.Click -= OnClicked;  versionLabel.Click -= OnClicked;    teamLeadLabel.Click -= OnClicked;   projectLabel.Click -= OnClicked;    tableLayoutPanel1.Click -= OnClicked;
            profilePictureBox1.MouseEnter -= OnMouseEnter;  versionLabel.MouseEnter -= OnMouseEnter;    teamLeadLabel.MouseEnter -= OnMouseEnter;   projectLabel.MouseEnter -= OnMouseEnter;    tableLayoutPanel1.MouseEnter -= OnMouseEnter;
            profilePictureBox1.MouseLeave -= OnMouseLeave;  versionLabel.MouseLeave -= OnMouseLeave;    teamLeadLabel.MouseLeave -= OnMouseLeave;   projectLabel.MouseLeave -= OnMouseLeave;    tableLayoutPanel1.MouseLeave -= OnMouseLeave;

            profilePictureBox1.Dispose();
            panel1.Dispose();
            tableLayoutPanel1.Dispose();
            projectLabel.Dispose();
            teamLeadLabel.Dispose();
            versionLabel.Dispose();
        }

        private void InitializePageColor()
        {
            projectLabel.ForeColor = versionLabel.ForeColor = teamLeadLabel.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.SecondaryII);
        }

        private void InitializeTemplate()
        {
            projectLabel.Text = project.ProjectName;
            versionLabel.Text = "Latest Version:" + VersionManager.FetchProjectLatestVersion(project.ProjectID).VersionName;
            Employee emp = EmployeeManager.FetchEmployeeFromEmpID(project.TeamLeadID);
            teamLeadLabel.Text = emp.EmployeeFirstName;

            if (profilePictureBox1.Image != null)
            {
                profilePictureBox1.Image.Dispose();
            }
            try
            {
                profilePictureBox1.Image = Image.FromFile(emp.EmpProfileLocation);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Error", "Couldn't able to load the Profile Image");
            }
        }

        private void OnClicked(object sender, EventArgs e)
        {
            isClicked = true;
            ProjectClick?.Invoke(this, project);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            isHovered = true;
            if (!isClicked)
            {
                profilePictureBox1.ParentColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryIII);
            }
            Invalidate();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            isHovered = false;
            if (!isClicked)
            {
                profilePictureBox1.ParentColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen border = new Pen(ThemeManager.CurrentTheme.SecondaryIII, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, Width - 2, Height - 2), 10));
            border.Dispose();
            if (!isClicked)
            {
                if (isHovered)
                {
                    border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
                    e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(1, 1, Width - 4, Height - 4), 10));
                }
                else
                {
                    border = new Pen(ThemeManager.CurrentTheme.SecondaryIII, 2);
                    e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(1, 1, Width - 4, Height - 4), 10));
                }
            }
            border.Dispose();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private bool isHovered = false;
        private bool isClicked = false;
        private Projects project;

    }
}
