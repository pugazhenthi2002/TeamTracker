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
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class MilestoneDetailsForm : Form
    {
        public Dictionary<string,int> TaskCounts
        {
            set
            {
                taskCounts = value;
                InitializePieChart();
            }
        }
        private const int CSDropShadow = 0x00020000;
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

        private Dictionary<string, int> taskCounts;
        public MilestoneDetailsForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void InitializePieChart()
        {
            int count = 0;
            foreach (var Iter in taskCounts)
            {
                chart1.Series[0].Points.AddY(Iter.Value);
                count = count + Iter.Value;
            }
            label1.Text = "Task Count: " + count;

            if (count == 0) chart1.Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            chart1.Dispose();
            panel1.BackgroundImage.Dispose();
        }
    }
}
