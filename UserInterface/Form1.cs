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



namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Focus();
            
        }

        private void rippleButton1_Click(object sender, EventArgs e)
        {
            ;
        }
        bool isDragging = false;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataHandler.ConnectDatabase();
            VersionManager.StoreProjectCollection();
            VersionManager.StoreVersionCollection();
            TaskManager.StoreTaskCollection();
            EmployeeManager.StoreEmployeeToCollection();
            EmployeeManager.StoreEmployeeManagingCollection();
            EmployeeManager.LogInEmployee("emmastonev@gmail.com", "Lucid123");
            //currentTimelineContent1.Version = VersionManager.FetchProjectLatestVersion(3);
            ucTaskBoardBase1.CurrentProjVersion = VersionManager.FetchProjectLatestVersion(3);
        }

        
    }
}
