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

namespace UserInterface.Edit_Project.Controls
{
    public partial class EditMilestone : UserControl
    {
        public List<Projects> ProjectCollection { get; set; }

        public EditMilestone()
        {
            InitializeComponent();
        }

        private void OnProjectNameChanged(object sender, string e)
        {
            boardBasePanel.SuspendLayout();
            selectedProject = null; selectedVersion = null;
            filteredProjectCollection = new List<Projects>();

            foreach (var Iter in ProjectCollection)
            {
                if (Iter.ProjectName.Contains(e))
                {
                    filteredProjectCollection.Add(Iter);
                }
            }

            InitializeProjectBoardControl();
            boardBasePanel.ResumeLayout();
        }

        private void InitializeProjectBoardControl()
        {
            startIdx = 0; isBackEnable = false;
            endIdx = filteredProjectCollection.Count >= 5 ? 4 : filteredProjectCollection.Count - 1;
            isNextEnable = filteredProjectCollection.Count > 5 ? true : false;

            boardBasePanel.Controls.Clear();

            for (int ctr = 0; ctr <= endIdx; ctr++)
            {
                template = new ProjectBoardTemplate()
                {
                    Dock = DockStyle.Left,
                    Project = filteredProjectCollection[ctr]
                };
                template.ProjectSelection += OnProjectSelected;
                boardBasePanel.Controls.Add(template);
            }

            foreach (Control Iter in boardBasePanel.Controls)
            {
                Iter.BringToFront();
            }
        }

        private void OnProjectSelected(object sender, Projects e)
        {
            selectedVersionCollection = VersionManager.FetchAllVersionFromProject(e.ProjectID);
            selectedProject = e;
            selectedVersion = selectedVersionCollection[0];
            selectedMilestoneCollection = MilestoneManager.FetchMilestones(selectedVersion.VersionID);
            InitializeControl();
        }

        private void InitializeControl()
        {
            //Home_Page.Team_Lead.On_Stage.MilestoneTemplate milestoneTemplate;
            //for (int ctr = 0; ctr < selectedMilestoneCollection.Count; ctr++)
            //{
            //    milestoneTemplate = tableLayoutPanel1.GetControlFromPosition(0, ctr) as Home_Page.Team_Lead.On_Stage.MilestoneTemplate;
            //    milestoneTemplate.IsFocused = ctr == focusIdx;
            //    milestoneTemplate.Counter = ctr + 1;
            //    milestoneTemplate.IsUpSwapEnable = ctr == 0 ? false : true;
            //    milestoneTemplate.IsDownSwapEnable = ctr == selectedMilestoneCollection.Count - 1 ? false : true;
            //    milestoneTemplate.SelectedMilestone = selectedMilestoneCollection[ctr];
            //}
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
            for (int ctr = startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
            {
                (boardBasePanel.Controls[idx] as ProjectBoardTemplate).Project = filteredProjectCollection[ctr];
            }

            isBackEnable = startIdx == 0 ? false : true;
            isNextEnable = endIdx == filteredProjectCollection.Count - 1 ? false : true;
        }

        private void OnMilestoneOperation(object sender, MilestoneEventArgs m)
        {
            //if (m.Movement == MilestoneOperation.Up)
            //{
            //    string tempName = m.MilestoneName;
            //    selectedMilestoneCollection[m.Position - 1].MileStoneName = selectedMilestoneCollection[m.Position - 2].MileStoneName;
            //    selectedMilestoneCollection[m.Position - 2].MileStoneName = tempName;
            //    if (focusIdx > 0)
            //    {
            //        focusIdx--;
            //        InitializeControl();
            //    }
            //    else
            //    {
            //        if (startIdx != 0)
            //        {
            //            OnUpClick(this, EventArgs.Empty);
            //        }
            //    }
            //}

            //if (m.Movement == MilestoneOperation.Down)
            //{
            //    string tempName = m.MilestoneName;
            //    selectedMilestoneCollection[m.Position - 1].MileStoneName = selectedMilestoneCollection[m.Position].MileStoneName;
            //    selectedMilestoneCollection[m.Position].MileStoneName = tempName;
            //    if (focusIdx < TemplateCollection.Count - 1)
            //    {
            //        focusIdx++;
            //        InitializeControl();
            //    }
            //    else
            //    {
            //        if (selectedMilestoneCollection.Count == TemplateCollection.Count)
            //        {
            //            focusIdx = TemplateCollection.Count - 1;
            //            InitializeControl();
            //        }
            //        else
            //        {
            //            OnDownClick(this, EventArgs.Empty);
            //        }
            //    }
            //}

            //if (m.Movement == MilestoneOperation.Delete)
            //{
            //    if (endIdx == selectedMilestoneCollection.Count)
            //    {
            //        MilestoneTemplate control = sender as MilestoneTemplate;
            //        basePanel.Controls.Remove(TemplateCollection[TemplateCollection.Count - 1]);
            //        foreach (var Iter in selectedMilestoneCollection)
            //        {
            //            if (Iter.MileStoneName == m.MilestoneName)
            //            {
            //                selectedMilestoneCollection.Remove(Iter);
            //                break;
            //            }
            //        }
            //        TemplateCollection.RemoveAt(endIdx - 1);
            //        endIdx--;
            //        focusIdx = endIdx - 1;
            //    }
            //    else
            //    {
            //        if (endIdx == selectedMilestoneCollection.Count)
            //        {
            //            startIdx--; endIdx--;
            //        }

            //        foreach (var Iter in selectedMilestoneCollection)
            //        {
            //            if (Iter.MileStoneName == m.MilestoneName)
            //            {
            //                selectedMilestoneCollection.Remove(Iter);
            //                break;
            //            }
            //        }
            //    }

            //    prevEndDate = selectedMilestoneCollection.Count == 0 ? startDate : selectedMilestoneCollection[selectedMilestoneCollection.Count - 1].EndDate;
            //    InitializeControl();
            //}

            //if (m.Movement == MilestoneOperation.Steady)
            //{
            //    selectedMilestoneCollection[m.Position - 1].MileStoneName = m.MilestoneName;
            //    selectedMilestoneCollection[m.Position - 1].EndDate = m.MilestoneDate;
            //    InitializeControl();
            //}
        }

        private int focusIdx = 0;
        private ProjectBoardTemplate template;
        private bool isBackEnable, isNextEnable;
        private int startIdx, endIdx;
        private Projects selectedProject;
        private List<Projects> filteredProjectCollection;
        private ProjectVersion selectedVersion;
        private List<ProjectVersion> selectedVersionCollection;
        private List<Milestone> selectedMilestoneCollection;
    }
}
