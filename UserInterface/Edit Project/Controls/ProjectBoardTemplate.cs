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
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            projectNameLabel.ForeColor = employeeProfilePicAndName1.ForeColor = totalVersionsLabel.ForeColor = lastVersionLabel.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        private void InitializeControl()
        {
            projectNameLabel.Text = project.ProjectName;
            totalVersionsLabel.Text = "Total Versions: " + VersionManager.FetchAllVersionFromProject(project.ProjectID).Count;
            lastVersionLabel.Text = "Last Version: " + VersionManager.FetchProjectLatestVersion(project.ProjectID).VersionName;
            employeeProfilePicAndName1.Profile = EmployeeManager.FetchEmployeeFromEmpID(project.TeamLeadID);
        }

        private void OnProjectClicked(object sender, EventArgs e)
        {
            ProjectSelection?.Invoke(this, project);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryI;
            projectNameLabel.ForeColor = employeeProfilePicAndName1.ForeColor = totalVersionsLabel.ForeColor = lastVersionLabel.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            projectNameLabel.ForeColor = employeeProfilePicAndName1.ForeColor = totalVersionsLabel.ForeColor = lastVersionLabel.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        private Projects project;
    }
}
