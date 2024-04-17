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

namespace UserInterface.Add_Project.Custom_Control
{
    public partial class SingleProjectSelectTemplate : UserControl
    {

        private bool isHovered = false;
        private bool isClicked = false;
        private Projects project;

        public SingleProjectSelectTemplate()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        public new void Dispose()
        {
            profilePictureBox1.Image.Dispose();
            profilePictureBox1.Dispose();
            panel1.Dispose();
            tableLayoutPanel1.Dispose();
            projectLabel.Dispose();
            teamLeadLabel.Dispose();
            versionLabel.Dispose();
        }

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
            }
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
            profilePictureBox1.Image = Image.FromFile(emp.EmpProfileLocation);
        }

        private void OnClicked(object sender, EventArgs e)
        {
            isClicked = true;
            ProjectClick?.Invoke(this, project);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            if (!isClicked)
            {
                profilePictureBox1.ParentColor = this.BackColor = Color.FromArgb(201, 210, 217);
            }
            Invalidate();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            if (!isClicked)
            {
                profilePictureBox1.ParentColor = this.BackColor = Color.FromArgb(221, 230, 237);
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen border = new Pen(Color.FromArgb(157, 178, 191), 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, Width - 2, Height - 2), 10));
            border.Dispose();

            if (isHovered)
            {
                border = new Pen(Color.FromArgb(39, 55, 77), 2);
                e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(1, 1, Width - 4, Height - 4), 10));
            }
            else
            {
                border = new Pen(Color.FromArgb(157, 178, 191), 2);
                e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(1, 1, Width - 4, Height - 4), 10));
            }
            border.Dispose();
        }
    }
}
