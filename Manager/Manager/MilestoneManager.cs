using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class MilestoneManager
    {
        public static List<Milestone> FetchMilestones(int versionID)
        {
            List<Milestone> result = new List<Milestone>();
            foreach(var Iter in MilestoneCollection)
            {
                if(Iter.VersionID == versionID)
                {
                    result.Add(Iter);
                }
            }

            result.Sort((r1, r2) => r1.EndDate.CompareTo(r2.EndDate));

            return result;
        }

        public static List<Milestone> MilestoneCollection = new List<Milestone>();
    }
}
