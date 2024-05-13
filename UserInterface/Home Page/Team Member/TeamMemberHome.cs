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

namespace UserInterface.Home_Page.Team_Member
{
    public partial class TeamMemberHome : UserControl
    {
        public TeamMemberHome()
        {
            InitializeComponent();
            InitializePageColor();
        }

        public void InitializePage()
        {
            InitializePageColor();
            teamMemberReport1.InitializeReport();
            taskContent1.InitializePage();
            notificationContent1.NotifyList = DataHandler.FetchNotification();
        }

        private void InitializePageColor()
        {
            BackColor = teamMemberReport1.BackColor = taskContent1.BackColor = notificationContent1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            teamMemberReport1.BorderColor = notificationContent1.BorderColor = ThemeManager.CurrentTheme.PrimaryI;
        }
    }
}
