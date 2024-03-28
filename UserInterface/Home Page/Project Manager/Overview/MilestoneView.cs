﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class MilestoneView : UserControl
    {
        public MilestoneView()
        {
            InitializeComponent();
        }

        public List<Milestone> MilestoneCollection
        {
            get { return milestoneCollection;}
            set
            {
                milestoneCollection = value;
                startCount = -1;
                endCount = 2;
            }
        }
        private List<Milestone> milestoneCollection { get; set; }
        private List<StartPathAndDate> pathAndDateCollection { get; set; }
        private List<SingleMilestone> singleMilestoneCollection { get; set; }
        private int startCount, endCount;

        public int ChangeMilestoneUI(bool flag)
        {
            if (flag)
            {
                startCount++;
                endCount++;
            }
            else
            {
                startCount--;
                endCount--;
            }

            startPathAndDate1.SytleOfPath = startCount == 0 ? PathStyle.Start: PathStyle.Middle;
            startPathAndDate5.SytleOfPath = endCount == MilestoneCollection.Count-1 ? PathStyle.End: PathStyle.Middle;
            pathAndDateCollection[0].MilestoneDate = MilestoneCollection[0].StartDate;

            for(int ctr=0, iter = startCount; ctr<4 && iter<=endCount; ctr++, iter++)
            {
                singleMilestoneCollection[ctr].MilestoneContent = MilestoneCollection[iter].MileStoneName;
                pathAndDateCollection[ctr].MilestoneColor = singleMilestoneCollection[ctr].MilestoneColor = SetColor(MilestoneCollection[iter].Status);
                pathAndDateCollection[ctr + 1].MilestoneDate = MilestoneCollection[iter].EndDate;
            }
            int size = pathAndDateCollection.Count;
            pathAndDateCollection[size-1].MilestoneColor = singleMilestoneCollection[size-2].MilestoneColor;

            if (startCount == 0)
            {
                return -1;
            }
            else if (endCount == MilestoneCollection.Count - 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void OnMilestoneViewResize(object sender, EventArgs e)
        {

        }

        private Color SetColor(MilestoneStatus status)
        {
            if (status == MilestoneStatus.Upcoming)
            {
                return Color.Orange;
            }
            else if(status == MilestoneStatus.OnProcess)
            {
                return Color.Blue;
            }
            else if(status == MilestoneStatus.Delay)
            {
                return Color.Red;
            }
            else
            {
                return Color.Green;
            }
        }
    }
}
