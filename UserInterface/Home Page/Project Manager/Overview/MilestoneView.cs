using System;
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

        private List<Milestone> milestoneCollection { get; set; }
        private List<StartPathAndDate> pathAndDateCollection { get; set; }
        private List<SingleMilestone> singleMilestoneCollection { get; set; }
        private int startCount, endCount;

        public MilestoneView()
        {
            InitializeComponent();
            pathAndDateCollection = new List<StartPathAndDate>() { startPathAndDate1, startPathAndDate2, startPathAndDate3, startPathAndDate4, startPathAndDate5 };
            singleMilestoneCollection = new List<SingleMilestone>() { singleMilestone1, singleMilestone2, singleMilestone3, singleMilestone4 };
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
        

        public int ChangeMilestoneUI(bool flag)
        {
            SuspendLayout();
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
                singleMilestoneCollection[ctr].MilestoneContent = MilestoneCollection[iter];
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
            ResumeLayout();
        }

        private void OnMilestoneViewResize(object sender, EventArgs e)
        {

        }

        private Color SetColor(MilestoneStatus status)
        {
            if (status == MilestoneStatus.Upcoming)
            {
                return Color.FromArgb(72, 202, 228);
            }
            else if(status == MilestoneStatus.OnProcess)
            {
                return Color.FromArgb(0, 180, 216);
            }
            else if(status == MilestoneStatus.Delay)
            {
                return Color.FromArgb(0, 119, 182);
            }
            else
            {
                return Color.FromArgb(3, 4, 94);
            }
        }
    }
}
