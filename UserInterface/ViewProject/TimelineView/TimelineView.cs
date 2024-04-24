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
using UserInterface.ViewProject.TimelineView.Controls;
using System.Drawing.Drawing2D;

namespace UserInterface.ViewProject.TimelineView
{
    public partial class TimelineView : UserControl
    {
        private bool upEnable, downEnable;
        private int startIdx, endIdx = 0, selectedIdx = 0;
        private VerticalLabel prevControl;
        private Projects currentProject;
        private ProjectVersion currentVersion;
        private List<VerticalLabel> projectViewControlCollection;
        private List<Projects> projectCollection;
        private List<Milestone> milestoneCollection;
        private List<Color> colorCollection;
        private int projectViewCount = 0;

        public TimelineView()
        {
            InitializeComponent();
        }

        public List<Projects> ProjectCollection
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    ucNotFound1.Visible = false;
                    panel1.Visible = true;

                    if (projectDisplayPanel.Controls != null)
                        projectDisplayPanel.Controls.Clear();

                    if (milestoneLabelPanel.Controls != null)
                        milestoneLabelPanel.Controls.Clear();

                    projectCollection = value;
                    projectViewCount = value.Count >= 5 ? 5 : value.Count;
                    upEnable = false;
                    downEnable = value.Count > 5 ? true : false;
                    startIdx = 0;
                    endIdx = projectViewCount - 1;

                    if (projectUpBox.Image != null) projectUpBox.Image.Dispose();
                    if (projectDownBox.Image != null) projectDownBox.Image.Dispose();

                    projectUpBox.Image = upEnable ? UserInterface.Properties.Resources.Up_Dark_Blue : UserInterface.Properties.Resources.Up_Medium_Blue;
                    projectDownBox.Image = downEnable ? UserInterface.Properties.Resources.Down_Dark_Blue : UserInterface.Properties.Resources.Down_Medium_Blue;

                    InitializeProjectsForTimeline();
                }
                else
                {
                    ucNotFound1.Visible = true;
                    panel1.Visible = false;
                }
            }
        }

        

        private void InitializeProjectsForTimeline()
        {
            projectViewControlCollection = new List<VerticalLabel>();
            VerticalLabel control;
            for(int ctr=0, idx = 0; ctr<projectViewCount; ctr++)
            {
                control = new VerticalLabel()
                {
                    Dock = DockStyle.Top,
                    Height = 175,
                    Project = projectCollection[ctr],
                    TextColor = ColorManager.ColorFadingOut[idx % 20]
                };
                idx = idx + 4;
                control.IsClicked = false;
                if (ctr == 0)
                {
                    currentProject = projectCollection[ctr];
                    currentVersion = VersionManager.FetchProjectLatestVersion(projectCollection[ctr].ProjectID);
                    milestoneCollection = MilestoneManager.FetchMilestones(currentVersion.VersionID);
                    StoreColor();
                    InitializeMilestoneLegendCollection();
                    timelinePaginate1.Colors = colorCollection;
                    timelinePaginate1.Version = currentVersion;
                    versionNames.Text = currentVersion.VersionName;
                    prevControl = control;
                    prevControl.IsClicked = true;
                }
                control.ProjectSelected += OnProjectSelected;
                projectDisplayPanel.Controls.Add(control);
                projectViewControlCollection.Add(control);
            }
            foreach (var Iter in projectViewControlCollection)
            {
                Iter.BringToFront();
            }
        }

        private void projectDownClick(object sender, EventArgs e)
        {
            if(downEnable)
            {
                selectedIdx--;
                startIdx++;
                endIdx++;
                ProjectPaginate();
            }
        }

        private void VersionNamesClick(object sender, EventArgs e)
        {
            VersionViewForm form = new VersionViewForm();
            form.Location = versionNames.PointToScreen(new Point(0, versionNames.Height));
            form.VersionCollection = VersionManager.FetchInvolvedVersion(currentProject, EmployeeManager.CurrentEmployee);
            form.VersionSelected += OnVersionSelected;
            form.Show();
        }

        private void OnVersionSelected(object sender, ProjectVersion e)
        {
            timelinePaginate1.Version = currentVersion = e;
            versionNames.Text = currentVersion.VersionName;

            if (milestoneLabelPanel.Controls != null)
                milestoneLabelPanel.Controls.Clear();

            milestoneCollection = MilestoneManager.FetchMilestones(currentVersion.VersionID);
            StoreColor();
            InitializeMilestoneLegendCollection();
            timelinePaginate1.Colors = colorCollection;
            timelinePaginate1.Version = currentVersion;
        }

        private void projectUpClick(object sender, EventArgs e)
        {
            if (upEnable)
            {
                selectedIdx++;
                startIdx--;
                endIdx--;
                ProjectPaginate();
            }
        }

        private void OnProjectSelected(object sender, Projects e)
        {
            if (prevControl != null)
            {
                prevControl.IsClicked = false;
            }
            currentVersion = VersionManager.FetchProjectLatestVersion(e.ProjectID);
            versionNames.Text = currentVersion.VersionName;
            currentProject = (sender as VerticalLabel).Project;

            if (milestoneLabelPanel.Controls != null)
                milestoneLabelPanel.Controls.Clear();

            milestoneCollection = MilestoneManager.FetchMilestones(currentVersion.VersionID);
            StoreColor();
            InitializeMilestoneLegendCollection();
            timelinePaginate1.Colors = colorCollection;
            timelinePaginate1.Version = currentVersion;

            selectedIdx = projectViewControlCollection.IndexOf((sender as VerticalLabel));
            ProjectPaginate();
            prevControl = sender as VerticalLabel;
            prevControl.IsClicked = true;
        }

        private void OnVersionSwitchPanelPaint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, panel7.Width - 1, panel7.Height - 1));
            e.Graphics.DrawLine(pen, new Point(panel7.Width - 33, 0), new Point(panel7.Width - 33, panel7.Height - 1));
            pen.Dispose();
        }

        private void OnVersionMouseEnter(object sender, EventArgs e)
        {
            versionNames.BackColor = Color.FromArgb(221, 230, 237);
            panel4.Invalidate();
        }

        private void OnVersionMouseLeave(object sender, EventArgs e)
        {
            versionNames.BackColor = Color.FromArgb(231, 240, 250);
            panel4.Invalidate();
        }

        private void OnProjectPaginateMouseEnter(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Image != null) (sender as PictureBox).Image.Dispose();

            if ((sender as Control).Name == "remainingTaskpaginateUp")
            {
                projectUpBox.Image = UserInterface.Properties.Resources.Up_Dark_Blue_Hover;
            }
            else
            {
                projectDownBox.Image = UserInterface.Properties.Resources.Down_Dark_Blue_Hover;
            }
        }

        private void OnProjectPaginateMouseLeave(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Image != null) (sender as PictureBox).Image.Dispose();

            if ((sender as Control).Name == "remainingTaskpaginateUp")
            {
                projectUpBox.Image = upEnable ? UserInterface.Properties.Resources.Up_Dark_Blue : UserInterface.Properties.Resources.Up_Medium_Blue;
            }
            else
            {
                projectDownBox.Image = downEnable ? UserInterface.Properties.Resources.Down_Dark_Blue : UserInterface.Properties.Resources.Down_Medium_Blue;
            }
        }

        private void ProjectPaginate()
        {
            for (int ctr = startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
            {
                if(selectedIdx == idx)
                {
                    projectViewControlCollection[idx].IsClicked = true;
                }
                else
                {
                    projectViewControlCollection[idx].IsClicked = false;
                }
                projectViewControlCollection[idx].Project = projectCollection[ctr];
            }

            upEnable = startIdx == 0 ? false : true;
            downEnable = endIdx == projectCollection.Count - 1 ? false : true;

            if (projectUpBox.Image != null) projectUpBox.Image.Dispose();
            if (projectDownBox.Image != null) projectDownBox.Image.Dispose();

            projectUpBox.Image = upEnable ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
            projectDownBox.Image = downEnable ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
        }

        private void StoreColor()
        {
            colorCollection = new List<Color>();
            int ctr = 0;
            foreach (var Iter in milestoneCollection)
            {
                colorCollection.Add(ColorManager.MilestoneColorFadingOut[ctr%20]);
                ctr++;
            }
        }

        private void InitializeMilestoneLegendCollection()
        {
            TimelineMilestoneLabel label;
            for (int ctr=0; ctr < milestoneCollection.Count; ctr++)
            {
                label = new TimelineMilestoneLabel()
                {
                    Dock = DockStyle.Left,
                    MilestoneColor = colorCollection[ctr],
                    MilestoneName = milestoneCollection[ctr].MileStoneName,
                    Width = 120
                };
                milestoneLabelPanel.Controls.Add(label);
            }

            foreach(TimelineMilestoneLabel Iter in milestoneLabelPanel.Controls)
            {
                Iter.BringToFront();
            }
        }
    }
}
