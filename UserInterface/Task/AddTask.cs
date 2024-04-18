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
using UserInterface.Task.CreateTask;

namespace UserInterface.Task
{
    public partial class AddTask : UserControl
    {
        private int startIdx, endIdx;
        private bool IsBackEnable, IsNextEnable;
        private List<TeamTracker.Task> underReviewCollection;
        private ReviewTaskTemplate template;
        private List<ReviewTaskTemplate> boardCollection;

        public AddTask()
        {
            InitializeComponent();
        }

        public void InitializePage()
        {
            if(VersionManager.CurrentVersion == null)
            {
                panel1.Visible = false;
                return;
            }
            InitializeReviewPage();
            milestoneSwitch1.InitializePage();
            currentTimelineContent1.Version = VersionManager.CurrentVersion;
            projectNameLabel.Text = VersionManager.FetchProjectName(VersionManager.CurrentVersion.VersionID) + " " + VersionManager.CurrentVersion.VersionName;
        }

        private void AddTaskClick(object sender, EventArgs e)
        {
            CreateTaskForm form = new CreateTaskForm();
            form.TaskCreate += OnTaskCreated;
            form.ShowDialog();
        }

        private void OnTaskCreated(object sender, EventArgs e)
        {
            InitializePage();
        }

        private void OnMoveToNextMilestoneClick(object sender, EventArgs e)
        {
            if (MilestoneManager.IsAllTaskCompletedInCurrentMilestone())
            {
                if(MilestoneManager.IsCurrentMilestoneIsLastMilestone())
                {
                    DeployWarningForm form1 = new DeployWarningForm();
                    form1.WarningStatus += OnDeployWarningStatusSelected;
                    form1.ShowDialog();
                }
                else
                {
                    SwitchMilestoneWarningForm form2 = new SwitchMilestoneWarningForm();
                    form2.WarningStatus += OnWarningStatusSelected;
                    form2.ShowDialog();
                }
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Warning", "Not All are Completed under this Milestone");
            }
        }

        private void OnWarningStatusSelected(object sender, bool e)
        {
            if (e)
            {
                MilestoneManager.SwitchToNextMilestone();
                InitializePage();
            }
        }

        private void OnDeployWarningStatusSelected(object sender, bool e)
        {
            if (e)
            {
                DeployForm form = new DeployForm();
                form.DoneClick += OnSourceCodeSubmission;
                form.Show();
            }
        }

        private void OnSourceCodeSubmission(object sender, EventArgs e)
        {
            MilestoneManager.UpdateMilestone(MilestoneManager.CurrentMilestone, MilestoneStatus.Completed);
            VersionManager.UpdateVersion(VersionManager.CurrentVersion, ProjectStatus.OnStage);
            InitializePage();
        }

        private void InitializeReviewPage()
        {
            underReviewCollection = TaskManager.FetchUnderReviewTask();
            
            if(underReviewCollection != null && underReviewCollection.Count > 0)
            {
                startIdx = 0;
                endIdx = underReviewCollection.Count > 5 ? 4 : underReviewCollection.Count - 1;
                IsBackEnable = false;
                IsNextEnable = endIdx > 5 ? true : false;
                CreateReviewUI();
            }
            else
            {
                panelBase.Visible = false;
            }
        }

        private void CreateReviewUI()
        {
            boardCollection = new List<ReviewTaskTemplate>();
            for(int ctr=0; ctr<=endIdx; ctr++)
            {
                template = new ReviewTaskTemplate()
                {
                    SelectedTask = underReviewCollection[ctr],
                    Dock = DockStyle.Left
                };
                panelBase.Controls.Add(template);
                template.TaskReviewed += OnTaskReviewed;
                boardCollection.Add(template);
            }

            foreach(ReviewTaskTemplate Iter in boardCollection)
            {
                Iter.BringToFront();
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            if (IsBackEnable)
            {
                startIdx--; endIdx--;
                ResetReviewUI();
            }
        }

        private void NextClick(object sender, EventArgs e)
        {
            if (IsNextEnable)
            {
                startIdx++; endIdx++;
                ResetReviewUI();
            }
        }

        private void OnTaskReviewed(object sender, EventArgs e)
        {
            ReviewTaskTemplate control = sender as ReviewTaskTemplate;

            if (underReviewCollection.Count == boardCollection.Count)
            {
                panelBase.Controls.Remove(boardCollection[boardCollection.Count - 1]);
                boardCollection.RemoveAt(boardCollection.Count - 1);
                endIdx--;
            }

            foreach (var Iter in underReviewCollection)
            {
                if(Iter.TaskID == control.SelectedTask.TaskID)
                {
                    underReviewCollection.Remove(Iter);
                    break;
                }
            }

            
            ResetReviewUI();
        }

        private void ResetReviewUI()
        {
            for(int ctr=startIdx, idx= 0; ctr<=endIdx; ctr++, idx++)
            {
                boardCollection[idx].SelectedTask = underReviewCollection[ctr];
            }

            IsBackEnable = startIdx == 0 ? false : true;
            IsNextEnable = endIdx == underReviewCollection.Count - 1 ? false : true;

            if (backPicBox.Image != null) backPicBox.Image.Dispose();
            if (nextPicBox.Image != null) nextPicBox.Image.Dispose();

            backPicBox.Image = IsBackEnable ? UserInterface.Properties.Resources.Back : UserInterface.Properties.Resources.Back_Hover;
            nextPicBox.Image = IsNextEnable ? UserInterface.Properties.Resources.Next : UserInterface.Properties.Resources.Next_Hover;

        }
    }
}
