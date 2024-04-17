using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class SourceCode
    {
        public int SourceCodeID { get; set; }
        public int TaskID { get; set; }
        public string SourceCodeName { get; set; }
        public string CommitName { get; set; }
        public string SourceCodeLocation { get; set; }
        public DateTime SubmittedDate { get; set; }
    }
}
