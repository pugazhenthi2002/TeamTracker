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
using Manager;

namespace UserInterface.Home_Page.Project_Manager
{
    public partial class ProjectManagerHome : UserControl
    {
        public ProjectManagerHome()
        {
            InitializeComponent();
        }

        public void InitializeProjectManagerHome()
        {
            overview1.OverviewCollection = VersionManager.FetchOnProcessProjectVersion();
            notificationContent1.NotifyList = DataHandler.FetchNotification();
            deployContent1.DeployVersions = VersionManager.FetchDeploymentsProjectVersion();
        }
    }
}
