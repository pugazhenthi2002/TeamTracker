using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class EmployeeManager
    {
        public static Employee CurrentEmployee { get; private set; }

        static EmployeeManager()
        {
            CurrentEmployee = new Employee()
            {
                EmpRoleName = "Team Leader",
                EmployeeFirstName = "Pugazhenthi",
                EmpProfileLocation = "\\\\SPARE-2709DFQ\\Project Management Tool\\Profiles\\pugazhenthiir2002.jpg"
            };
        }

        public static bool LogInEmployee(string username, string password)
        {
            foreach(var Iter in EmployeeCollection)
            {
                if(Iter.EmpEmail == username && Iter.EmpPassword == password)
                {
                    CurrentEmployee = Iter;
                    StoreDatum();
                    if(Iter.EmpRoleName == "Team Leader")
                    {
                        VersionManager.SetCurrentWorkingVersion(Iter.EmployeeID);
                    }
                    else
                    {
                        VersionManager.SetCurrentWorkingVersion(GetTeamLeadIDFromMemberID(Iter.EmployeeID));
                    }
                    return true;
                }
            }

            return false;
        }

        //Shows Team Members for Logged in TeamMembers
        public static List<Employee> FetchTeamMembersForTeamLeaders()
        {
            List<Employee> result = new List<Employee>();

            foreach(var Iter in ManagingEmployeeCollection)
            {
                if(Iter.TeamLeadID == CurrentEmployee.EmployeeID)
                {
                    result.Add(FetchEmployeeFromID(Iter.TeamMemberID));
                }
            }

            return result;
        }

        public static List<Employee> FetchAvailableTeamLeaders(DateTime projectStartDate, DateTime projectEndDate)
        {
            List<Employee> result = new List<Employee>();
            //List<int> teamLeadIDs = new List<int>();
            HashSet<int> teamLeadIDs = new HashSet<int>();
            foreach(var Iter in ManagingEmployeeCollection)
            {
                if(Iter.ManagerID == CurrentEmployee.EmployeeID)
                {
                    teamLeadIDs.Add(Iter.TeamLeadID);
                }
            }

            teamLeadIDs = VersionManager.AvailableTeamIDs(teamLeadIDs, projectStartDate, projectEndDate);

            foreach(var Iter in EmployeeCollection)
            {
                if (teamLeadIDs.Contains(Iter.EmployeeID))
                {
                    result.Add(Iter);
                }
            }

            return result;
        }

        public static Employee FetchEmployeeFromProjectID(int projectID)
        {
            int employeeID = VersionManager.FetchTeamLeadIDFromProjectID(projectID);

            foreach (var Iter in EmployeeCollection)
            {
                if(Iter.EmployeeID == employeeID)
                {
                    return Iter;
                }
            }

            return null;
        }

        public static List<Employee> FetchTeamLeadersFromManagerID()
        {
            List<Employee> result = new List<Employee>();
            HashSet<int> teamLeadID = new HashSet<int>();
            foreach(var Iter in ManagingEmployeeCollection)
            {
                if(Iter.ManagerID == CurrentEmployee.EmployeeID)
                {
                    teamLeadID.Add(Iter.TeamLeadID);
                }
            }
            
            foreach(var Iter in teamLeadID)
            {
                result.Add(FetchEmployeeFromID(Iter));
            }

            return result;
        }

        public static Employee FetchEmployeeFromID(int empID)
        {
            foreach(var Iter in EmployeeCollection)
            {
                if(Iter.EmployeeID == empID)
                {
                    return Iter;
                }
            }
            return null;
        }

        private static int GetTeamLeadIDFromMemberID(int empID)
        {
            foreach(var Iter in ManagingEmployeeCollection)
            {
                if(Iter.TeamMemberID == empID)
                {
                    return Iter.TeamLeadID;
                }
            }

            return -1;
        }

        private static void StoreDatum()
        {
            DataHandler.StoreEmployeeManagingDetails();
            DataHandler.StoreProjectDetails();
            DataHandler.StoreProjectVersionDetails();
            //DataHandler.StoreTaskDetails();
        }

        public static List<Employee> EmployeeCollection;
        public static List<ManagingEmployee> ManagingEmployeeCollection;
    }
}
