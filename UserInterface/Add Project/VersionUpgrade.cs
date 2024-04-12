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
            versionNameTextBox.LostFocus += AddVersionNamePlaceHolders;
            versionNameTextBox.GotFocus += RemoveVersionNamePlaceHolders;
            descTextBox.GotFocus += RemoveVersionDescPlaceHolders;
            descTextBox.LostFocus += AddVersionDescPlaceHolders;
            clientTextBox.GotFocus += RemoveClientPlaceHolders;
            clientTextBox.LostFocus += AddClientPlaceHolders;
        }

        public void InitializePage()
        {
            chooseProjectLabel.Text = "Choose Project";
            versionNameTextBox.Text = "Enter Version";
            descTextBox.Text = "Enter Version Description";
            clientTextBox.Text = "Enter Client Email";
            ucNotFound1.Visible = ucNotFound2.Visible = true;
            startDateTimePicker.Value = endDateTimePicker.Value = DateTime.Today;
            latestUpgradedVersion1.LatestVersion = null;
            fileAttachment1.AttachmentCollection = null;
            profilePicAndName1.EmployeeProfile = null;
        }

        private void AddVersionNamePlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(versionNameTextBox.Text))
                versionNameTextBox.Text = "Enter Version";
        }

        private void RemoveVersionNamePlaceHolders(object sender, EventArgs e)
        {
            if (versionNameTextBox.Text == "Enter Version")
            {
                versionNameTextBox.Text = "";
            }
        }

        private void RemoveVersionDescPlaceHolders(object sender, EventArgs e)
        {
            if (descTextBox.Text == "Enter Version Description")
            {
                descTextBox.Text = "";
            }
        }

        private void AddVersionDescPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descTextBox.Text))
                descTextBox.Text = "Enter Version Description";
        }

        private void RemoveClientPlaceHolders(object sender, EventArgs e)
        {
            if (clientTextBox.Text == "Enter Client Email")
            {
                clientTextBox.Text = "";
            }
        }

        private void AddClientPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientTextBox.Text))
                clientTextBox.Text = "Enter Client Email";
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
            endDatePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, endDatePanel.Width, endDatePanel.Height, 20, 20));
            startDatePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, startDatePanel.Width, startDatePanel.Height, 20, 20));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));
            upgradeButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, upgradeButton.Width, upgradeButton.Height, 10, 10));
        }

        private void OnChooseProject(object sender, EventArgs e)
        {
            ChooseProjectForm form = new ChooseProjectForm();
            form.AvailableProjects = VersionManager.FetchAllProjectsOnCompletedStatus();
            form.ProjectSelect += OnProjectSelected;
            form.ShowDialog();
        }

        private void OnProjectSelected(object sender, Projects e)
        {
            project = e;
            chooseProjectLabel.Text = e.ProjectName;
            InitializeVersionPage();
        }

        private void InitializeVersionPage()
        {
            profilePicAndName1.Visible = latestUpgradedVersion1.Visible = true;
            ucNotFound1.Visible = ucNotFound2.Visible = false;
            profilePicAndName1.EmployeeProfile = EmployeeManager.FetchEmployeeFromEmpID(project.TeamLeadID);
            latestUpgradedVersion1.LatestVersion = VersionManager.FetchProjectLatestVersion(project.ProjectID);
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            BooleanMsg message = isEligibleForVersionUpgrade();
            if (message)
            {
                List<VersionAttachment> attachments = FetchAttachmentFiles();
                if (attachments.Count == 0)
                {
                    AttachmentWarningForm form = new AttachmentWarningForm();
                    form.WarningStatus += OnWarningStatus;
                    form.Show();
                }
                else
                {
                    VersionManager.AddVersion(versionNameTextBox.Text, descTextBox.Text, profilePicAndName1.EmployeeProfile.EmployeeID, startDateTimePicker.Value, endDateTimePicker.Value, clientTextBox.Text, project.ProjectID, attachments);
                    InitializePage();
                    ProjectManagerMainForm.notify.AddNotification("Version Created", project.ProjectName + "\n" + "Version Name: " + versionNameTextBox.Text);
                }
                
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message.Message);
            }
        }

        private void OnWarningStatus(object sender, bool e)
        {
            if (e)
            {
                VersionManager.AddVersion(versionNameTextBox.Text, descTextBox.Text, profilePicAndName1.EmployeeProfile.EmployeeID, startDateTimePicker.Value, endDateTimePicker.Value, clientTextBox.Text, project.ProjectID, null);
                InitializePage();
                ProjectManagerMainForm.notify.AddNotification("Version Created", project.ProjectName + "\n" + "Version Name: " + versionNameTextBox.Text);
            }
        }

        private BooleanMsg isEligibleForVersionUpgrade()
        {
            if (project == null) return "No Project Selected for Version Upgrade";

            if (!VersionManager.IsTeamAvailableForProject(project.TeamLeadID, startDateTimePicker.Value, endDateTimePicker.Value))
            {
                DateTime availableDate = VersionManager.FetchTeamLeadAvailableDate(project.ProjectID);
                return "Project Cannot be Started on Mentioned Date\nTeam Leader Available After "+ availableDate.ToString();
            }

            if (startDateTimePicker.Value.Date == endDateTimePicker.Value.Date) return "Project Cannot be Started on Mentioned Date\nPlease Choose Another Date";

            if (versionNameTextBox.Text == "" || versionNameTextBox.Text == "Enter Version") return "Version Name Not Mentioned";

            if (VersionManager.IsVersionNameAlreadyExist(versionNameTextBox.Text, project.ProjectID)) return "Version Name Already Exists\nTry Another Version";

            if(descTextBox.Text == "" || descTextBox.Text == "Enter Version Description")   return "Version Description Not Mentioned";

            if (clientTextBox.Text == "" || !clientTextBox.Text.Contains("@gmail.com") || clientTextBox.Text == "Client Email")
            {
                return "Invalid Input\nEnter Proper EmailID";
            }

            return true;
        }

        private void OnDateValueChanged(object sender, EventArgs e)
        {
            if(project!=null && VersionManager.IsTeamAvailableForProject(project.TeamLeadID, startDateTimePicker.Value, endDateTimePicker.Value))
            {
                ucNotFound1.Visible = ucNotFound2.Visible = false;
                profilePicAndName1.Visible = latestUpgradedVersion1.Visible = true;
            }
            else
            {
                ucNotFound1.Visible = ucNotFound2.Visible = true;
                profilePicAndName1.Visible = latestUpgradedVersion1.Visible = false;
            }
        }

        private void OnChooseProjectLabelEnter(object sender, EventArgs e)
        {
            chooseProjectLabel.BackColor = Color.FromArgb(157, 178, 191);
            chooseProjectLabel.ForeColor = Color.Black;
        }

        private void OnChooseProjectLabelLeave(object sender, EventArgs e)
        {
            chooseProjectLabel.BackColor = Color.FromArgb(201, 210, 217);
            chooseProjectLabel.ForeColor = Color.FromArgb(39, 55, 77);
        }

        private void DateMouseEnter(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            if (name == "startDateTime" || name == "startDateLabel" || name == "startDatePanel")
            {
                startDatePanel.BackColor = startDateLabel.BackColor = Color.FromArgb(157, 178, 191);
                startDateLabel.ForeColor = Color.Black;
            }
            else
            {
                endDatePanel.BackColor = endDateLabel.BackColor = Color.FromArgb(157, 178, 191);
                endDateLabel.ForeColor = Color.Black;
            }
        }

        private void DateMouseLeave(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            if (name == "startDateTime" || name == "startDateLabel" || name == "startDatePanel")
            {
                startDatePanel.BackColor = startDateLabel.BackColor = Color.FromArgb(201, 210, 217);
                startDateLabel.ForeColor = Color.FromArgb(39, 55, 77);
            }
            else
            {
                endDatePanel.BackColor = endDateLabel.BackColor = Color.FromArgb(201, 210, 217);
                endDateLabel.ForeColor = Color.FromArgb(39, 55, 77);
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            InitializePage();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorder();
        }

        private List<VersionAttachment> FetchAttachmentFiles()
        {
            List<VersionAttachment> attachments = new List<VersionAttachment>();

            if (fileAttachment1.AttachmentCollection == null || fileAttachment1.AttachmentCollection.Count == 0)
                return attachments;

            foreach (var Iter in fileAttachment1.AttachmentCollection)
            {
                attachments.Add(Iter.Value);
            }

            if (attachments.Count > 0)
                return attachments;
            else { return null; }
        }
    }
}
