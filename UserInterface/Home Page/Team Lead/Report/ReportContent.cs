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
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using System.Runtime.InteropServices;

namespace UserInterface.Home_Page.Team_Lead.Report
{
    public partial class ReportContent : UserControl
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
            tableLayoutPanel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width, tableLayoutPanel3.Height, 20, 20));
            tableLayoutPanel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel4.Width, tableLayoutPanel4.Height, 20, 20));
            tableLayoutPanel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel5.Width, tableLayoutPanel5.Height, 20, 20));
        }

        public bool isOpened = false;
        private int month, year, priority;
        private List<System.Drawing.Color> colorList;
        private int colorIndex = 0;
        private FilterForm form;
        private Random rnd = new Random();

        public ReportContent()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            colorList = ColorManager.ColorFadingOut;
            cartesianChart1.AxisX.Add(new Axis { Title = "Date" });
            cartesianChart1.AxisY.Add(new Axis { Title = "Task Solved" });
        }

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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void TablePanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(221, 230, 237));
            e.Graphics.DrawLine(pen, new Point(tableLayoutPanel4.Width / 20, tableLayoutPanel4.Height / 2), new Point(tableLayoutPanel4.Width * 19 / 20, tableLayoutPanel4.Height / 2));
            System.Drawing.Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            e.Graphics.DrawPath(pen, BorderGraphicsPath.GetRoundRectangle(rec, 10));
            pen.Dispose();
        }

        private void OnFilterClick(object sender, EventArgs e)
        {
            form = new FilterForm();
            form.Month = month; form.Year = year; form.Priority = priority;
            form.Location = filterPicBox.PointToScreen(new Point(-225, 0));
            form.Filter += OnFiltered;
            form.ShowDialog();
        }

        private void OnFiltered(int month, int year, int priority)
        {
            Month = month; Year = year; Priority = priority;
        }

        private void OnFilterMouseEnter(object sender, EventArgs e)
        {
            if(filterPicBox.Image != null)
                filterPicBox.Image.Dispose();

            filterPicBox.Image = Properties.Resources.Filter_Click;
            filterPicBox.BackColor = System.Drawing.Color.FromArgb(40, 50, 80);
        }

        private void OnFilterMouseLeave(object sender, EventArgs e)
        {
            if (filterPicBox.Image != null)
                filterPicBox.Image.Dispose();

            filterPicBox.Image = Properties.Resources.Filter_Normal;
            filterPicBox.BackColor = System.Drawing.Color.FromArgb(221, 230, 237);
        }

        private void SetReport()
        {
            if (isOpened)
            {
                totalTaskCount.Text = TaskManager.FilterTaskCount(month, year, priority).ToString();
                totalmilestoneCount.Text = MilestoneManager.FilterMilestoneCount(month, year).ToString();
                Dictionary<string, int> result1 = TaskManager.FilterTeamMemberTaskCount(month, year, priority);
                Dictionary<string, SortedDictionary<DateTime, int>> result2 = TaskManager.FilterTaskCountByDate(month, year);

                int total = 0, colorIndex = 2;
                foreach (var Iter in result1) total += Iter.Value;
                teammatesTaskCount.Text = total.ToString();

                if (total > 0)
                {
                    pieChart1.Visible = true;
                    SeriesCollection seriesCollection = new SeriesCollection();
                    foreach (var Iter in result1)
                    {
                        seriesCollection.Add(new PieSeries { Title = Iter.Key, Values = new ChartValues<double> { Iter.Value }, Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorList[colorIndex].A, colorList[colorIndex].R, colorList[colorIndex].G, colorList[colorIndex].B)) });
                        colorIndex = (colorIndex + 3) % colorList.Count;
                    }
                    pieChart1.Series = seriesCollection;
                }
                else
                {
                    pieChart1.Visible = false;
                }

                cartesianChart1.Series.Clear();
                cartesianChart1.AxisX.Clear();

                bool flag = false;

                foreach (var employeeData in result2)
                {
                    flag = employeeData.Value.Count > 0 ? true : false;
                }

                if (flag)
                {
                    cartesianChart1.Visible = true;

                    SortedSet<DateTime> labels = new SortedSet<DateTime>();
                    foreach (var employeeData in result2)
                    {
                        foreach (var Iter in employeeData.Value)
                        {
                            labels.Add(Iter.Key);
                        }
                    }

                    List<DateTime> labelList = labels.ToList();

                    IList<string> list = new List<string>();
                    foreach (var Iter in labels)
                    {
                        list.Add(Iter.ToShortDateString());
                    }

                    cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Date",
                        Labels = list// Add your values here
                    });
                    colorIndex = 0;
                    foreach (var employeeData in result2)
                    {
                        
                        int[] values = new int[labelList.Count];

                        foreach (var Iter in employeeData.Value)
                        {
                            if (labelList.Contains(Iter.Key))
                            {
                                int x = labelList.IndexOf(Iter.Key);
                                values[x] = Iter.Value;
                            }
                            else
                            {
                                int x = labelList.IndexOf(Iter.Key);
                                values[x] = 0;
                            }
                        }

                        var lineSeries = new LineSeries
                        {
                            Title = employeeData.Key,
                            Values = new ChartValues<int>(values),
                            Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorList[colorIndex].A, colorList[colorIndex].R, colorList[colorIndex].G, colorList[colorIndex].B)),
                            //Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 157, 178, 191)),
                            
                        };
                        colorIndex+=4;
                        cartesianChart1.Series.Add(lineSeries);
                    }

                }
                else
                {
                    cartesianChart1.Visible = false;
                }

            }
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(221, 230, 237));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            e.Graphics.DrawPath(pen, BorderGraphicsPath.GetRoundRectangle(rec, 10));
        }
    }
}
