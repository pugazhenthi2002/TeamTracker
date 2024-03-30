using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class TaskManager
    {
        public static void StoreTaskCollection()
        {
            TaskCollection =  DataHandler.StoreTaskDetails();
        }
        //Submit Task
        public static void SubmitTask(Task task, List<SourceCode> sourceCodeCollection)
        {
            task.StatusOfTask = TaskStatus.UnderReview;

            DataHandler.AddSourceCode(sourceCodeCollection);
        }

        //Move to Done Status
        public static void MoveToDone(Task task)
        {
            task.StatusOfTask = TaskStatus.Done;
        }

        //Created a new Task
        public static void AddTask(string taskName, string taskDescription, DateTime startDate, DateTime endDate, Priority priority, int assignedTo, List<TaskAttachment> taskAttachments)
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
                AssignedBy = EmployeeManager.CurrentEmployee.EmployeeID,
                AssignedTo = assignedTo,
            };

            task = DataHandler.AddTask(task);

            DataHandler.AddTaskAttachment(taskAttachments);
        }

        //Update a Task
        public static void UpdateTask(int taskID, string taskName, string taskDescription, DateTime startDate, DateTime endDate, Priority priority, int assignedTo, List<TaskAttachment> taskAttachments)
        {

            foreach(var Iter in TaskCollection)
            {
                if(Iter.TaskID == taskID)
                {
                    Iter.TaskName = taskName;   Iter.TaskDesc = taskDescription;
                    Iter.StartDate = startDate; Iter.EndDate = endDate;
                    Iter.TaskPriority = priority;   Iter.AssignedTo = assignedTo;
                    DataHandler.UpdateTask(Iter);
                }
            }
            DataHandler.UpdateTaskAttachment(taskID, taskAttachments);
        }

        //Change Status of Task
        public static void ChangeTaskStatus(Task task, TaskStatus status)
        {
            task.StatusOfTask = status;
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

        public static List<Task> TaskCollection;
    }
}
