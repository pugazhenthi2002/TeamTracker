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
        }

        public void InitializePage()
        {
            teamMemberReport1.InitializeReport();
            taskContent1.InitializePage();
            notificationContent1.NotifyList = DataHandler.FetchNotification();
        }
    }
}
