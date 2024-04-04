using GoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class MilestoneManager
    {
        public static Milestone CurrentMilestone { get; set; }

        public static BooleanMsg StoreMilestoneCollection()
        {
            MilestoneCollection = DataHandler.StoreMilestones();

            if (MilestoneCollection == null) { return "Couldn't able to Connect Milestone"; }
            else
            {
                if(VersionManager.CurrentVersion != null)
                {
                    int id = VersionManager.CurrentVersion.VersionID;

                    foreach(var Iter in MilestoneCollection)
                    {
                        if(Iter.VersionID == id && Iter.Status == MilestoneStatus.OnProcess)
                        {
                            CurrentMilestone = Iter;
                            break;
                        }
                    }
                }
                return true;
            }
        }

        public static Milestone FetchCurrentVersion(ProjectVersion version)
        {
            foreach(var Iter in MilestoneCollection)
            {
                if(Iter.VersionID == version.VersionID && Iter.Status == MilestoneStatus.OnProcess)
                {
                    return Iter;
                }
            }

            return null;
        }

        public static int FetchTeamLeader(int milestoneID)
        {
            foreach(var Iter in TaskManager.TaskCollection)
            {
                if(milestoneID == Iter.MilestoneID)
                {
                    return Iter.AssignedBy;
                }
            }
            return -1;
        }

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
