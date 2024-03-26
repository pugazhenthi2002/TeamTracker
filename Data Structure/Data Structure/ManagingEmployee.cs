using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class ManagingEmployee
    {
        public int ManagingEmployeeID { get; set; }
        public int ManagerID { get; set; }
        public int TeamLeadID { get; set; }
        public int TeamMemberID { get; set; }
    }
}
