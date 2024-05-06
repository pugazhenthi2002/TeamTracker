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
using System.Reflection;

namespace UserInterface.Home_Page.Project_Manager
{
    public partial class ProjectManagerHome : UserControl
    {
        public ProjectManagerHome()
        {
            InitializeComponent();
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, tableLayoutPanel1, new object[] { true });
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, tableLayoutPanel2, new object[] { true });
        }

        public new void Dispose()
        {
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();
            notificationContent1.Dispose(); overview1.Dispose();    deployContent1.Dispose();
            tableLayoutPanel1.Dispose();    tableLayoutPanel2.Dispose();
        }

        public void InitializeProjectManagerHome()
        {
            overview1.OverviewCollection = VersionManager.FetchOnProcessProjectVersion();
            notificationContent1.NotifyList = DataHandler.FetchNotification();
            deployContent1.DeployVersions = VersionManager.FetchDeploymentsProjectVersion();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}
