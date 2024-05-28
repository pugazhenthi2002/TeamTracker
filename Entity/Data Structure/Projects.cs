using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class Projects
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public int ManagerID { get; set; }
        public int TeamLeadID { get; set; }
    }
}
