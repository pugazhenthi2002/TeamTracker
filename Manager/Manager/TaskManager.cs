using GoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class TaskManager
    {

        public static List<Task> TaskCollection;


        public static BooleanMsg StoreTaskCollection()
        {
            TaskCollection =  DataHandler.StoreTaskDetails();
            if (TaskCollection == null) return "Couldn't able to Connect Task Collection";
            else return true;
        }

        public static bool IsEmployeeInvolvedInVersions(int versionID, int empID)
        {
            foreach(var Iter in TaskCollection)
            {
                if(Iter.VersionID == versionID && Iter.AssignedTo == empID)
                {
                    return true;
                }
            }
            return false;
        }

        //Submit Task
        public static void SubmitTask(Task task, List<SourceCode> sourceCodeCollection)
        {
            task.StatusOfTask = TaskStatus.UnderReview;

            DataHandler.AddSourceCode(sourceCodeCollection);
        }

        public static Dictionary<string, int> FilterTeamMemberTaskCountByMilestone(int id)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            int count = 0;

            List<Employee> employeeCollection = EmployeeManager.FetchTeamMembersForTeamLeaders();
            employeeCollection.Add(EmployeeManager.CurrentEmployee);
            foreach (var Iter in employeeCollection)
            {
                foreach (var TaskIter in TaskCollection)
                {
                    if (TaskIter.MilestoneID == id && Iter.EmployeeID == TaskIter.AssignedTo)
                    {
                        count++;
                    }
                }
                result.Add(Iter.EmployeeFirstName, count);
                count = 0;
            }

            return result;
        }

        public static Dictionary<string, int> FilterTeamMemberTaskCountByVersionID(int versionId)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            int count = 0;

            List<Employee> employeeCollection = EmployeeManager.FetchTeamMembersForTeamLeaders();
            foreach (var Iter in employeeCollection)
            {
                foreach (var TaskIter in TaskCollection)
                {
                    if (TaskIter.AssignedTo == Iter.EmployeeID && TaskIter.VersionID == versionId)
                    {
                        count++;   
                    }
                }
                result.Add(Iter.EmployeeFirstName, count);
                count = 0;
            }

            return result;

        }

        //Move to Done Status
        public static void MoveToDone(Task task)
        {
            task.StatusOfTask = TaskStatus.Done;
        }

        //Created a new Task
        public static void AddTask(string taskName, string taskDescription, DateTime startDate, DateTime endDate, int milestoneID, Priority priority, int assignedTo, TaskAttachment taskAttachment)
        {
            Task task = new Task()
            {
                TaskName = taskName,
                TaskDesc = taskDescription,
                StartDate = startDate,
                EndDate = endDate,
                TaskPriority = priority,
                StatusOfTask = TaskStatus.NotYetStarted,
                VersionID = VersionManager.CurrentVersion.VersionID,
                MilestoneID = milestoneID,
                AssignedBy = EmployeeManager.CurrentEmployee.EmployeeID,
                AssignedTo = assignedTo,
            };

            task = DataHandler.AddTask(task);
            TaskCollection.Add(task);
            taskAttachment.TaskID = task.TaskID;
            DataHandler.AddTaskAttachment(taskAttachment);
        }

        //Update a Task
        public static void UpdateTask(int taskID, string taskName, string taskDescription, DateTime startDate, DateTime endDate, TaskStatus status, int milestoneID, Priority priority, int assignedTo, TaskAttachment taskAttachment)
        {

            foreach(var Iter in TaskCollection)
            {
                if(Iter.TaskID == taskID)
                {
                    Iter.TaskName = taskName;   Iter.TaskDesc = taskDescription;
                    Iter.StartDate = startDate; Iter.EndDate = endDate;
                    Iter.TaskPriority = priority;   Iter.AssignedTo = assignedTo;
                    Iter.StatusOfTask = status;
                    Iter.MilestoneID = milestoneID;
                    DataHandler.UpdateTask(Iter);
                }
            }

            if(taskAttachment!=null) DataHandler.UpdateTaskAttachment(taskID, taskAttachment);
        }

        public static List<Task> FetchUnderReviewTask()
        {
            List<Task> result = new List<Task>();
            foreach(var Iter in TaskCollection)
            {
                if(Iter.VersionID == VersionManager.CurrentVersion.VersionID && Iter.StatusOfTask == TaskStatus.UnderReview)
                {
                    result.Add(Iter);
                }
            }
            return result;
        }

        public static Dictionary<string, int> FilterTeamMemberTaskCount(int month, int year, int priority)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            int count = 0;

            List<Employee> employeeCollection = EmployeeManager.FetchTeamMembersForTeamLeaders();

            foreach(var Iter in employeeCollection)
            {
                foreach(var TaskIter in TaskCollection)
                {
                    if(TaskIter.AssignedTo == Iter.EmployeeID && TaskIter.EndDate.Month == month && TaskIter.EndDate.Year == year)
                    {
                        if (priority == -1)
                        {
                            count++;
                        }
                        else if (priority == (int)TaskIter.TaskPriority)
                        {
                            count++;
                        }
                    }
                }
                result.Add(Iter.EmployeeFirstName,count);
                count = 0;
            }

            return result;
        }

        public static int TotalCommits(int month, int year, int priority)
        {
            List<SourceCode> result = DataHandler.FetchCommitsByFilter(month, year, priority);
            Task task;
            int count = 0;
            foreach(var Iter in result)
            {
                task = FetchTaskFromTaskID(Iter.TaskID);
                if (task!=null && task.TaskPriority == (Priority)priority)
                {
                    count++;
                }
            }
            return count;
        }

        private static Task FetchTaskFromTaskID(int taskID)
        {
            foreach(var Iter in TaskCollection)
            {
                if(Iter.TaskID == taskID)
                {
                    return Iter;
                }
            }
            return null;
        }

        public static Dictionary<string, Dictionary<DateTime, int>> FilterTaskCountByDate(int month, int year)
        {
            Dictionary<string, Dictionary<DateTime, int>> finalResult = new Dictionary<string, Dictionary<DateTime, int>>();
            Dictionary<DateTime, int> result = new Dictionary<DateTime, int>();

            int count = 0;

            TaskCollection.Sort((t1, t2)=>t1.EndDate.CompareTo(t2.EndDate));
            List<Employee> employeeCollection = EmployeeManager.FetchTeamMembersForTeamLeaders();
            employeeCollection.Add(EmployeeManager.CurrentEmployee);

            foreach (var Iter in employeeCollection)
            {
                foreach (var TaskIter in TaskCollection)
                {
                    if (TaskIter.AssignedTo == Iter.EmployeeID && TaskIter.EndDate.Month == month && TaskIter.EndDate.Year == year)
                    {
                        if (!result.ContainsKey(TaskIter.EndDate.Date))
                        {
                            result.Add(TaskIter.EndDate, 0);
                        }
                        result[TaskIter.EndDate]++;
                    }
                }
                finalResult.Add(Iter.EmployeeFirstName, result);
                result = new Dictionary<DateTime, int>();
            }

            return finalResult;
        }

        public static void DeleteTask(int taskID)
        {
            foreach(var Iter in TaskCollection)
            {
                if(Iter.TaskID == taskID)
                {
                    DataHandler.DeleteTask(taskID);
                    TaskCollection.Remove(Iter);
                    break;
                }
            }
        }

        public static int FilterTaskCount(int month, int year, int priority)
        {
            int count = 0;
            foreach(var Iter in TaskCollection)
            {
                if (Iter.EndDate.Month == month && Iter.EndDate.Year == year && Iter.AssignedTo == EmployeeManager.CurrentEmployee.EmployeeID)
                {
                    if(priority==-1)
                    {
                        count++;
                    }
                    else if((int)Iter.TaskPriority == priority)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        //Fetches Task Class by Selected Version ID For Project
        public static List<Task> FetchTasksByVersionID(int versionID)
        {
            List<Task> result = new List<Task>();
            foreach(var Iter in TaskCollection)
            {
                if(Iter.VersionID == versionID)
                {
                    result.Add(Iter);
                }
            }

            result.Sort((r1, r2) => r1.EndDate.CompareTo(r2.EndDate));

            return result;
        }

        //fetches list of task by versionId and Status
        public static List<Task> FetchTasks(int versionID,TaskStatus Tstatus)
        {
            List<Task> result = new List<Task>();
            foreach (var Iter in TaskCollection)
            {
                if (Iter.VersionID == versionID && Iter.StatusOfTask == Tstatus && Iter.AssignedTo == EmployeeManager.CurrentEmployee.EmployeeID)
                {
                    result.Add(Iter);
                }
            }

            result.Sort((r1, r2) => r1.EndDate.CompareTo(r2.EndDate));

            return result;
        }

        //fetches list of task by versionId and Status
        public static List<Task> FetchRemainingTasks(int versionID,TaskStatus Tstatus)
        {
            List<Task> result = new List<Task>();
            foreach (var Iter in TaskCollection)
            {
                if (Iter.VersionID == versionID && Iter.StatusOfTask != Tstatus && Iter.AssignedTo == EmployeeManager.CurrentEmployee.EmployeeID)
                {
                    result.Add(Iter);
                }
            }

            result.Sort((r1, r2) => r1.EndDate.CompareTo(r2.EndDate));

            return result;
        }


        //Checks Whether Selected Date is Between Currently Working Version Project's Date Or Not || Is From Today
        public static bool CheckTaskDate(DateTime start, DateTime end)
        {
            if (VersionManager.CurrentVersion.StartDate<=start && VersionManager.CurrentVersion.StartDate <= end && start <= VersionManager.CurrentVersion.EndDate && end <= VersionManager.CurrentVersion.EndDate)
            {
                if(start >= DateTime.Today.Date)
                {
                    return true;
                }
            }
            return false;
        }

        //Checks and Notify Every Active Version's Task Deadline
        public static void CheckTaskDeadline()
        {
            List<int> activeVersion = VersionManager.ActiveVersionID();
            foreach(var Iter in TaskCollection)
            {
                if(activeVersion.Contains(Iter.VersionID) && Iter.EndDate > DateTime.Today)
                {
                    DataHandler.AddNotify("Task Deadline", Iter.TaskName + Iter.EndDate.ToShortDateString(), Iter.AssignedBy);
                }
            }
        }

        public static List<int> FetchTaskCount(int versionID)
        {
            List<int> result;
            int total = 0, completed = 0, due = 0, incomplete = 0;
            foreach (var Iter in TaskCollection)
            {
                if (Iter.VersionID == versionID)
                {
                    total++;
                    if (Iter.StatusOfTask == TaskStatus.Done) completed++;
                    if (Iter.EndDate < DateTime.Now && !(Iter.StatusOfTask == TaskStatus.Done)) due++;
                    if (Iter.StatusOfTask != TaskStatus.Done) incomplete++;
                }
            }
            result = new List<int>()
            {
                total, completed, due, incomplete
            };

            return result;
        }

        public static int FetchTaskCount(Employee emp, int milestoneID)
        {
            int result = 0;
            foreach(var Iter in TaskCollection)
            {
                if(Iter.AssignedTo == emp.EmployeeID && Iter.MilestoneID == milestoneID)
                {
                    result++;
                }
            }

            return result;
        }

        public static Dictionary<TaskStatus, int> FetchTaskCountByStatus(int versionID)
        {
            Dictionary<TaskStatus, int> result = new Dictionary<TaskStatus, int>();
            result.Add(TaskStatus.NotYetStarted, 0);
            result.Add(TaskStatus.OnProcess, 0);
            result.Add(TaskStatus.Stuck, 0);
            result.Add(TaskStatus.UnderReview, 0);
            result.Add(TaskStatus.Done, 0);
            foreach (var Iter in TaskCollection)
            {
                if(Iter.VersionID == versionID)
                {
                    result[Iter.StatusOfTask]++;
                }
            }

            return result;
        }

        public static List<int> FetchTaskCountByEmployee(int versionID)
        {
            List<int> result;
            int total = 0, completed = 0, due = 0, incomplete = 0;
            foreach (var Iter in TaskCollection)
            {
                if (Iter.VersionID == versionID && Iter.AssignedTo == EmployeeManager.CurrentEmployee.EmployeeID)
                {
                    total++;
                    if (Iter.StatusOfTask == TaskStatus.Done) completed++;
                    if (Iter.EndDate < DateTime.Now && !(Iter.StatusOfTask == TaskStatus.Done)) due++;
                    if (Iter.StatusOfTask != TaskStatus.Done) incomplete++;
                }
            }
            result = new List<int>()
            {
                total, completed, due, incomplete
            };

            return result;
        }
    }
}
