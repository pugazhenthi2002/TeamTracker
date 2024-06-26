﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Edit_Project
{
    public partial class Edit : UserControl
    {
        public Edit()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        public void InitializePageColor()
        {
            tabPage1.BackColor = tabPage2.BackColor = tabPage3.BackColor = tabPage4.BackColor = editTaskButton.BackColor = editMilestoneButton.ForeColor = editMilestoneButton.BackColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            editTask1.BackColor = editVersion1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            editTaskButton.ForeColor = editMilestoneButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
             
            if(tabControl1.SelectedIndex == 1 && tabControl2.SelectedIndex == 0)
            {
                editTaskButton.BackColor = editMilestoneButton.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
                editTaskButton.ForeColor = editMilestoneButton.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else if(tabControl1.SelectedIndex == 1 && tabControl2.SelectedIndex == 1)
            {
                editTaskButton.BackColor = editMilestoneButton.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                editTaskButton.ForeColor = editMilestoneButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            }
        }

        public void InitializePage()
        {
            if(EmployeeManager.CurrentEmployee.EmpRoleName == "Team Lead")
            {
                editTaskButton.BackColor = editMilestoneButton.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
                editTaskButton.ForeColor = editMilestoneButton.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
                editMilestone1.InitializePage();
                editMilestone1.ProjectCollection = VersionManager.FetchAllProjectsForTeamLeader();
                tabControl2.SelectedIndex = 0;
                tabControl1.SelectedIndex = 1;
            }
            else if(EmployeeManager.CurrentEmployee.EmpRoleName == "Project Manager")
            {
                editVersion1.ProjectCollection = VersionManager.FetchAllProjects();
                editVersion1.InitializePage();
                tabControl1.BackColor = Color.Red;
                tabControl1.SelectedIndex = 0;
            }
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            editMilestoneButton.Click -= EditMilestoneClick;
            editTaskButton.Click -= EditTaskClick;
        }

        private void EditTaskClick(object sender, EventArgs e)
        {
            editTaskButton.BackColor = editMilestoneButton.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            editTaskButton.ForeColor = editMilestoneButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            editTask1.InitializePage();
            editTask1.TaskCollection = TaskManager.FetchTaskByEmployee(EmployeeManager.CurrentEmployee);
            tabControl1.SelectedIndex = 1;
            tabControl2.SelectedIndex = 1;
        }

        private void EditMilestoneClick(object sender, EventArgs e)
        {
            editTaskButton.BackColor = editMilestoneButton.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            editTaskButton.ForeColor = editMilestoneButton.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            editMilestone1.InitializePage();
            editMilestone1.ProjectCollection = VersionManager.FetchAllProjectsForTeamLeader();
            tabControl2.SelectedIndex = 0;
        }
    }
}
