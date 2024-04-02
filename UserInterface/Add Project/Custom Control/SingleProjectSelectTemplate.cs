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

        private Projects project;

        public SingleProjectSelectTemplate()
        {
            InitializeComponent();
        }

        private void InitializeTemplate()
        {
            projectLabel.Text = project.ProjectName;
            versionLabel.Text = VersionManager.FetchProjectLatestVersion(project.ProjectID).VersionName;
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
            ProjectClick?.Invoke(this, project);
        }
    }
}
