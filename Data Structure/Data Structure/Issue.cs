using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTracker;

namespace TeamTracker
{
    public class Issue
    {
        public enum IssueType
        {
            Bug,
            FeatureRequest,
            Optimization,
            Security,
            LogicalNeed,
            Other

        }

        public enum IssuePriority
        {
            High,
            Medium,
            Low
        }

        public int IssueID { get; set; }
        public string IssueName { get; set; }
        public string IssueDesc { get; set; }
        public int PostedBy { get; set; }
        public IssueType Type { get; set; }
        public IssuePriority Priority { get; set; }
        public DateTime PostedDate { get; set; }
        public List<string> Tags { get; set; }
        
    }
}
