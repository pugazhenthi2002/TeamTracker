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

namespace UserInterface.Home_Page.Project_Manager
{
    public partial class ProjectManagerHome : UserControl
    {
        public ProjectManagerHome()
        {
            InitializeComponent();
            InitializeOverview();
        }
        private void InitializeOverview()
        {
            DataHandler.ConnectDatabase();
            DataHandler.StoreEmployeeDetails();
            DataHandler.StoreProjectDetails();
            DataHandler.StoreProjectVersionDetails();
            DataHandler.StoreTaskDetails();
            DataHandler.StoreMilestones();
            EmployeeManager.LogInEmployee("paulrobin98@gmail.com", "Lucid123");
            overview1.OverviewCollection = VersionManager.FetchOnProcessProjectVersion();
            notificationContent1.NotifyList = DataHandler.FetchNotification();
        }
    }
}
