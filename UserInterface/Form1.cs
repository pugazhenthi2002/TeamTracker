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
        private string placeHolderText = "Hello";
        public Form1()
        {
            InitializeComponent();
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

            AddMilestoneForm form = new AddMilestoneForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.SelectedVersion = VersionManager.FetchProjectLatestVersion(2);
            form.Show();
        }
    }
}
