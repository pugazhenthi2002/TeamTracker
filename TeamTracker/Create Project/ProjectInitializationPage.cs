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
    public partial class ProjectInitializationPage : UserControl
    {
        public ProjectInitializationPage()
        {
            InitializeComponent();
            InitializePlaceHolders();
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

        private void InitializeRoundedEdge()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            CreateProject.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, CreateProject.Width, CreateProject.Height, 10, 10));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void ProjectEntryTablePanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(39, 55, 77));
            e.Graphics.DrawLine(pen, new Point(10, projectTitleTextBox.Location.Y + projectTitleTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, projectTitleTextBox.Location.Y + projectTitleTextBox.Height + 1));
            e.Graphics.DrawLine(pen, new Point(10, projectDescTextBox.Location.Y + projectDescTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, projectDescTextBox.Location.Y + projectDescTextBox.Height + 1));
            pen.Dispose();
        }

        private void ProjectEntryTablePanel_Resize(object sender, EventArgs e)
        {
            ProjectEntryTablePanel.Invalidate();
        }

        private void OnTeamLeaderClick(Employee employee)
        {
            selectedTeamLeader1.EmployeeProfile = employee;
            teamLeader = employee;
            selectedTeamLeader1.Visible = true;
            availableTeamLeaders1.Visible = false;
            noResultFound1.Visible = false;
        }

        private void SelectedTeamLeader_OnChangeTeamLeader(object sender, EventArgs e)
        {
            teamLeader = null;
            selectedTeamLeader1.Visible = false;
            availableTeamLeaders1.Visible = true;
            noResultFound1.Visible = false;
        }

        private void InitializePlaceHolders()
        {
            projectDescTextBox.GotFocus += RemoveDescPlaceHolders;
            projectDescTextBox.LostFocus += AddDescPlaceHolders;
            projectTitleTextBox.GotFocus += RemoveTitlePlaceHolders;
            projectTitleTextBox.LostFocus += AddTitlePlaceHolders;
            clientTextBox.GotFocus += RemoveClientPlaceHolders;
            clientTextBox.LostFocus += AddClientPlaceHolders;
        }

        private void AddClientPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientTextBox.Text))
                clientTextBox.Text = "Client Email";
        }

        private void RemoveClientPlaceHolders(object sender, EventArgs e)
        {
            if (clientTextBox.Text == "Client Email")
            {
                clientTextBox.Text = "";
            }
        }

        private void AddTitlePlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(projectTitleTextBox.Text))
                projectTitleTextBox.Text = "Project Name";
        }

        private void RemoveTitlePlaceHolders(object sender, EventArgs e)
        {
            if (projectTitleTextBox.Text == "Project Name")
            {
                projectTitleTextBox.Text = "";
            }
        }

        private void AddDescPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(projectDescTextBox.Text))
                projectDescTextBox.Text = "Enter your Desc...";
        }

        private void RemoveDescPlaceHolders(object sender, EventArgs e)
        {
            if (projectDescTextBox.Text == "Enter your Desc...")
            {
                projectDescTextBox.Text = "";
            }
        }

        private void OnDateValueChanged(object sender, EventArgs e)
        {
            if (VersionManager.CheckDate(startDateTimePicker.Value, endDateTimePicker.Value))
            {
                List<Employee> availableTL = EmployeeManager.FetchAvailableTeamLeaders(startDateTimePicker.Value, endDateTimePicker.Value);
                if (availableTL.Count == 0)
                {
                    teamLeader = null;
                    availableTeamLeaders1.Visible = false;
                    selectedTeamLeader1.Visible = false;
                    noResultFound1.Visible = true;
                }
                else
                {
                    teamLeader = null;
                    availableTeamLeaders1.TeamLeaders = availableTL;
                    availableTeamLeaders1.Visible = true;
                    selectedTeamLeader1.Visible = false;
                    noResultFound1.Visible = false;
                }
            }
        }

        private void OnCreateClick(object sender, EventArgs e)
        {
            if (EligibleForCreatingProject())
            {
                VersionManager.AddProject(projectTitleTextBox.Text, projectDescTextBox.Text, teamLeader.EmployeeID, startDateTimePicker.Value, endDateTimePicker.Value, clientTextBox.Text, FetchAttachmentFiles());
                ReInitializeComponents();
            }
        }

        private bool EligibleForCreatingProject()
        {
            if (clientTextBox.Text == "" || !clientTextBox.Text.Contains("@gmail.com") || clientTextBox.Text == "Client Email")
            {
                return false;
            }

            if (projectTitleTextBox.Text == "" || VersionManager.IsProjectNameAlreadyExist(projectTitleTextBox.Text) || projectTitleTextBox.Text == "Project Name")
            {
                return false;
            }

            if (projectDescTextBox.Text == "" || projectDescTextBox.Text == "Enter your Desc...")
            {
                return false;
            }

            if (teamLeader == null)
            {
                return false;
            }

            if (!VersionManager.CheckDate(startDateTimePicker.Value, endDateTimePicker.Value))
            {
                return false;
            }

            return true;
        }

        private List<VersionAttachment> FetchAttachmentFiles()
        {
            List<VersionAttachment> attachments = new List<VersionAttachment>();

            foreach (var Iter in fileAttachment1.AttachmentCollection)
            {
                attachments.Add(Iter.Value);
            }

            return attachments;
        }

        public void ReInitializeComponents()
        {
            projectDescTextBox.Text = "Enter your Desc...";
            projectTitleTextBox.Text = "Project Name";
            clientTextBox.Text = "Client Email";
            startDateTimePicker.Value = DateTime.Now;
            endDateTimePicker.Value = DateTime.Now;
            fileAttachment1.ClearAttachments = true;
            noResultFound1.Visible = true;
            availableTeamLeaders1.Visible = false;
            selectedTeamLeader1.Visible = false;
        }

        private Employee teamLeader;
    }
}
