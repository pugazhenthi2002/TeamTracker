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
        

        private bool isClicked = false;
        private Projects project;

        public SingleProjectSelectTemplate()
        {
            DoubleBuffered = true;
            InitializeComponent();
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
            if (!isClicked)
            {
                this.BackColor = Color.FromArgb(102, 129, 150);
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                this.BackColor = Color.FromArgb(82, 109, 130);
            }
        }
    }
}
