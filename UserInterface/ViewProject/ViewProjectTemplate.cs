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
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void InitializePageColor()
        {
            filterLabel.ForeColor = boardPanel.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            boardViewContent1.BackColor = timelineView1.BackColor = filterPanel.BackColor = timelinePanel.BackColor = ThemeManager.CurrentTheme.SecondaryIII; 
            BackColor = tabPage1.BackColor = tabPage2.BackColor = ThemeManager.CurrentTheme.SecondaryIII; 

            if(tabControl1.SelectedIndex == 0)
            {
                boardPanel.BackColor = timelineLabel.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
                boardLabel.ForeColor = timelinePanel.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else
            {
                timelinePanel.BackColor = boardLabel.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
                boardPanel.BackColor = timelineLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
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
            boardPanel.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            timelinePanel.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            boardLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            timelineLabel.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        private void OnBoardClicked(object sender, EventArgs e)
        {
            if(timelinePicBox.Image != null) { timelinePicBox.Image.Dispose(); }
            if(boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }

            boardPanel.BackColor = timelineLabel.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            boardLabel.ForeColor = timelinePanel.BackColor = ThemeManager.CurrentTheme.SecondaryIII;

            boardPicBox.Image = UserInterface.Properties.Resources.Board_Click;
            timelinePicBox.Image = UserInterface.Properties.Resources.Timeline_Normal;

            boardViewContent1.VersionCollection = VersionManager.CurrentEmployeeInvolvedVersions(SelectedEmployee);
            tabControl1.SelectedIndex = 0;
        }

        private void OnTimelineClicked(object sender, EventArgs e)
        {
            if (boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }
            if (boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }

            timelinePanel.BackColor = boardLabel.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            boardPanel.BackColor = timelineLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;

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
            form.Show();
            form.TeamMemberClick += OnTeamMemberSelected;
            if(EmployeeManager.CurrentEmployee.EmpRoleName == "Project Manager")
            {
                form.TeamList = EmployeeManager.FetchTeamLeadersFromManagerID();
            }
            else if(EmployeeManager.CurrentEmployee.EmpRoleName == "Team Lead")
            {
                form.TeamList = EmployeeManager.FetchTeamMembersForTeamLeaders();
            }
        }

        private void OnTeamMemberSelected(object sender, Employee e)
        {
            SelectedEmployee = e;
            filteredUser.Image = Image.FromFile(e.EmpProfileLocation);
            filteredUser.Visible = true;
            if (EmployeeManager.CurrentEmployee.EmpRoleName == "Team Lead") timelineView1.FilteredEmployee = e;
            if (PrevSelectedEmployee != null)
            {
                if (PrevSelectedEmployee.EmployeeID == e.EmployeeID)
                {
                    timelineView1.FilteredEmployee = null;
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
