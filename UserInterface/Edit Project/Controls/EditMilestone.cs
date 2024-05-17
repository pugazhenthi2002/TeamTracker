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
using UserInterface.Home_Page.Team_Lead.On_Stage;
using UserInterface.ViewProject.BoardView.Custom_Controls;
using GoLibrary;
using UserInterface.ViewPage;
using UserInterface.ViewProject;

namespace UserInterface.Edit_Project.Controls
{
    public partial class EditMilestone : UserControl
    {
        public List<Projects> ProjectCollection { get; set; }

        public EditMilestone()
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
            panel7.BackColor = boardBaseManualPanel.BackColor = boardBasePanel.BackColor = ucNotFound1.BackColor = ucNotFound2.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            milestoneDateTime.SkinColor = milestoneTextBox.BackColor = buttonUpdate.ForeColor = manualEdit.BackColor = requiredEdit.ForeColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            manualEdit.ForeColor = requiredEdit.BackColor = buttonUpdate.BackColor = pictureBox2.BackColor = pictureBox3.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = versionNames.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            milestoneTextBox.ForeColor = milestoneDateTime.BorderColor = milestoneDateTime.TextColor = ThemeManager.CurrentTheme.PrimaryI;

            if(tabControl1.SelectedIndex == 0)
            {
                requiredEdit.ForeColor = manualEdit.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
                requiredEdit.BackColor = manualEdit.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            }
            else
            {
                requiredEdit.ForeColor = manualEdit.BackColor = ThemeManager.CurrentTheme.PrimaryI;
                requiredEdit.BackColor = manualEdit.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
        }

        public void InitializePage()
        {
            SuspendLayout();
            if (tabControl1.SelectedIndex == 0)
            {
                panel3.Visible = false;
                requiredVersion = VersionManager.FetchEditVersions();
                InitializeRequiredControl();
            }
            else
            {
                panel3.Visible = true;
                filteredProjects = ProjectCollection;
                InitializeProjectBoardControl();
            }
            ResumeLayout();
        }

        private void InitializeRequiredControl()
        {
            startIdx = 0; isBackEnable = false;
            endIdx = requiredVersion.Count >= 5 ? 4 : requiredVersion.Count - 1;
            isNextEnable = requiredVersion.Count > 5 ? true : false;

            if (requiredVersion.Count == 0)
            {
                ucNotFound1.Visible = true; boardBasePanel.Visible = false;
                return;
            }
            else
            {
                ucNotFound1.Visible = false; boardBasePanel.Visible = true;
            }

            boardBasePanel.Controls.Clear();

            for (int ctr = 0; ctr <= endIdx; ctr++)
            {
                versionTemplate = new BoardViewTemplate()
                {
                    Dock = DockStyle.Left,
                    BoardVersion = requiredVersion[ctr]
                };
                versionTemplate.VersionSelect += OnVersionSelection;
                boardBasePanel.Controls.Add(versionTemplate);
            }

            foreach (Control Iter in boardBasePanel.Controls)
            {
                Iter.BringToFront();
            }
        }

        private void OnVersionSelection(object sender, ProjectVersion e)
        {
            selectedVersion = e;
            milestoneCollection = MilestoneManager.FetchMilestones(e.VersionID);
            InitializeControl();
        }

        private void addMilestoneButton_Click(object sender, EventArgs e)
        {
            BooleanMsg message = new BooleanMsg();
            message = IsEligibleToAdd();

            if (message)
            {
                milestoneCollection.Add(new Milestone()
                {
                    MileStoneName = milestoneTextBox.Text,
                    StartDate = prevEndDate.Date,
                    EndDate = milestoneDateTime.Value.Date,
                    VersionID = selectedVersion.VersionID,
                    Status = selectedVersion.StatusOfVersion == ProjectStatus.Completed ? MilestoneStatus.Completed : MilestoneStatus.Upcoming,
                    IsDelayed = false
                });
                prevEndDate = milestoneDateTime.Value.Date;
                InitializeControl();
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message);
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            foreach(var Iter in tableLayoutPanel1.Controls)
            {
                (Iter as MilestoneTemplate).Visible = false;
            }
            milestoneCollection.Clear();
            prevEndDate = startDate;
        }

        private void SetMilestones()
        {
            DateTime prevDate = startDate;
            if (milestoneCollection.Count >= 1)
            {
                milestoneCollection.Sort((m1, m2) => m1.EndDate.CompareTo(m2.EndDate));

                for (int ctr = 0; ctr < milestoneCollection.Count; ctr++)
                {
                    if (ctr == 0)
                    {
                        if (milestoneCollection[ctr].Status == MilestoneStatus.Upcoming)
                            milestoneCollection[ctr].Status = MilestoneStatus.OnProcess;
                    }
                    milestoneCollection[ctr].StartDate = prevDate;
                    prevDate = milestoneCollection[ctr].EndDate;
                }

                milestoneCollection[milestoneCollection.Count - 1].EndDate = endDate;
            }
        }

        private BooleanMsg isEligibleContraints()
        {
            DateTime prevDate = startDate;

            for (int ctr = 0; ctr < milestoneCollection.Count; ctr++)
            {
                if (prevDate >= milestoneCollection[ctr].EndDate)
                {
                    return "Milestone Date is not in Proper Order";
                }
                prevDate = milestoneCollection[ctr].EndDate;
            }

            return true;
        }

        private bool OnCheckContraints(object sender, MilestoneEventArgs m)
        {
            for (int ctr = 0; ctr < milestoneCollection.Count; ctr++)
            {
                if (ctr + 1 != m.Position && m.MilestoneName == milestoneCollection[ctr].MileStoneName)
                {
                    return false;
                }
            }
            if (m.Position == 1)
            {
                return startDate < m.MilestoneDate;
            }
            else
            {
                return milestoneCollection[m.Position - 2].EndDate < m.MilestoneDate;
            }
        }

        private void OnMilestoneOperation(object sender, MilestoneEventArgs m)
        {
            if (m.Movement == MilestoneOperation.Up)
            {
                string tempName = m.MilestoneName;
                milestoneCollection[m.Position - 1].MileStoneName = milestoneCollection[m.Position - 2].MileStoneName;
                milestoneCollection[m.Position - 2].MileStoneName = tempName;
                InitializeControl();
            }

            if (m.Movement == MilestoneOperation.Down)
            {
                string tempName = m.MilestoneName;
                milestoneCollection[m.Position - 1].MileStoneName = milestoneCollection[m.Position].MileStoneName;
                milestoneCollection[m.Position].MileStoneName = tempName;
                InitializeControl();
            }

            if (m.Movement == MilestoneOperation.Delete)
            {
               foreach(var Iter in milestoneCollection)
                {
                    if(Iter.MileStoneName == m.MilestoneName)
                    {
                        milestoneCollection.Remove(Iter);
                        break;
                    }
                }
                InitializeControl();
            }

            if (m.Movement == MilestoneOperation.Steady)
            {
                milestoneCollection[m.Position - 1].MileStoneName = m.MilestoneName;
                milestoneCollection[m.Position - 1].EndDate = m.MilestoneDate;
                InitializeControl();
            }
        }

        private BooleanMsg IsEligibleToAdd()
        {
            if(milestoneCollection.Count == 8)
            {
                return "Milestone Count should be less than 8";
            }

            if (milestoneTextBox.Text.Length == 0 || milestoneTextBox.Text.Length > 30)
            {
                return "Milestone Name Length should be Between 0 and 30";
            }

            if (!(prevEndDate < milestoneDateTime.Value.Date && milestoneDateTime.Value.Date <= endDate))
            {
                return "Milestone Date is Invalid\nEnd Date should be within Previous Milestone Start Date and Version End Date";
            }

            if (milestoneTextBox.Text == "")
            {
                return "Milestone Name is Not Valid";
            }

            for (int ctr = 0; ctr < milestoneTextBox.Text.Length; ctr++)
            {
                if (!((milestoneTextBox.Text[ctr] <= 'z' && milestoneTextBox.Text[ctr] >= 'a') || (milestoneTextBox.Text[ctr] <= 'Z' && milestoneTextBox.Text[ctr] >= 'A') || milestoneTextBox.Text[ctr] == ' '))
                {
                    return "Milestone Name should not contains any numbers or characters";
                }
            }

            if (MilestoneContains())
            {
                return "Milestone Name Already Exists";
            }

            return true;
        }

        private BooleanMsg MilestoneContains()
        {
            foreach (var Iter in milestoneCollection)
            {
                if (Iter.MileStoneName == milestoneTextBox.Text)
                {
                    return new BooleanMsg()
                    {
                        Message = "Duplicate Milestone",
                        Result = true
                    };
                }
            }
            return false;
        }

        private void OnUpdateMilestone(object sender, EventArgs e)
        {
            BooleanMsg message = isEligibleContraints();
            if (message)
            {
                WarningForm form = new WarningForm();
                form.Content = "Are you sure, you want to update the Project Version? This will affect the milestone and task duration";
                form.WarningStatus += OnUpdateStatus;

                transparentForm = new TransparentForm();
                transparentForm.Show();
                transparentForm.ShowForm(form);
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message);
            }
        }

        private void OnUpdateStatus(object sender, bool e)
        {
            (sender as WarningForm).Dispose();
            (sender as WarningForm).Close();

            if (e)
            {
                MilestoneManager.DeleteAllMilestoneFromVersion(selectedVersion.VersionID);
                MilestoneManager.AddMilestones(selectedVersion.VersionID, milestoneCollection);
                DataHandler.RemoveEdit(selectedVersion.VersionID, EditMode.Version);
                foreach(TeamTracker.Task Iter in TaskManager.TaskCollection)
                {
                    if(Iter.VersionID == selectedVersion.VersionID)
                    {
                        DataHandler.AddEdit(new TeamTracker.Edit()
                        {
                            EditModeID = Iter.TaskID,
                            ModeOfEdit = EditMode.Task
                        });
                    }
                }

                InitializePage();
            }
        }

        private void OnProjectNameChanged(object sender, string e)
        {
            SuspendLayout();
            filteredProjects = new List<Projects>();
            foreach(var Iter in ProjectCollection)
            {
                if (Iter.ProjectName.Contains(e))
                {
                    filteredProjects.Add(Iter);
                }
            }
            InitializeProjectBoardControl();
            ResumeLayout();
        }

        private void InitializeProjectBoardControl()
        {
            startIdx = 0; isBackEnable = false;
            endIdx = filteredProjects.Count >= 5 ? 4 : filteredProjects.Count - 1;
            isNextEnable = filteredProjects.Count > 5 ? true : false;

            boardBaseManualPanel.Controls.Clear();

            for (int ctr = 0; ctr <= endIdx; ctr++)
            {
                projectTemplate = new ProjectBoardTemplate()
                {
                    Dock = DockStyle.Left,
                    Project = filteredProjects[ctr]
                };
                projectTemplate.ProjectSelection += OnProjectSelected;
                boardBaseManualPanel.Controls.Add(projectTemplate);
            }

            foreach (Control Iter in boardBaseManualPanel.Controls)
            {
                Iter.BringToFront();
            }
        }

        private void OnProjectSelected(object sender, Projects e)
        {
            selectedProject = e;
            selectedProjAllVersions = VersionManager.FetchAllVersionFromProject(e.ProjectID);
            selectedVersion = selectedProjAllVersions[0];
            versionNames.Text = selectedVersion.VersionName;
            milestoneCollection = MilestoneManager.FetchMilestones(selectedVersion.VersionID);
            InitializeControl();
        }

        private void OnChooseVersionClicked(object sender, EventArgs e)
        {
                VersionViewForm form = new VersionViewForm()
                {
                    VersionCollection = selectedProjAllVersions,
                    Location = panel7.PointToScreen(new Point(0, panel7.Height + 5)),
                    Width = panel7.Width,
                    BackColor = ThemeManager.CurrentTheme.SecondaryI
                };
                form.VersionSelected += OnVersionSelected;
                form.Show();
        }

        private void OnVersionSelected(object sender, ProjectVersion e)
        {
            selectedVersion = e;
            versionNames.Text = selectedVersion.VersionName;
            milestoneCollection = MilestoneManager.FetchMilestones(selectedVersion.VersionID);
            InitializeControl();
        }

        private void InitializeControl()
        {
            for (int ctr = 0; ctr < 8; ctr++)
            {
                if (ctr < milestoneCollection.Count)
                {
                    (tableLayoutPanel1.GetControlFromPosition(0, ctr) as MilestoneTemplate).Visible = true;
                    (tableLayoutPanel1.GetControlFromPosition(0, ctr) as MilestoneTemplate).SelectedMilestone = milestoneCollection[ctr];
                    (tableLayoutPanel1.GetControlFromPosition(0, ctr) as MilestoneTemplate).IsUpSwapEnable = ctr == 0 ? false : true;
                    (tableLayoutPanel1.GetControlFromPosition(0, ctr) as MilestoneTemplate).IsDownSwapEnable = ctr == milestoneCollection.Count - 1 ? false : true;
                    (tableLayoutPanel1.GetControlFromPosition(0, ctr) as MilestoneTemplate).Counter = ctr + 1;
                    prevEndDate = milestoneCollection[ctr].EndDate;
                }
                else
                {
                    (tableLayoutPanel1.GetControlFromPosition(0, ctr) as MilestoneTemplate).Visible = false;
                }
            }
            startDate = selectedVersion.StartDate;
            endDate = selectedVersion.EndDate;
        }

        private void OnNextBtnClicked(object sender, EventArgs e)
        {
            if (isNextEnable)
            {
                startIdx++; endIdx++;
                ResetControls();
            }
        }

        private void OnBackBtnClicked(object sender, EventArgs e)
        {
            if (isBackEnable)
            {
                startIdx--; endIdx--;
                ResetControls();
            }
        }

        private void ResetControls()
        {
            if(tabControl1.SelectedIndex == 0)
            {
                for (int ctr = startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
                {
                    (boardBasePanel.Controls[idx] as BoardViewTemplate).BoardVersion = requiredVersion[ctr];
                }

                isBackEnable = startIdx == 0 ? false : true;
                isNextEnable = endIdx == requiredVersion.Count - 1 ? false : true;
            }
            else
            {
                for (int ctr = startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
                {
                    (boardBasePanel.Controls[idx] as ProjectBoardTemplate).Project = filteredProjects[ctr];
                }

                isBackEnable = startIdx == 0 ? false : true;
                isNextEnable = endIdx == requiredVersion.Count - 1 ? false : true;
            }
        }

        private void OnManualClick(object sender, EventArgs e)
        {
            requiredEdit.ForeColor = manualEdit.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            requiredEdit.BackColor = manualEdit.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            filteredProjects = ProjectCollection;
            tabControl1.SelectedIndex = 1;
            InitializePage();
        }

        private void OnRequiredClick(object sender, EventArgs e)
        {
            requiredEdit.ForeColor = manualEdit.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            requiredEdit.BackColor = manualEdit.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            tabControl1.SelectedIndex = 0;
            InitializePage();
        }

        private void OnLineSeperatePaint(object sender, PaintEventArgs e)
        {
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(border, 0, (sender as Control).Height - 1, (sender as Control).Width, (sender as Control).Height - 1);
            border.Dispose();
        }

        private bool isBackEnable, isNextEnable;
        private int startIdx, endIdx;
        private DateTime prevEndDate, startDate, endDate;
        private BoardViewTemplate versionTemplate;
        private ProjectBoardTemplate projectTemplate;
        private ProjectVersion selectedVersion;
        private TransparentForm transparentForm;
        private Projects selectedProject;
        private List<ProjectVersion> requiredVersion;
        private List<ProjectVersion> selectedProjAllVersions;
        private List<Projects> filteredProjects;
        private List<Milestone> milestoneCollection;
    }
}
