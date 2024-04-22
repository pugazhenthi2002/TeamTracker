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
        public event EventHandler Reset;

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

            if (MilestoneManager.CurrentMilestone == null)
            {
                milestoneSwitch1.Visible = true;
            }
            else
            {
                milestoneSwitch1.InitializePage();
            }
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


        private void OnSourceCodeSubmission(object sender, VersionSourceCode e)
        {
            MilestoneManager.UpdateMilestone(MilestoneManager.CurrentMilestone, MilestoneStatus.Completed);
            MilestoneManager.CurrentMilestone = null;
            VersionManager.UpdateVersion(VersionManager.CurrentVersion, ProjectStatus.Deployment);
            DataHandler.AddVersionSourceCode(e);
            InitializePage();
        }

        private void InitializeReviewPage()
        {
            panelBase.Controls.Clear();
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

            IsBackEnable = startIdx == 0 ? false : true;
            IsNextEnable = endIdx == underReviewCollection.Count - 1 ? false : true;

            if (backPicBox.Image != null) backPicBox.Image.Dispose();
            if (nextPicBox.Image != null) nextPicBox.Image.Dispose();

            backPicBox.Image = IsBackEnable ? UserInterface.Properties.Resources.Left_Dark_Blue : UserInterface.Properties.Resources.Left_Medium_Blue;
            nextPicBox.Image = IsNextEnable ? UserInterface.Properties.Resources.Right_Dark_Blue : UserInterface.Properties.Resources.Right_Medium_Blue;
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

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Image != null) (sender as PictureBox).Image.Dispose();

            if ((sender as Control).Name == "backPicBox")
            {
                backPicBox.Image = UserInterface.Properties.Resources.Left_Dark_Blue_Hover;
            }
            else
            {
                nextPicBox.Image = UserInterface.Properties.Resources.Right_Dark_Blue_Hover;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if((sender as PictureBox).Image != null)    (sender as PictureBox).Image.Dispose(); 

            if((sender as Control).Name == "backPicBox")
            {
                backPicBox.Image = IsBackEnable ? UserInterface.Properties.Resources.Left_Dark_Blue : UserInterface.Properties.Resources.Left_Medium_Blue;
            }
            else
            {
                nextPicBox.Image = IsNextEnable ? UserInterface.Properties.Resources.Right_Dark_Blue : UserInterface.Properties.Resources.Right_Medium_Blue;
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
            InitializePage();
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

            backPicBox.Image = IsBackEnable ? UserInterface.Properties.Resources.Left_Dark_Blue : UserInterface.Properties.Resources.Left_Medium_Blue;
            nextPicBox.Image = IsNextEnable ? UserInterface.Properties.Resources.Right_Dark_Blue : UserInterface.Properties.Resources.Right_Medium_Blue;
        }
    }
}
