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
using System.Runtime.InteropServices;

namespace UserInterface.Edit_Project.Controls
{
    public partial class ProjectBoardTemplate : UserControl
    {
        public event EventHandler<Projects> ProjectSelection;

        public Projects Project
        {
            get { return project; }
            set
            {
                project = value;
                InitializeControl();
            }
        }

        public ProjectBoardTemplate()
        {
            InitializeComponent();
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            profilePictureBox1.ParentColor = panel1.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            projectNameLabel.ForeColor = label1.ForeColor = totalVersionsLabel.ForeColor = lastVersionLabel.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        private void InitializeControl()
        {
            projectNameLabel.Text = project.ProjectName;
            totalVersionsLabel.Text = "Total Versions: " + VersionManager.FetchAllVersionFromProject(project.ProjectID).Count;
            lastVersionLabel.Text = "Last Version: " + VersionManager.FetchProjectLatestVersion(project.ProjectID).VersionName;
            label1.Text = EmployeeManager.FetchEmployeeFromEmpID(project.TeamLeadID).EmployeeFirstName;
            try
            {
                profilePictureBox1.Image = Image.FromFile(EmployeeManager.FetchEmployeeFromEmpID(project.TeamLeadID).EmpProfileLocation);
            }
            catch { }
        }

        private void OnProjectClicked(object sender, EventArgs e)
        {
            ProjectSelection?.Invoke(this, project);
        }

        private void OnEmployeeSelected(object sender, Employee e)
        {
            ProjectSelection?.Invoke(this, project);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            profilePictureBox1.ParentColor = panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            projectNameLabel.ForeColor = label1.ForeColor = totalVersionsLabel.ForeColor = lastVersionLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            profilePictureBox1.ParentColor = panel1.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            projectNameLabel.ForeColor = label1.ForeColor = totalVersionsLabel.ForeColor = lastVersionLabel.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        private void InitializeBorder()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }

        private void OnLineSeperatePaint(object sender, PaintEventArgs e)
        {
            Pen border;
            if (!isHovered)
                border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            else
                border = new Pen(ThemeManager.CurrentTheme.SecondaryIII, 2);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(border, 0, (sender as Control).Height - 1, (sender as Control).Width, (sender as Control).Height - 1);
            border.Dispose();
        }

        private void BorderDrawPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1);
            Pen border1 = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 10));

            border1.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorder();
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

        private bool isHovered;
        private Projects project;

        
    }
}
