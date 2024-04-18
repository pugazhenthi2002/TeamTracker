using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserInterface.ViewPage.ListView;
using System.Runtime.InteropServices;

namespace TeamTracker
{
    public partial class ListViewTemplate : UserControl
    {
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
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 40, 40));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 40, 40));
        }

        public List<Task> DoneTaskCollection
        {
            set
            {
                doneTaskPanel.Controls.Clear();
                doneCollection = value;
                if (value != null && value.Count > 0)
                {
                    doneTaskPanel.Visible = true;
                    doneCardCollection = new List<DoneCardTemplate>();
                    startDoneIdx = 0; isDoneBackEnabled = false;
                    endDoneIdx = value.Count > 5 ? 4 : value.Count-1;
                    isDoneNextEnabled = value.Count > 5 ? true : false;
                    SetDoneAllignment();
                }
                else
                {
                    doneTaskPanel.Visible = doneTaskPageBack.Visible = doneTaskPageNext.Visible = false;
                }
            }
        }
        public List<Task> RemainingTaskCollection
        {
            set
            {
                singleListControlPanel.Controls.Clear();
                if (value != null && value.Count > 0)
                {
                    singleListControlPanel.Visible = true;
                    singleListCollection = new List<SingleList>();
                    taskCollection = value;
                    startRemainingIdx = 0;
                    isRemainingBackEnabled = false;
                    endRemainingIdx = value.Count > 5 ? 4 : value.Count - 1;
                    isRemainingNextEnables = value.Count > 5 ? true : false;
                    SetRemainingTaskAllignment();
                }
                else
                {
                    singleListControlPanel.Visible = false;
                }
            }
        }

        private bool isRemainingBackEnabled, isRemainingNextEnables, isDoneBackEnabled, isDoneNextEnabled;
        private int startRemainingIdx, endRemainingIdx, startDoneIdx, endDoneIdx;
        private DoneCardTemplate doneCards;
        private SingleList listTemplate;
        private List<SingleList> singleListCollection;
        private List<DoneCardTemplate> doneCardCollection;
        private List<Task> taskCollection;
        private List<Task> doneCollection;

        public void InitializePage()
        {
            projectDateLabel.Text = VersionManager.CurrentVersion.StartDate.ToShortDateString() + "-" + VersionManager.CurrentVersion.EndDate.ToShortDateString();
            projectNameLabel.Text = VersionManager.FetchProjectName(VersionManager.CurrentVersion.VersionID) + " " + VersionManager.CurrentVersion.VersionName;
            customDonutChart1.Values = FetchTaskCountsByStatus();
            customDonutChart2.Values = FetchTaskCountsByPriority();
        }

        private void OnPaginateDown(object sender, EventArgs e)
        {
            if (isRemainingNextEnables)
            {
                startRemainingIdx++;
                endRemainingIdx++;
                ReorderRemainingTask();
            }
        }

        private void OnDonePaginateBack(object sender, EventArgs e)
        {
            if (isDoneBackEnabled)
            {
                startDoneIdx--;
                endDoneIdx--;
                ReorderDoneTask();
            }
        }

        private void OnDonePaginateNext(object sender, EventArgs e)
        {
            if (isDoneNextEnabled)
            {
                startDoneIdx++;
                endDoneIdx++;
                ReorderDoneTask();
            }
        }

        public ListViewTemplate()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        private void OnPaginateUp(object sender, EventArgs e)
        {
            if (isRemainingBackEnabled)
            {
                startRemainingIdx--;
                endRemainingIdx--;
                ReorderRemainingTask();
            }
        }

        private void SetRemainingTaskAllignment()
        {
            for (int ctr = 0; ctr <= endRemainingIdx; ctr++)
            {
                listTemplate = new SingleList()
                {
                    ListTask = taskCollection[ctr],
                    Height = 50,
                    Dock = DockStyle.Top
                };
                listTemplate.Reset += OnReset;
                singleListControlPanel.Controls.Add(listTemplate);
                singleListCollection.Add(listTemplate);
            }

            foreach (var Iter in singleListCollection)
            {
                Iter.BringToFront();
            }

            if (remainingTaskpaginateUp.Image != null) remainingTaskpaginateUp.Image.Dispose();
            if (remainingTaskpaginateDown.Image != null) remainingTaskpaginateDown.Image.Dispose();

            remainingTaskpaginateDown.Image = isRemainingNextEnables ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
            remainingTaskpaginateUp.Image = isRemainingBackEnabled ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
        }

        private void OnReset(object sender, EventArgs e)
        {
            InitializePage();
        }

        private void ReorderRemainingTask()
        {
            for (int ctr = startRemainingIdx, idx = 0; ctr <= endRemainingIdx; ctr++, idx++)
            {
                singleListCollection[idx].ListTask = taskCollection[ctr];
            }

            if (remainingTaskpaginateUp.Image != null) remainingTaskpaginateUp.Image.Dispose();
            if (remainingTaskpaginateDown.Image != null) remainingTaskpaginateDown.Image.Dispose();

            isRemainingNextEnables = endRemainingIdx == taskCollection.Count - 1 ? false : true;
            isRemainingBackEnabled = startRemainingIdx == 0 ? false : true;

            remainingTaskpaginateDown.Image = isRemainingNextEnables ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
            remainingTaskpaginateUp.Image = isRemainingBackEnabled ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
        }

        private void ReorderDoneTask()
        {
            for (int ctr = startDoneIdx, idx = 0; ctr <= endDoneIdx; ctr++, idx++)
            {
                singleListCollection[idx].ListTask = taskCollection[ctr];
            }

            if (doneTaskPageBack.Image != null) doneTaskPageBack.Image.Dispose();
            if (doneTaskPageNext.Image != null) doneTaskPageNext.Image.Dispose();

            doneTaskPageNext.Image = isRemainingNextEnables ? UserInterface.Properties.Resources.Next : UserInterface.Properties.Resources.Next_Hover;
            doneTaskPageBack.Image = isRemainingBackEnabled ? UserInterface.Properties.Resources.Back : UserInterface.Properties.Resources.Back_Hover;
        }

        private void SetDoneAllignment()
        {
            for (int ctr = 0; ctr <= endDoneIdx; ctr++)
            {
                doneCards = new DoneCardTemplate()
                {
                    Width = 200,
                    Dock = DockStyle.Left,
                    SelectedTask = doneCollection[ctr]
                };
                doneTaskPanel.Controls.Add(doneCards);
                doneCardCollection.Add(doneCards);
            }

            foreach (var Iter in doneCardCollection)
            {
                Iter.BringToFront();
            }

            if (doneTaskPageBack.Image != null) doneTaskPageBack.Image.Dispose();
            if (doneTaskPageNext.Image != null) doneTaskPageNext.Image.Dispose();

            doneTaskPageNext.Image = isDoneNextEnabled ? UserInterface.Properties.Resources.Next : UserInterface.Properties.Resources.Next_Hover;
            doneTaskPageBack.Image = isDoneBackEnabled ? UserInterface.Properties.Resources.Back : UserInterface.Properties.Resources.Back_Hover;
        }

        private Dictionary<Color, int> FetchTaskCountsByStatus()
        {
            Dictionary<Color, int> result = new Dictionary<Color, int>();
            result.Add(ColorManager.FetchTaskStatusColor(TaskStatus.Done), doneCollection.Count);
            result.Add(ColorManager.FetchTaskStatusColor(TaskStatus.NotYetStarted), 0);
            result.Add(ColorManager.FetchTaskStatusColor(TaskStatus.OnProcess), 0);
            result.Add(ColorManager.FetchTaskStatusColor(TaskStatus.UnderReview), 0);
            result.Add(ColorManager.FetchTaskStatusColor(TaskStatus.Stuck), 0);
            if (taskCollection != null)
            {
                foreach (var Iter in taskCollection)
                {
                    result[ColorManager.FetchTaskStatusColor(Iter.StatusOfTask)]++;
                }
            }
            return result;
        }

        private Dictionary<Color, int> FetchTaskCountsByPriority()
        {
            Dictionary<Color, int> result = new Dictionary<Color, int>();
            result.Add(ColorManager.FetchTaskPriorityColor(Priority.Critical), 0);
            result.Add(ColorManager.FetchTaskPriorityColor(Priority.Hard), 0);
            result.Add(ColorManager.FetchTaskPriorityColor(Priority.Medium), 0);
            result.Add(ColorManager.FetchTaskPriorityColor(Priority.Easy), 0);

            if (taskCollection != null)
            {
                foreach (var Iter in taskCollection)
                {
                    result[ColorManager.FetchTaskPriorityColor(Iter.TaskPriority)]++;
                }
            }

            if (doneCardCollection != null)
            {
                foreach (var Iter in doneCollection)
                {
                    result[ColorManager.FetchTaskPriorityColor(Iter.TaskPriority)]++;
                }
            }

            return result;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }
    }
}
