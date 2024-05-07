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
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media;
using UserInterface.ViewPage;
using System.Runtime.ConstrainedExecution;

namespace UserInterface.Task
{
    public partial class MilestoneSwitch : UserControl
    {
        public event EventHandler ResetForm;
        private TransparentForm transparentForm;
        public MilestoneSwitch()
        {
            InitializeComponent();
        }

        private string milestoneName;
        private int colorIndex = 0;
        private List<System.Drawing.Color> colorList;

        public void InitializePage()
        {
            colorList = ColorManager.ColorFadingOut;
            colorIndex = 2;
            if (MilestoneManager.IsCurrentMilestoneIsLastMilestone())
                switchMilestoneButton.Text = "Deploy";

            milestoneName = MilestoneManager.CurrentMilestone.MileStoneName;

            Dictionary<string, int> result1 = TaskManager.FilterTeamMemberTaskCountByMilestone(MilestoneManager.CurrentMilestone.MileStoneID);

            int total = 0;
            foreach (var Iter in result1)
            {
                total += Iter.Value;
            }
            
            if (total != 0)
            {
                pieChart1.Visible = true;
                SeriesCollection seriesCollection = new SeriesCollection();
                foreach (var Iter in result1)
                {
                    seriesCollection.Add(new PieSeries { Title = Iter.Key, Values = new ChartValues<double> { Iter.Value }, Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorList[colorIndex].A, colorList[colorIndex].R, colorList[colorIndex].G, colorList[colorIndex].B)) });
                    colorIndex = (colorIndex + 2) % colorList.Count;
                }
                pieChart1.Series = seriesCollection;
            }
            else
            {
                pieChart1.Visible = false;
            }
            panelBase.Invalidate();
        }

        private void OnMilestonePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Point[] points =
            {
                new Point(20, 20),
                new Point( 50,panelBase.Height/2),
                new Point(20,panelBase.Height-20),
                new Point(panelBase.Width-50, panelBase.Height-20),
                new Point(panelBase.Width-10, panelBase.Height/2),
                new Point(panelBase.Width-50, 20)
            };

            e.Graphics.FillPolygon(new SolidBrush(System.Drawing.Color.FromArgb(39, 55, 77)), points);
            StringFormat SFormat = new StringFormat();
            SFormat.Alignment = SFormat.LineAlignment = StringAlignment.Center;
            System.Drawing.Brush brush = new SolidBrush(System.Drawing.Color.FromArgb(221, 230, 237));
            Font f = new Font(new System.Drawing.FontFamily("Ebrima"), 12, FontStyle.Bold);
            e.Graphics.DrawString(milestoneName, f, brush, panelBase.ClientRectangle, SFormat);
            brush.Dispose();
            f.Dispose();
        }

        private void OnSwitchMilestone(object sender, EventArgs e)
        {
            if (MilestoneManager.IsAllTaskCompletedInCurrentMilestone())
            {
                if (MilestoneManager.IsCurrentMilestoneIsLastMilestone())
                {
                    WarningForm form1 = new WarningForm();
                    form1.Content = "All Milestones Have Been Completed. Do you want to Deploy your Project?";
                    form1.WarningStatus += OnDeployWarningStatusSelected;

                    transparentForm = new TransparentForm();
                    transparentForm.Show();
                    transparentForm.ShowForm(form1);
                }
                else
                {
                    WarningForm form2 = new WarningForm();
                    form2.Content = "Are you sure, you want move to Next Milestone?";
                    form2.WarningStatus += OnWarningStatusSelected;

                    transparentForm = new TransparentForm();
                    transparentForm.Show();
                    transparentForm.ShowForm(form2);
                }
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Warning", "Not All are Completed under this Milestone");
            }
        }

        private void OnWarningStatusSelected(object sender, bool e)
        {
            (sender as WarningForm).Dispose();
            (sender as WarningForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (e)
            {
                MilestoneManager.SwitchToNextMilestone();
                if (MilestoneManager.IsCurrentMilestoneIsLastMilestone())
                    switchMilestoneButton.Text = "Deploy";

                ResetForm?.Invoke(this, EventArgs.Empty);
                //InitializePage();
            }
        }

        private void OnDeployWarningStatusSelected(object sender, bool e)
        {
            (sender as WarningForm).Dispose();
            (sender as WarningForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (e)
            {
                DeployForm form = new DeployForm();
                form.DoneClick += OnSourceCodeSubmission;

                transparentForm = new TransparentForm();
                transparentForm.Show();
                transparentForm.ShowForm(form);
            }
        }

        private void OnSourceCodeSubmission(object sender, VersionSourceCode e)
        {
            (sender as DeployForm).Dispose();
            (sender as DeployForm).Close();
            transparentForm.Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (e != null)
            {
                MilestoneManager.ModifyTaskDateBasedOnMilestone(MilestoneManager.CurrentMilestone.MileStoneID);
                MilestoneManager.CurrentMilestone.EndDate = DateTime.Now.Date;
                MilestoneManager.UpdateMilestone(MilestoneManager.CurrentMilestone, MilestoneStatus.Completed);
                MilestoneManager.CurrentMilestone = null;
                VersionManager.CurrentVersion = null;
                VersionManager.UpdateVersion(VersionManager.CurrentVersion, ProjectStatus.Deployment);
                DataHandler.AddVersionSourceCode(e);
                Visible = false;
            }
            //InitializePage();
        }
    }
}
