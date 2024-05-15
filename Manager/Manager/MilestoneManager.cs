using GoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class MilestoneManager
    {

        public static List<Milestone> MilestoneCollection = new List<Milestone>();
        public static Milestone CurrentMilestone { get; set; }

        public static void AddMilestones(int versionID, List<Milestone> milestoneCollection)
        {
            milestoneCollection = DataHandler.AddMilestones(versionID, milestoneCollection);

            foreach(var Iter in milestoneCollection)
            {
                if(Iter.Status == MilestoneStatus.OnProcess)
                {
                    CurrentMilestone = Iter;
                }
                MilestoneCollection.Add(Iter);
            }
        }

        public static void UpdateMilestone(Milestone milestone, MilestoneStatus status)
        {
            foreach (var Iter in MilestoneCollection)
            {
                if (Iter.MileStoneID == milestone.MileStoneID)
                {
                    Iter.Status = milestone.Status = status;
                    DataHandler.UpdateMilestone(milestone);
                    return;
                }
            }
        }

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

        public static Milestone FetchMilestoneFromID(int id)
        {
            foreach(var Iter in MilestoneCollection)
            {
                if(Iter.MileStoneID == id)
                {
                    return Iter;
                }
            }

            return null;
        }

        public static DateTime MilestoneLastCompletedTaskDate(int milestoneID)
        {
            DateTime result = DateTime.MinValue;
            foreach(var Iter in TaskManager.TaskCollection)
            {
                if (Iter.MilestoneID == milestoneID && result < Iter.EndDate)
                {
                    result = Iter.EndDate;
                }
            }

            return result;
        }

        public static int FetchTeamLeader(int milestoneID)
        {
            foreach(var Iter in MilestoneCollection)
            {
                if(milestoneID == Iter.MileStoneID)
                {
                    return VersionManager.FetchTeamLeadFromVersionID(Iter.VersionID);
                }
            }
            return -1;
        }

        public static void CheckMilestoneDeadline()
        {
            foreach (var Iter in MilestoneCollection)
            {
                if (Iter.Status != MilestoneStatus.Completed && Iter.IsDelayed == false && Iter.EndDate <= DateTime.Now.Date)
                {
                    DataHandler.AddNotify("Milestone Deadline", Iter.MileStoneName + Iter.EndDate.ToShortDateString(), EmployeeManager.FetchManagerFromTeamLeadID(VersionManager.FetchTeamLeadFromVersionID(Iter.VersionID)).EmployeeID);
                }
            }
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

        public static int FilterMilestoneCount(int month, int year)
        {
            int count = 0;
            foreach(var Iter in MilestoneCollection)
            {
                if(month == Iter.EndDate.Month && year == Iter.EndDate.Year && (EmployeeManager.CurrentEmployee.EmployeeID == VersionManager.FetchTeamLeadFromVersionID(Iter.VersionID) || IsEmployeeInvolvedInMilestone(Iter.MileStoneID)))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool IsEmployeeInvolvedInMilestone(int mileStoneID)
        {
            foreach(var Iter in TaskManager.TaskCollection)
            {
                if(Iter.MilestoneID == mileStoneID && Iter.AssignedTo == EmployeeManager.CurrentEmployee.EmployeeID)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsAllTaskCompletedInCurrentMilestone()
        {
            bool flag = false;
            foreach(var Iter in TaskManager.TaskCollection)
            {
                if (Iter.MilestoneID == CurrentMilestone.MileStoneID)
                    flag = true;

                if(Iter.MilestoneID == CurrentMilestone.MileStoneID && Iter.StatusOfTask != TaskStatus.Done)
                {
                    return false;
                }
            }

            return true && flag;
        }

        public static void SwitchToNextMilestone()
        {
            List<Milestone> milestoneList = FetchMilestones(VersionManager.CurrentVersion.VersionID);

            for(int ctr=0; ctr < milestoneList.Count; ctr++)
            {
                if(milestoneList[ctr].Status == MilestoneStatus.OnProcess)
                {
                    milestoneList[ctr].EndDate = DateTime.Now.Date;
                    ModifyTaskDateBasedOnMilestone(milestoneList[ctr].MileStoneID);
                    UpdateMilestone(milestoneList[ctr], MilestoneStatus.Completed);
                    if (ctr < milestoneList.Count - 1)
                    {
                        milestoneList[ctr + 1].StartDate = DateTime.Now.Date;
                        UpdateMilestone(milestoneList[ctr + 1], MilestoneStatus.OnProcess);
                        CurrentMilestone = milestoneList[ctr + 1];
                    }
                    break;
                }
            }
        }

        public static void ModifyTaskDateBasedOnMilestone(int milestoneID)
        {
            foreach (var Iter in TaskManager.TaskCollection)
            {
                if (Iter.MilestoneID == milestoneID)
                {
                    if (Iter.StartDate >= DateTime.Now.Date) Iter.StartDate = DateTime.Now.Date;
                    if (Iter.EndDate >= DateTime.Now.Date) Iter.EndDate = DateTime.Now.Date;

                    DataHandler.UpdateTask(Iter);
                }
            }
        }

        public static bool IsCurrentMilestoneIsLastMilestone()
        {
            if (CurrentMilestone != null && CurrentMilestone.EndDate == VersionManager.CurrentVersion.EndDate)
            {
                return true;
            }
            return false;
        }

        public static bool IsTaskWithinTheMilestone(DateTime startDate, DateTime endDate, int milestoneID)
        {
            foreach(var Iter in MilestoneCollection)
            {
                if(Iter.MileStoneID == milestoneID)
                {
                    return Iter.StartDate <= startDate && endDate <= Iter.EndDate;
                }
            }

            return true;
        }

        public static void DeleteAllMilestoneFromVersion(int versionID)
        {
            for(int ctr=0; ctr < MilestoneCollection.Count; ctr++)
            {
                if(MilestoneCollection[ctr].VersionID == versionID)
                {
                    DataHandler.DeleteMilestone(MilestoneCollection[ctr].MileStoneID);
                    MilestoneCollection.RemoveAt(ctr);
                    ctr--;
                }
            }
        }
    }
}
