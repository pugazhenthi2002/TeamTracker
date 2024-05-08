using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmpRoleName { get; set; }
        public string EmpEmail { get; set; }
        public DateTime EmpDOB { get; set; }
        public string EmpProfileLocation { get; set; }
        public string EmpPassword { get; set; }
    }
}
