using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public enum TaskStatus
    {
        NotYetStarted,
        OnProcess,
        Stuck,
        UnderReview, 
        Done
    }

    public enum Priority
    {
        Critical,
        Hard,
        Medium,
        Easy
    }

    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDesc { get; set; }
        public int AssignedBy { get; set; }
        public int AssignedTo { get; set; }
        public int VersionID { get; set; }
        public int MilestoneID { get; set; }
        public TaskStatus StatusOfTask { get; set; }
        public Priority TaskPriority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
