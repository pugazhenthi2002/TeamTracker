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
        private int result;

        private void BackMilestoneClick(object sender, EventArgs e)
        {
            if (backEnable)
                result = milestoneView1.ChangeMilestoneUI(false);

            if (result < 0) backEnable = false;
            else { frontEnable = backEnable = true; }
        }

        private void NextMilestoneClick(object sender, EventArgs e)
        {
            if (frontEnable)
                result = milestoneView1.ChangeMilestoneUI(true);

            if (result > 0) frontEnable = false;
            else { frontEnable = backEnable = true; }
        }
    }
}
