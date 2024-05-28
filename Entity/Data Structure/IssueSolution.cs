using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class IssueSolution
    {
        public int IssueSolutionID { get; set; }
        public int IssueID { get; set; }
        public string Solution { get; set; }
        public int SolvedByID { get; set; }
    }
}
