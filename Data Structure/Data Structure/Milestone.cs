using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public enum MilestoneStatus
    {
        Upcoming,
        OnProcess,
        Completed,
        Delay
    }

    public class Milestone
    {
        public int MileStoneID;
        public string MileStoneName;
        public int VersionID;
        public DateTime StartDate;
        public DateTime EndDate;
        public MilestoneStatus Status;
    }
}
