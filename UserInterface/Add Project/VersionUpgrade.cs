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
using UserInterface.Add_Project.Custom_Control;
using GoLibrary;

namespace TeamTracker
{
    public partial class VersionUpgrade : UserControl
    {
        private Projects project;

        public VersionUpgrade()
        {
            InitializeComponent();
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

        private void InitializeBorder()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));
            upgradeButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, upgradeButton.Width, upgradeButton.Height, 10, 10));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorder();
        }

        private void OnChooseProject(object sender, EventArgs e)
        {
            ChooseProjectForm form = new ChooseProjectForm();
            form.AvailableProjects = VersionManager.ProjectCollection;
            form.ProjectSelect += OnProjectSelected;
            form.ShowDialog();
        }

        private void OnProjectSelected(object sender, Projects e)
        {
            project = e;
            InitializeVersionPage();
        }

        private void InitializeVersionPage()
        {
            teamLeaderPicAndNameVertical1.TeamLeader = EmployeeManager.FetchEmployeeFromEmpID(project.TeamLeadID);
            latestUpgradedVersion1.LatestVersion = VersionManager.FetchProjectLatestVersion(project.ProjectID);
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            BooleanMsg message = isEligibleForVersionUpgrade();
            if (message)
            {
                ProjectManagerMainForm.notify.AddNotification("Version Created", project.ProjectName + "\n" + "Version Name: " + versionNameTextBox.Text);
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message.Message);
            }
            
        }

        private BooleanMsg isEligibleForVersionUpgrade()
        {
            if (project == null) return "No Project Selected for Version Upgrade";

            if (!VersionManager.IsTeamAvailableForProject(project.TeamLeadID, startDateTime.Value, endDateTime.Value))
            {
                startDateTime.Value = endDateTime.Value = VersionManager.FetchTeamLeadAvailableDate(project.ProjectID);
                return "Project Cannot be Started on Mentioned Date\nPlease Choose Another Date";
            }

            if (startDateTime.Value.Date == endDateTime.Value.Date) return "Project Cannot be Started on Mentioned Date\nPlease Choose Another Date";

            if (versionNameTextBox.Text == "" || versionNameTextBox.Text == "Enter Version") return "Version Name Not Mentioned";

            if (VersionManager.IsVersionNameAlreadyExist(versionNameTextBox.Text, project.ProjectID)) return "Version Name Already Exists\nTry Another Version";

            if(descTextBox.Text == "" || descTextBox.Text == "Enter Version Description")   return "Version Description Not Mentioned";

            return true;
        }

        private void OnDateValueChanged(object sender, EventArgs e)
        {
            if(project != null && !VersionManager.IsTeamAvailableForProject(project.TeamLeadID, startDateTime.Value, endDateTime.Value))
            {
                startDateTime.Value = endDateTime.Value = VersionManager.FetchTeamLeadAvailableDate(project.ProjectID);
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", "Project Cannot be Started on Mentioned Date\nPlease Choose Another Date\nAvailable Date: " + startDateTime.Value.ToShortDateString());
            }
            
        }
    }
}
