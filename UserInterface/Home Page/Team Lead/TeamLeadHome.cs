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

namespace UserInterface.Home_Page.Team_Lead
{
    public partial class TeamLeadHome : UserControl
    {
        public TeamLeadHome()
        {
            InitializeComponent();
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            tableLayoutPanel1.BackColor = BackColor = reportTemplate1.BackColor = overview1.BackColor = notificationContent1.BackColor = onStageTemplate1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            reportTemplate1.BorderColor = overview1.BorderColor = notificationContent1.BorderColor = onStageTemplate1.BorderColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        public void InitializeHomePage()
        {
            reportTemplate1.InitializeReport();
            overview1.OverviewCollection = VersionManager.FetchOnProcessProjectVersion(EmployeeManager.CurrentEmployee.EmployeeID);
            notificationContent1.NotifyList = DataHandler.FetchNotification();
            onStageTemplate1.SelectedVersion = VersionManager.FetchOnStageVersion(EmployeeManager.CurrentEmployee.EmployeeID);
        }

        private void OnResetHomePage(object sender, EventArgs e)
        {
            InitializeHomePage();
        }
    }
}
