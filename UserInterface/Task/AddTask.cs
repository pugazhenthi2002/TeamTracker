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
using System.Runtime.InteropServices;

namespace UserInterface.Task
{
    public partial class AddTask : UserControl
    {
        private TransparentForm transparentForm;
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
            else
            {
                panel1.Visible = true;
                ucNotFound1.Visible = false;
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
            currentTimelineContent1.MilestoneCollection = MilestoneManager.FetchMilestones(VersionManager.CurrentVersion.VersionID);
            currentTimelineContent1.Version = VersionManager.CurrentVersion;
            projectNameLabel.Text = VersionManager.FetchProjectName(VersionManager.CurrentVersion.VersionID) + " " + VersionManager.CurrentVersion.VersionName;
        }

        private void AddTaskClick(object sender, EventArgs e)
        {
            CreateTaskForm form = new CreateTaskForm();
            form.TaskCreate += OnTaskCreated;
            form.TaskFormClose += OnTaskFormClosed;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnTaskFormClosed(object sender, EventArgs e)
        {
            (sender as CreateTaskForm).Dispose();
            (sender as CreateTaskForm).Close();

            if (ParentForm != null)
                ParentForm.Show();
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
                panelBase.Visible = true;
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

        private void OnReset(object sender, EventArgs e)
        {
            InitializePage();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            Pen border1 = new Pen(Color.FromArgb(221, 230, 237), 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 10));
            border1.Dispose();
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

        private void OnResetForm(object sender, EventArgs e)
        {
            InitializePage();
        }

        private void InitializeRoundedEdge()
        {
            milestoneSwitch1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, milestoneSwitch1.Width, milestoneSwitch1.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }
    }
}
