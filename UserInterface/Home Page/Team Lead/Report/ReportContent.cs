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
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface.Home_Page.Team_Lead.Report
{
    public partial class ReportContent : UserControl
    {
        public int Month
        {
            get { return month; }
            set
            {
                month = value;
                SetReport();
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                year = value;
                SetReport();
            }
        }
        public int Priority
        {
            get { return priority; }
            set
            {
                priority = value;
                SetReport();
            }
        }

        private int month = DateTime.Today.Month, year = DateTime.Today.Year, priority = -1;

        public ReportContent()
        {
            InitializeComponent();
        }

        private void TablePanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.FromArgb(221, 230, 237));
            e.Graphics.DrawLine(pen, new Point(tableLayoutPanel4.Width / 20, tableLayoutPanel4.Height / 2), new Point(tableLayoutPanel4.Width * 19 / 20, tableLayoutPanel4.Height / 2));
            pen.Dispose();
        }

        private void OnFilterClick(object sender, EventArgs e)
        {
            FilterForm form = new FilterForm();
            form.Month = month; form.Year = year; form.Priority = priority;
            form.Location = filterPicBox.PointToScreen(new Point(-225, 0));
            form.Filter += OnFiltered;
            form.Show();
        }

        private void OnFiltered(int month, int year, int priority)
        {
            Month = month;  Year = year; Priority = priority;
        }

        private void SetReport()
        {
            totalTaskCount.Text = TaskManager.FilterTaskCount(month, year, priority).ToString();
            totalmilestoneCount.Text = MilestoneManager.FilterMilestoneCount(month, year).ToString();
            Dictionary<string, int> result1 = TaskManager.FilterTeamMemberTaskCount(month, year);
            Dictionary<string, Dictionary<DateTime, int>> result2 = TaskManager.FilterTaskCountByDate(month, year);

            int total = 0;
            foreach (var Iter in result1) total += Iter.Value;
            teammatesTaskCount.Text = total.ToString();

            donutChart.Series[0] = new Series();
            donutChart.Series[0].ChartType = SeriesChartType.Doughnut;
            foreach(var Iter in result1)
            {
                donutChart.Series[0].Points.AddXY(Iter.Key,Iter.Value);
            }

            donutChart.Legends["Legend1"].ForeColor = Color.Black;

            barchart.Series.Clear();

            int ctr = 0;
            foreach(var Iter in result2)
            {
                Series series = new Series();
                series.Name = Iter.Key;
                series.ChartType = SeriesChartType.Line;
                series.MarkerSize = 5;

                foreach(var seriesIter in Iter.Value)
                {
                    series.Points.AddXY(seriesIter.Key, seriesIter.Value);
                }
                barchart.Series.Add(series);
            }

            barchart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            barchart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }
    }
}
