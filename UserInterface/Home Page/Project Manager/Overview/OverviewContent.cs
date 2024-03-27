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
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class OverviewContent : UserControl
    {
        public OverviewContent()
        {
            InitializeComponent();
        }

        public ProjectVersion Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
                InitializeOverview();
            }
        }

        private ProjectVersion version;
        private bool backEnable = false, frontEnable = true;
        private int flag;

        private void BackMilestoneClick(object sender, EventArgs e)
        {
            if (backEnable)
                flag = milestoneView1.ChangeMilestoneUI(false);

            if (flag < 0) backEnable = false;
            else { frontEnable = backEnable = true; }
        }

        private void NextMilestoneClick(object sender, EventArgs e)
        {
            if (frontEnable)
                flag = milestoneView1.ChangeMilestoneUI(true);

            if (flag > 0) frontEnable = false;
            else { frontEnable = backEnable = true; }
        }

        private void InitializeOverview()
        {
            List<int> result = TaskManager.FetchTaskCount(version.VersionID);

            taskCountLabel.Text = result[0].ToString();
            completedTaskLabel.Text = result[1].ToString();
            dueTaskLabel.Text = result[2].ToString();
            incompleteTaskLabel.Text = result[3].ToString();

            milestoneView1.MilestoneCollection = MilestoneManager.FetchMilestones(version.VersionID);

            flag = milestoneView1.ChangeMilestoneUI(true);

            if (flag > 0) frontEnable = false;
            else { frontEnable = backEnable = true; }

        }
    }
}
