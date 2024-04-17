﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Home_Page.Team_Lead.Report;
using TeamTracker;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media;

namespace UserInterface.Home_Page.Team_Member
{
    public partial class TeamMemberReportContent : UserControl
    {
        public TeamMemberReportContent()
        {
            InitializeComponent();
        }

        public bool isOpened = false;
        private int month, year, priority;
        private List<System.Drawing.Color> colorList = new List<System.Drawing.Color>
        {
            System.Drawing.Color.FromArgb(3, 4, 94), System.Drawing.Color.FromArgb(2, 62, 138), System.Drawing.Color.FromArgb(0, 119, 182), System.Drawing.Color.FromArgb(0, 150, 199), System.Drawing.Color.FromArgb(0, 180, 216),System.Drawing.Color.FromArgb(72, 202, 228)
        };
        private int colorIndex = 0;
        private FilterForm form;
        private Random rnd = new Random();


        public int Month
        {
            get { return month; }
            set
            {
                if (value != 0)
                {
                    month = value;
                    SetReport();
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value != 0)
                {
                    year = value;
                    SetReport();
                }
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void TablePanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(221, 230, 237));
            e.Graphics.DrawLine(pen, new Point(tableLayoutPanel4.Width / 20, tableLayoutPanel4.Height / 2), new Point(tableLayoutPanel4.Width * 19 / 20, tableLayoutPanel4.Height / 2));
            pen.Dispose();
        }

        private void OnFilterClick(object sender, EventArgs e)
        {
            if (form != null && !form.IsDisposed)
            {
                form.Dispose();
                form.Close();
            }

            form = new FilterForm();
            form.Month = month; form.Year = year; form.Priority = priority;
            form.Location = filterPicBox.PointToScreen(new Point(-225, 0));
            form.Filter += OnFiltered;
            form.Show();
        }

        private void OnFiltered(int month, int year, int priority)
        {
            Month = month; Year = year; Priority = priority;
        }

        private void SetReport()
        {
            if (isOpened)
            {
                totalTaskCount.Text = TaskManager.FilterTaskCount(month, year, priority).ToString();
                totalmilestoneCount.Text = MilestoneManager.FilterMilestoneCount(month, year).ToString();
                Dictionary<string, Dictionary<DateTime, int>> result = TaskManager.FilterTaskCountByDate(month, year);

                cartesianChart1.Series.Clear();
                cartesianChart1.AxisX.Clear();

                foreach (var employeeData in result)
                {
                    var lineSeries = new LineSeries
                    {
                        Title = employeeData.Key,
                        Values = new ChartValues<int>(employeeData.Value.OrderBy(kv => kv.Key).Select(kv => kv.Value)),
                        Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorList[colorIndex].A, colorList[colorIndex].R, colorList[colorIndex].G, colorList[colorIndex].B)),
                    };

                    cartesianChart1.Series.Add(lineSeries);
                }

                IList<string> labels = new List<string>();
                foreach (var employeeData in result)
                {
                    foreach (var Iter in employeeData.Value)
                    {
                        labels.Add(Iter.Key.ToShortDateString());
                    }
                }

                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Date",
                    Labels = labels // Add your values here
                });

            }
        }

    }
}