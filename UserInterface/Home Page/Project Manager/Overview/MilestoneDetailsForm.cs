using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using TeamTracker;


namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class MilestoneDetailsForm : Form
    {
        public DateTime EndDate
        {
            set
            {
                labelActualEndDate.Text = "Last Task End Date: " + value.ToShortDateString();
            }
        }
        public Dictionary<string, int> TaskCounts
        {
            set
            {
                taskCounts = value;
                InitializeForm();
            }
        }
        public MilestoneDetailsForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ucNotFound1.BackColor = panel1.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            label1.ForeColor = labelActualEndDate.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            colorList = ThemeManager.CurrentTheme.MilestoneFadingOutColorCollection;
        }

        public new void Dispose()
        {
            pieChart1.Dispose();    label1.Dispose();   labelActualEndDate.Dispose();
            panel1.Dispose();   ucNotFound1.Dispose(); 
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }
        
        private void InitializeForm()
        {
            int count = 0;
            colorIndex = 0;
            SeriesCollection seriesCollection = new SeriesCollection();

            int total = 0;
            foreach (var Iter in taskCounts)
            {
                total += Iter.Value;
            }

            if (total >= 1)
            {
                panel1.Visible = true;
                foreach (var Iter in taskCounts)
                {
                    seriesCollection.Add(new PieSeries { Title = Iter.Key, Values = new ChartValues<double> { Iter.Value }, Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorList[colorIndex].A, colorList[colorIndex].R, colorList[colorIndex].G, colorList[colorIndex].B)) });

                    colorIndex = (colorIndex + 3) % colorList.Count;

                    count = count + Iter.Value;
                }
                pieChart1.Series = seriesCollection;

                label1.Text = "Task Count: " + count;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
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

        private const int CSDropShadow = 0x00020000;
        private Dictionary<string, int> taskCounts;
        private int colorIndex = 0;
        private List<System.Drawing.Color> colorList = new List<System.Drawing.Color>();
    }
}
