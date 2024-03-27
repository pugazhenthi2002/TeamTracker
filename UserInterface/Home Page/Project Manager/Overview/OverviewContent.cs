using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class OverviewContent : UserControl
    {
        public OverviewContent()
        {
            InitializeComponent();
        }

        private bool backEnable = false, frontEnable = true;

        private void BackMilestoneClick(object sender, EventArgs e)
        {
            if (backEnable)
                milestoneView1.ChangeMilestoneUI(false);
        }

        private void NextMilestoneClick(object sender, EventArgs e)
        {
            if (frontEnable)
                milestoneView1.ChangeMilestoneUI(true);
        }
    }
}
