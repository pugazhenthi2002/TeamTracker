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
using LiveCharts;

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
                DoneCardControlsClear();
                doneCollection = value;
                if (value != null && value.Count > 0)
                {
                    panel6.Parent.Parent.Visible = true;
                    panel6.Visible = true;
                    doneTaskPanel.Visible = backBtn.Visible = nextBtn.Visible = true;
                    ucNotFound1.Visible = false;
                    doneCardCollection = new List<DoneCardTemplate>();
                    startDoneIdx = 0; isBackEnable = false;
                    endDoneIdx = value.Count > 5 ? 4 : value.Count-1;
                    isNextEnable = value.Count > 5 ? true : false;
                    SetDoneAllignment();
                }
                else
                {
                    ucNotFound1.Visible = true;
                    doneTaskPanel.Visible = backBtn.Visible = nextBtn.Visible = false;
                }
            }
        }
        public List<Task> RemainingTaskCollection
        {
            set
            {
                SingleListControlPanelControlsClear();
                if (value != null && value.Count > 0)
                {
                    panel6.Parent.Parent.Visible = true;
                    panel6.Visible = true;
                    singleListControlPanel.Visible = true;
                    singleListCollection = new List<SingleList>();
                    taskCollection = value;
                    startRemainingIdx = 0;
                    isUpEnable = false;
                    endRemainingIdx = value.Count > 10 ? 9 : value.Count - 1;
                    isDownEnable = value.Count > 10 ? true : false;
                    SetRemainingTaskAllignment();
                }
                else
                {
                    singleListControlPanel.Visible = false;
                }
            }
        }

        private bool isUpEnable, isDownEnable, isBackEnable, isNextEnable;
        private int startRemainingIdx, endRemainingIdx, startDoneIdx, endDoneIdx;
        private DoneCardTemplate doneCards;
        private SingleList listTemplate;
        private List<SingleList> singleListCollection;
        private List<DoneCardTemplate> doneCardCollection;
        private List<Task> taskCollection;
        private List<Task> doneCollection;

        public void InitializePage()
        {
            SuspendLayout();
            projectDateLabel.Text = VersionManager.CurrentVersion.StartDate.ToShortDateString() + "  -  " + VersionManager.CurrentVersion.EndDate.ToShortDateString();
            projectNameLabel.Text = VersionManager.FetchProjectName(VersionManager.CurrentVersion.VersionID) + " " + VersionManager.CurrentVersion.VersionName;
            
            if (singleListControlPanel.Visible || doneTaskPanel.Visible)
            {
                Dictionary<TaskStatus, int> result1 = new Dictionary<TaskStatus, int>();
                result1.Add(TaskStatus.Done, doneCollection.Count);
                result1.Add(TaskStatus.NotYetStarted, 0);
                result1.Add(TaskStatus.OnProcess, 0);
                result1.Add(TaskStatus.UnderReview, 0);
                result1.Add(TaskStatus.Stuck, 0);

                Dictionary<Priority, int> result2 = new Dictionary<Priority, int>();
                result2.Add(Priority.Critical, 0);
                result2.Add(Priority.Hard, 0);
                result2.Add(Priority.Medium, 0);
                result2.Add(Priority.Easy, 0);

                if (doneCardCollection != null)
                {
                    foreach (var Iter in doneCollection)
                    {
                        result2[Iter.TaskPriority]++;
                    }
                }

                if (taskCollection != null)
                {
                    foreach (var Iter in taskCollection)
                    {
                        result2[Iter.TaskPriority]++;
                        result1[Iter.StatusOfTask]++;
                    }
                }

                pieChart1.Visible = true;
                SeriesCollection seriesCollection = new SeriesCollection();
                foreach (var Iter in result1)
                {
                    seriesCollection.Add(new LiveCharts.Wpf.PieSeries { Title = Iter.Key.ToString(), Values = new ChartValues<double> { Iter.Value }, Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(ThemeManager.GetTaskStatusColor(Iter.Key).A, ThemeManager.GetTaskStatusColor(Iter.Key).R, ThemeManager.GetTaskStatusColor(Iter.Key).G, ThemeManager.GetTaskStatusColor(Iter.Key).B)) });
                }
                pieChart1.InnerRadius = 60;
                pieChart1.Series = seriesCollection;

                pieChart2.Visible = true;
                seriesCollection = new SeriesCollection();
                foreach (var Iter in result2)
                {
                    seriesCollection.Add(new LiveCharts.Wpf.PieSeries { Title = Iter.Key.ToString(), Values = new ChartValues<double> { Iter.Value }, Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(ThemeManager.GetTaskPriorityColor(Iter.Key).A, ThemeManager.GetTaskPriorityColor(Iter.Key).R, ThemeManager.GetTaskPriorityColor(Iter.Key).G, ThemeManager.GetTaskPriorityColor(Iter.Key).B)) });
                }
                pieChart2.InnerRadius = 60;
                pieChart2.Series = seriesCollection;
            }
            else
            {
                pieChart1.Visible = pieChart2.Visible = false;
            }
            ResumeLayout();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            projectNameLabel.ForeColor = projectDateLabel.ForeColor = ThemeManager.GetTextColor(BackColor);
            pieChart1.BackColor = pieChart2.BackColor = ucNotFound1.BackColor = ucNotFound2.BackColor = panel3.BackColor = panel7.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label1.ForeColor = label2.ForeColor = label8.ForeColor = ThemeManager.GetTextColor(panel3.BackColor);

            for (int ctr=0; ctr < 6; ctr++)
            {
                (taskTableLayoutPanel.GetControlFromPosition(ctr, 0) as Control).BackColor = ThemeManager.CurrentTheme.MilestoneFadingOutColorCollection[ctr];
                (taskTableLayoutPanel.GetControlFromPosition(ctr, 0) as Control).ForeColor = ThemeManager.GetTextColor((taskTableLayoutPanel.GetControlFromPosition(ctr, 0) as Control).BackColor);
            }

            upPicBox.Image?.Dispose();
            downPicBox.Image?.Dispose();
            backBtn.Image?.Dispose(); nextBtn.Image?.Dispose();

            ResetDoneButton();

            ResetRemainingButtons();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;

            DoneCardControlsClear();
            SingleListControlPanelControlsClear();
        }

        private void OnPaginateDown(object sender, EventArgs e)
        {
            if (isDownEnable)
            {
                startRemainingIdx++;
                endRemainingIdx++;
                ReorderRemainingTask();
            }
        }

        private void OnDonePaginateBack(object sender, EventArgs e)
        {
            if (isBackEnable)
            {
                startDoneIdx--;
                endDoneIdx--;
                ReorderDoneTask();
            }
        }

        private void OnDonePaginateNext(object sender, EventArgs e)
        {
            if (isNextEnable)
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
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();

            if(doneCollection != null && doneCollection.Count > 0)
            {
                InitializePage();
            }
        }

        private void OnPaginateUp(object sender, EventArgs e)
        {
            if (isUpEnable)
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

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            ResetRemainingButtons();
        }

        private void OnReset(object sender, EventArgs e)
        {
            InitializePage();
        }

        private void OnEdgePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(0, 0), new Point(0, (sender as Control).Height));
            e.Graphics.DrawLine(border, new Point(0, (sender as Control).Height/2), new Point((sender as Control).Width, (sender as Control).Height/2));
            border.Dispose();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            if (sender is Label)
                rec = new Rectangle(0, 0, panel3.Width - 2, panel2.Height - 2);

            Pen border1 = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 20));
            border1.Dispose();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "backBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = UserInterface.Properties.Resources.Cold_Left_Dark_Hover;
                }
                else
                {
                    backBtn.Image = UserInterface.Properties.Resources.Heat_Left_Dark_Hover;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = UserInterface.Properties.Resources.Cold_Right_Dark_Hover;
                }
                else
                {
                    nextBtn.Image = UserInterface.Properties.Resources.Heat_Right_Dark_Hover;
                }
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "backBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Dark : UserInterface.Properties.Resources.Cold_Left_Light;
                }
                else
                {
                    backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Heat_Left_Dark : UserInterface.Properties.Resources.Heat_Left_Light;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Dark : UserInterface.Properties.Resources.Cold_Right_Light;
                }
                else
                {
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Dark : UserInterface.Properties.Resources.Heat_Right_Light;
                }
            }
        }

        private void OnListPaginateMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as PictureBox).Name == "upPicBox")
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Up_Dark_Hover : UserInterface.Properties.Resources.Heat_Up_Dark_Hover;
            }
            else
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Down_Dark_Hover : UserInterface.Properties.Resources.Heat_Down_Dark_Hover;
            }
        }

        private void OnListPaginateMouseLeave(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Name == "upPicBox")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.Cold_Up_Dark : UserInterface.Properties.Resources.Cold_Up_Light;
                }
                else
                {
                    upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.Heat_Up_Dark : UserInterface.Properties.Resources.Heat_Up_Light;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.Cold_Down_Dark : UserInterface.Properties.Resources.Cold_Down_Light;
                }
                else
                {
                    downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.Heat_Down_Dark : UserInterface.Properties.Resources.Heat_Down_Light;
                }
            }
        }

        private void ReorderRemainingTask()
        {
            for (int ctr = startRemainingIdx, idx = 0; ctr <= endRemainingIdx; ctr++, idx++)
            {
                singleListCollection[idx].ListTask = taskCollection[ctr];
            }

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            isDownEnable = endRemainingIdx == taskCollection.Count - 1 ? false : true;
            isUpEnable = startRemainingIdx == 0 ? false : true;

            ResetRemainingButtons();
        }

        private void ReorderDoneTask()
        {
            for (int ctr = startDoneIdx, idx = 0; ctr <= endDoneIdx; ctr++, idx++)
            {
                doneCardCollection[idx].SelectedTask = doneCollection[ctr];
            }

            isBackEnable = startDoneIdx == 0 ? false : true;
            isNextEnable = endDoneIdx == doneCollection.Count - 1 ? false : true;

            if (backBtn.Image != null) backBtn.Image.Dispose();
            if (nextBtn.Image != null) nextBtn.Image.Dispose();

            ResetDoneButton();
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

            isBackEnable = startDoneIdx == 0 ? false : true;
            isNextEnable = endDoneIdx == doneCollection.Count - 1 ? false : true;

            if (backBtn.Image != null) backBtn.Image.Dispose();
            if (nextBtn.Image != null) nextBtn.Image.Dispose();

            ResetDoneButton();
        }

        private Dictionary<Color, int> FetchTaskCountsByStatus()
        {
            Dictionary<Color, int> result = new Dictionary<Color, int>();
            result.Add(ThemeManager.GetTaskStatusColor(TaskStatus.Done), doneCollection.Count);
            result.Add(ThemeManager.GetTaskStatusColor(TaskStatus.NotYetStarted), 0);
            result.Add(ThemeManager.GetTaskStatusColor(TaskStatus.OnProcess), 0);
            result.Add(ThemeManager.GetTaskStatusColor(TaskStatus.UnderReview), 0);
            result.Add(ThemeManager.GetTaskStatusColor(TaskStatus.Stuck), 0);
            if (taskCollection != null)
            {
                foreach (var Iter in taskCollection)
                {
                    result[ThemeManager.GetTaskStatusColor(Iter.StatusOfTask)]++;
                }
            }
            return result;
        }

        private Dictionary<Color, int> FetchTaskCountsByPriority()
        {
            Dictionary<Color, int> result = new Dictionary<Color, int>();
            result.Add(ThemeManager.GetTaskPriorityColor(Priority.Critical), 0);
            result.Add(ThemeManager.GetTaskPriorityColor(Priority.Hard), 0);
            result.Add(ThemeManager.GetTaskPriorityColor(Priority.Medium), 0);
            result.Add(ThemeManager.GetTaskPriorityColor(Priority.Easy), 0);

            if (taskCollection != null)
            {
                foreach (var Iter in taskCollection)
                {
                    result[ThemeManager.GetTaskPriorityColor(Iter.TaskPriority)]++;
                }
            }

            if (doneCardCollection != null)
            {
                foreach (var Iter in doneCollection)
                {
                    result[ThemeManager.GetTaskPriorityColor(Iter.TaskPriority)]++;
                }
            }

            return result;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void ResetRemainingButtons()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.Cold_Up_Dark : UserInterface.Properties.Resources.Cold_Up_Light;
                downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.Cold_Down_Dark : UserInterface.Properties.Resources.Cold_Down_Light;
            }
            else
            {
                upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.Heat_Up_Dark : UserInterface.Properties.Resources.Heat_Up_Light;
                downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.Heat_Down_Dark : UserInterface.Properties.Resources.Heat_Down_Light;
            }
        }

        private void ResetDoneButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Dark : UserInterface.Properties.Resources.Cold_Left_Medium;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Dark : UserInterface.Properties.Resources.Cold_Right_Medium;
            }
            else
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Heat_Left_Dark : UserInterface.Properties.Resources.Heat_Left_Medium;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Dark : UserInterface.Properties.Resources.Heat_Right_Medium;
            }
        }

        private void SingleListControlPanelControlsClear()
        {
            for (int ctr = 0; ctr < singleListControlPanel.Controls.Count; ctr++)
            {
                (singleListControlPanel.Controls[ctr] as SingleList).Reset -= OnReset;
                (singleListControlPanel.Controls[ctr] as SingleList).Dispose();
                ctr--;
            }
        }

        private void DoneCardControlsClear()
        {
            for (int ctr = 0; ctr < doneTaskPanel.Controls.Count; ctr++)
            {
                (doneTaskPanel.Controls[ctr] as DoneCardTemplate).Dispose();
                ctr--;
            }
        }
    }
}
