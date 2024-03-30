﻿using GoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class EmployeeManager
    {
        public static bool connectionFlag = false;
        public static Employee CurrentEmployee { get; private set; }

        public static BooleanMsg StoreEmployeeToCollection()
        {
            EmployeeCollection = DataHandler.StoreEmployeeDetails();

            if (EmployeeCollection == null) return "Couldn't Able to connect Employee Table";
            else return connectionFlag = true;
        }

        public static BooleanMsg StoreEmployeeManagingCollection()
        {
            ManagingEmployeeCollection = DataHandler.StoreEmployeeManagingDetails();

            if (EmployeeCollection == null) return "Couldn't Able to connect Employee Table";
            else return connectionFlag = true;
        }

        public static BooleanMsg LogInEmployee(string username, string password)
        {
            if (!connectionFlag) return false;
            bool isUsernameAvailable = false;
            foreach(var Iter in EmployeeCollection)
            {
                if (Iter.EmpEmail == username) isUsernameAvailable = true;
                if (Iter.EmpEmail == username && Iter.EmpPassword == password)
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

            if(isUsernameAvailable) { return "Unable to Find Username"; }
            return "Username and Password Mismatch";
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

        private static Employee FetchEmployeeFromID(int empID)
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
