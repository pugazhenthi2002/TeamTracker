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
                IsBackEnable = false;
                IsNextEnable = true;

                if (backNavigatePicBox.Image != null) backNavigatePicBox.Image.Dispose();
                if (nextNavPicBox.Image != null) nextNavPicBox.Image.Dispose();

                backNavigatePicBox.Image = IsBackEnable ? Properties.Resources.Left_Dark_Blue : Properties.Resources.Left_Medium_Blue;
                nextNavPicBox.Image = IsNextEnable ? Properties.Resources.Right_Dark_Blue : Properties.Resources.Right_Medium_Blue;
            }
        }
        
        public OverviewMilestoneContent()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        public new void Dispose()
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
            if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
            if (pictureBox4.Image != null) pictureBox4.Image.Dispose();
            if (backNavigatePicBox.Image != null) backNavigatePicBox.Image.Dispose();
            if (nextNavPicBox.Image != null) nextNavPicBox.Image.Dispose();

            completedTaskLabel.Dispose();   donePanel.Dispose();    currentPanel.Dispose(); delayPanel.Dispose();
            dueTaskLabel.Dispose(); dueTaskTitleLabel.Dispose();    incompleteTaskLabel.Dispose();  milestonePanel.Dispose();   milestoneView1.Dispose();
            notstartedPanel.Dispose();  pieChart1.Dispose();    taskCountLabel.Dispose();   pictureBox1.Dispose();  pictureBox2.Dispose();
            pictureBox3.Dispose();  pictureBox4.Dispose();  backNavigatePicBox.Dispose();   nextNavPicBox.Dispose();

            tableLayoutPanel1.Dispose();    tableLayoutPanel2.Dispose();    tableLayoutPanel3.Dispose();    tableLayoutPanel4.Dispose();    tableLayoutPanel5.Dispose();    
            tableLayoutPanel6.Dispose(); tableLayoutPanel7.Dispose();   label1.Dispose();   label2.Dispose();   label3.Dispose();   label4.Dispose(); label5.Dispose(); label6.Dispose();
            label7.Dispose();   label8.Dispose();
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();   panel4.Dispose();   panel5.Dispose();
            panel6.Dispose();   panel7.Dispose();   panel8.Dispose();   panel9.Dispose();   panel10.Dispose();
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
            if (IsBackEnable)
                flag = milestoneView1.ChangeMilestoneUI(false);

            if (flag < 0) IsBackEnable = false;
            else { IsBackEnable = true; }
            IsNextEnable = true;

            if (backNavigatePicBox.Image != null) backNavigatePicBox.Image.Dispose();
            if (nextNavPicBox.Image != null) nextNavPicBox.Image.Dispose();

            backNavigatePicBox.Image = IsBackEnable ? Properties.Resources.Left_Dark_Blue : Properties.Resources.Left_Medium_Blue;
            nextNavPicBox.Image = IsNextEnable ? Properties.Resources.Right_Dark_Blue : Properties.Resources.Right_Medium_Blue;
        }

        private void NextMilestoneClick(object sender, EventArgs e)
        {
            if (IsNextEnable)
                flag = milestoneView1.ChangeMilestoneUI(true);

            if (flag > 0) IsNextEnable = false;
            else { IsNextEnable = true; }
            IsBackEnable = true;

            backNavigatePicBox.Image = IsBackEnable ? Properties.Resources.Left_Dark_Blue : Properties.Resources.Left_Medium_Blue;
            nextNavPicBox.Image = IsNextEnable ? Properties.Resources.Right_Dark_Blue : Properties.Resources.Right_Medium_Blue;
        }

        private void InitializeOverview()
        {
            List<int> result = TaskManager.FetchTaskCount(version.VersionID);

            taskCountLabel.Text = result[0].ToString();
            completedTaskLabel.Text = result[1].ToString();
            dueTaskLabel.Text = result[2].ToString();
            incompleteTaskLabel.Text = result[3].ToString();

            milestoneView1.MilestoneCollection = MilestoneManager.FetchMilestones(version.VersionID);

            flag = milestoneView1.ChangeMilestoneUI(true);

            if (flag > 0) IsNextEnable = false;
            else { IsNextEnable = IsBackEnable = true; }

            var colorList = ColorManager.ColorFadingOut;
            int colorIndex = 0, total = 0;
            Dictionary<TeamTracker.TaskStatus, int> result1 = TaskManager.FetchTaskCountByStatus(VersionManager.CurrentVersion.VersionID);

            foreach (var Iter in result1)
            {
                total+=Iter.Value;
            }

            if(total == 0)
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

        private void OnMouseEnter(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Hand;
            if (picBox.Name == "backNavigatePicBox")
            {
                picBox.Image = Properties.Resources.Left_Dark_Blue_Hover;
            }
            else
            {
                picBox.Image = Properties.Resources.Right_Dark_Blue_Hover;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Default;
            if (picBox.Name == "backNavigatePicBox")
            {
                picBox.Image = IsBackEnable ? Properties.Resources.Left_Dark_Blue : Properties.Resources.Left_Medium_Blue;
            }
            else
            {
                picBox.Image = IsNextEnable ? Properties.Resources.Right_Dark_Blue : Properties.Resources.Right_Medium_Blue;
            }
        }

        private void OnTablePanelPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(221, 230, 237), 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(pen, new Point(15, panel1.Height), new Point((sender as TableLayoutPanel).Width - 15, panel1.Height));
            pen.Dispose();
        }

        private void OnLegendPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Brush brush;
            if ((sender as Panel).Name == "donePanel") brush = new SolidBrush(System.Drawing.Color.FromArgb(3, 4, 94));
            else if ((sender as Panel).Name == "delayPanel") brush = new SolidBrush(System.Drawing.Color.FromArgb(0, 119, 182));
            else if ((sender as Panel).Name == "currentPanel") brush = new SolidBrush(System.Drawing.Color.FromArgb(0, 180, 216));
            else brush = new SolidBrush(System.Drawing.Color.FromArgb(144, 224, 239));

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, new Rectangle(0, 0, (sender as Panel).Width-2, (sender as Panel).Height-2));
            brush.Dispose();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(221, 230, 237));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            e.Graphics.DrawPath(pen, BorderGraphicsPath.GetRoundRectangle(rec, 10));
        }

        private void MilestoneDividerPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Pen border = new System.Drawing.Pen(System.Drawing.Color.FromArgb(39, 55, 77), 2);
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
        private bool IsBackEnable = false, IsNextEnable = true;
        private int flag;
    }
}
