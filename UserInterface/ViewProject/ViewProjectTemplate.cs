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

namespace UserInterface.ViewProject
{
    public partial class ViewProjectTemplate : UserControl
    {
        private Employee PrevSelectedEmployee;
        private Employee SelectedEmployee;

        public ViewProjectTemplate()
        {
            InitializeComponent();
        }

        public void InitializeViewProject()
        {
            SelectedEmployee = EmployeeManager.CurrentEmployee;
            if(SelectedEmployee.EmpRoleName == "Team Member")
            {
                filterPanel.Visible = false;
            }
            filteredUser.Visible = false;
            PrevSelectedEmployee = null;
            tabControl1.SelectedIndex = 0;
            boardViewContent1.VersionCollection = VersionManager.CurrentEmployeeInvolvedVersions(SelectedEmployee);
            boardPanel.BackColor = Color.FromArgb(39, 55, 77);
            timelinePanel.BackColor = Color.FromArgb(221, 230, 237);
            boardLabel.ForeColor = Color.FromArgb(221, 230, 237);
            timelineLabel.ForeColor = Color.FromArgb(39, 55, 77);
        }

        private void OnBoardClicked(object sender, EventArgs e)
        {
            if(timelinePicBox.Image != null) { timelinePicBox.Image.Dispose(); }
            if(boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }

            boardPanel.BackColor = Color.FromArgb(39, 55, 77);
            timelinePanel.BackColor = Color.FromArgb(221, 230, 237);
            boardLabel.ForeColor = Color.FromArgb(221, 230, 237);
            timelineLabel.ForeColor = Color.FromArgb(39, 55, 77);

            boardPicBox.Image = UserInterface.Properties.Resources.Board_Click;
            timelinePicBox.Image = UserInterface.Properties.Resources.Timeline_Normal;

            boardViewContent1.VersionCollection = VersionManager.CurrentEmployeeInvolvedVersions(SelectedEmployee);
            tabControl1.SelectedIndex = 0;
        }

        private void OnTimelineClicked(object sender, EventArgs e)
        {
            if (boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }
            if (boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }

            timelinePanel.BackColor = Color.FromArgb(39, 55, 77);
            boardPanel.BackColor = Color.FromArgb(221, 230, 237);
            timelineLabel.ForeColor = Color.FromArgb(221, 230, 237);
            boardLabel.ForeColor = Color.FromArgb(39, 55, 77);

            boardPicBox.Image = UserInterface.Properties.Resources.Board_Normal;
            timelinePicBox.Image = UserInterface.Properties.Resources.Timeline_Click;

            timelineView1.ProjectCollection = VersionManager.CurrentEmployeeInvolvedProjects(SelectedEmployee);
            tabControl1.SelectedIndex = 1;
        }

        private void OnFilterClicked(object sender, EventArgs e)
        {
            TeamMembersListForm form = new TeamMembersListForm();
            form.Location = filterPanel.PointToScreen(new Point(0, filterPanel.Height + 1));
            form.Width = filterPanel.Width;
            form.TeamMemberClick += OnTeamMemberSelected;
            if(EmployeeManager.CurrentEmployee.EmpRoleName == "Project Manager")
            {
                form.TeamList = EmployeeManager.FetchTeamLeadersFromManagerID();
                form.Show();
            }
            else if(EmployeeManager.CurrentEmployee.EmpRoleName == "Team Lead")
            {
                form.TeamList = EmployeeManager.FetchTeamMembersForTeamLeaders();
                form.Show();
            }
            
        }

        private void OnTeamMemberSelected(object sender, Employee e)
        {
            if (filteredUser.Image != null)
                filteredUser.Image.Dispose();

            SelectedEmployee = e;
            filteredUser.Image = Image.FromFile(e.EmpProfileLocation);
            filteredUser.Visible = true;

            if (PrevSelectedEmployee != null)
            {
                if (PrevSelectedEmployee.EmployeeID == e.EmployeeID)
                {
                    SelectedEmployee = EmployeeManager.CurrentEmployee;
                    filteredUser.Visible = false;
                }
            }
            PrevSelectedEmployee = SelectedEmployee;
            boardViewContent1.VersionCollection = VersionManager.CurrentEmployeeInvolvedVersions(SelectedEmployee);
            timelineView1.ProjectCollection = VersionManager.CurrentEmployeeInvolvedProjects(SelectedEmployee);
        }
    }
}
