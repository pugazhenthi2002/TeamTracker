using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Wpf;
using TeamTracker;
using UserInterface.ViewPage;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransparencyForm form = new TransparencyForm();
            form.Show();
            WarningForm form1 = new WarningForm()
            {
                Content = "Hello"
            };
            form1.WarningStatus += OnWarningStatus;
            form.ShowForm(form1);
        }

        private void OnWarningStatus(object sender, bool e)
        {
            if (e)
            {

            }
        }
    }
}
