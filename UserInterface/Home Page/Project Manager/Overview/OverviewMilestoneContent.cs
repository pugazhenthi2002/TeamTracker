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
using System.Runtime.InteropServices;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media;

namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class OverviewMilestoneContent : UserControl
    {
        public ProjectVersion Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
                if (value != null)
                    InitializeOverview();
                isBackEnable = false;
                isNextEnable = true;

                if (backBtn.Image != null) backBtn.Image.Dispose();
                if (nextBtn.Image != null) nextBtn.Image.Dispose();

                ResetButton();
            }
        }
        
        public OverviewMilestoneContent()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            if (version != null)
            {
                InitializePageColor();
                InitializeOverview();
            }
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
            if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
            if (pictureBox4.Image != null) pictureBox4.Image.Dispose();
            if (backBtn.Image != null) backBtn.Image.Dispose();
            if (nextBtn.Image != null) nextBtn.Image.Dispose();

            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void InitializePageColor()
        {
            pieChart1.BackColor = ucNotFound1.BackColor = panel5.BackColor = panel6.BackColor = panel7.BackColor = panel8.BackColor = panel9.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label2.ForeColor = label3.ForeColor = label8.ForeColor = dueTaskTitleLabel.ForeColor = ThemeManager.GetTextColor(panel5.BackColor);
            taskCountLabel.ForeColor = dueTaskLabel.ForeColor = completedTaskLabel.ForeColor = incompleteTaskLabel.ForeColor = ThemeManager.GetTextColor(panel5.BackColor);
            label1.ForeColor = label4.ForeColor = label5.ForeColor = label6.ForeColor = label7.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.SecondaryIII);

            pictureBox1.Image?.Dispose(); pictureBox2.Image?.Dispose(); pictureBox3.Image?.Dispose(); pictureBox4.Image?.Dispose();

            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Dark_Total_Task : Properties.Resources.Heat_Dark_Total_Task;
            pictureBox2.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Completed_Task : Properties.Resources.Heat_Completed_Task;
            pictureBox3.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Delay_Task : Properties.Resources.Heat_Delay_Task;
            pictureBox4.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Incomplete_Task : Properties.Resources.Heat_Incomplete_Task;

            backBtn.Image?.Dispose();
            nextBtn.Image?.Dispose();
            ResetButton();
        }

        private void OnResize(object sender, EventArgs e)
        {
            int topBottom = (milestonePanel.Height - 150)/2;
            milestonePanel.Padding = new Padding(0, topBottom, 0, topBottom);
            tableLayoutPanel3.Invalidate();
            tableLayoutPanel4.Invalidate();
            tableLayoutPanel5.Invalidate();
            tableLayoutPanel6.Invalidate();
            InitializeRoundedEdge();
        }

        private void BackMilestoneClick(object sender, EventArgs e)
        {
            if (isBackEnable)
                flag = milestoneView1.ChangeMilestoneUI(false);

            if (flag < 0) isBackEnable = false;
            else { isBackEnable = true; }
            isNextEnable = true;

            if (backBtn.Image != null) backBtn.Image.Dispose();
            if (nextBtn.Image != null) nextBtn.Image.Dispose();

            ResetButton();
        }

        private void NextMilestoneClick(object sender, EventArgs e)
        {
            if (isNextEnable)
                flag = milestoneView1.ChangeMilestoneUI(true);

            if (flag > 0) isNextEnable = false;
            else { isNextEnable = true; }
            isBackEnable = true;

            ResetButton();
        }

        private void InitializeOverview()
        {
            if (version != null)
            {
                List<int> result = TaskManager.FetchTaskCount(version.VersionID);

                taskCountLabel.Text = result[0].ToString();
                completedTaskLabel.Text = result[1].ToString();
                dueTaskLabel.Text = result[2].ToString();
                incompleteTaskLabel.Text = result[3].ToString();

                milestoneView1.MilestoneCollection = MilestoneManager.FetchMilestones(version.VersionID);

                flag = milestoneView1.ChangeMilestoneUI(true);
                milestoneView1.InitializePageColor();
                if (flag > 0) isNextEnable = false;
                else { isNextEnable = isBackEnable = true; }

                var colorList = ThemeManager.CurrentTheme.MilestoneFadingOutColorCollection;
                int colorIndex = 0, total = 0;
                Dictionary<TeamTracker.TaskStatus, int> result1 = TaskManager.FetchTaskCountByStatus(VersionManager.CurrentVersion.VersionID);

                foreach (var Iter in result1)
                {
                    total += Iter.Value;
                }

                if (total == 0)
                {
                    pieChart1.Visible = false;
                }

                SeriesCollection seriesCollection = new SeriesCollection();
                foreach (var Iter in result1)
                {
                    seriesCollection.Add(new PieSeries { Title = Iter.Key.ToString(), Values = new ChartValues<double> { Iter.Value }, Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorList[colorIndex].A, colorList[colorIndex].R, colorList[colorIndex].G, colorList[colorIndex].B)) });
                    colorIndex = (colorIndex + 2) % colorList.Count;
                }
                pieChart1.Series = seriesCollection;
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "BackBtn")
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
            if ((sender as Control).Name == "BackBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Dark : UserInterface.Properties.Resources.Cold_Left_Medium;
                }
                else
                {
                    backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Heat_Left_Dark : UserInterface.Properties.Resources.Heat_Left_Medium;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Dark : UserInterface.Properties.Resources.Cold_Right_Medium;
                }
                else
                {
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Dark : UserInterface.Properties.Resources.Heat_Right_Medium;
                }
            }
        }

        private void OnTablePanelPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(pen, new Point(15, panel1.Height), new Point((sender as TableLayoutPanel).Width - 15, panel1.Height));
            pen.Dispose();
        }

        private void OnLegendPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Brush brush;
            if ((sender as Panel).Name == "donePanel") brush = new SolidBrush(ThemeManager.CurrentTheme.MilestoneStatusColorCollection[MilestoneStatus.Completed]);
            else if ((sender as Panel).Name == "delayPanel") brush = new SolidBrush(ThemeManager.CurrentTheme.MilestoneStatusColorCollection[MilestoneStatus.Delay]);
            else if ((sender as Panel).Name == "currentPanel") brush = new SolidBrush(ThemeManager.CurrentTheme.MilestoneStatusColorCollection[MilestoneStatus.OnProcess]);
            else brush = new SolidBrush(ThemeManager.CurrentTheme.MilestoneStatusColorCollection[MilestoneStatus.Upcoming]);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, new Rectangle(0, 0, (sender as Panel).Width-2, (sender as Panel).Height-2));
            brush.Dispose();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(ThemeManager.CurrentTheme.SecondaryIII);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            e.Graphics.DrawPath(pen, BorderGraphicsPath.GetRoundRectangle(rec, 10));
        }

        private void MilestoneDividerPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Pen border = new System.Drawing.Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(0, 0), new Point((sender as Control).Width, 0));
            border.Dispose();
        }

        private void InitializeRoundedEdge()
        {
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, 20, 20));
        }

        private void ResetButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Light : UserInterface.Properties.Resources.Cold_Left_Medium;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Light : UserInterface.Properties.Resources.Cold_Right_Medium;
            }
            else
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Heat_Left_Light : UserInterface.Properties.Resources.Heat_Left_Medium;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Light : UserInterface.Properties.Resources.Heat_Right_Medium;
            }
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

        private ProjectVersion version;
        private bool isBackEnable = false, isNextEnable = true;
        private int flag;
    }
}
