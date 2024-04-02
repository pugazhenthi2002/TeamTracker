using GoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class VersionManager
    {

        public static ProjectVersion CurrentVersion { get; set; }

        public static BooleanMsg StoreProjectCollection()
        {
            ProjectCollection = DataHandler.StoreProjectDetails();

            if (ProjectCollection == null) return "Couldn't Able to connect Employee Table";
            else return true;
        }

        public static BooleanMsg StoreVersionCollection()
        {
            VersionCollection = DataHandler.StoreProjectVersionDetails();

            if (VersionCollection == null) return "Couldn't Able to connect Employee Table";
            else return true;
        }

        public static Projects FetchProjectFromID(int id)
        {
            foreach(var Iter in ProjectCollection)
            {
                if(Iter.ProjectID == id)
                {
                    return Iter;
                }
            }
            return null;
        }

        public static void AddProject(string projectName, string versionDesc, int teamLeadID, DateTime startDate, DateTime endDate, string clientEmail, List<VersionAttachment> versionAttachments)
        {
            Projects newProject = new Projects()
            {
                ProjectName = projectName,
                ManagerID = EmployeeManager.CurrentEmployee.EmployeeID,
                TeamLeadID = teamLeadID
            };

            newProject = DataHandler.AddProject(newProject);

            ProjectVersion newVersion = new ProjectVersion()
            {
                VersionName = "1.0",
                VersionDescription = versionDesc,
                ClientEmail = clientEmail,
                StartDate = startDate,
                EndDate = endDate,
                ProjectID = newProject.ProjectID,
                StatusOfVersion = (DateTime.Today.Day == startDate.Day && DateTime.Today.Month == startDate.Month && DateTime.Today.Year == startDate.Year) ? ProjectStatus.OnProcess : ProjectStatus.UpComing
            };

            newVersion = DataHandler.AddVersion(newVersion);

            DataHandler.AddVersionAttachments(versionAttachments, newVersion.VersionID);

            ProjectCollection.Add(newProject);
            VersionCollection.Add(newVersion);
        }

        public static void AddVersion(string versionName, string versionDesc, int teamLeadID, DateTime startDate, DateTime endDate, string clientEmail, int projectID, List<VersionAttachment> versionAttachments)
        {
            ProjectVersion newVersion = new ProjectVersion()
            {
                VersionName = versionName,
                VersionDescription = versionDesc,
                ClientEmail = clientEmail,
                StartDate = startDate,
                EndDate = endDate,
                ProjectID = projectID,
                StatusOfVersion = (DateTime.Today.Day == startDate.Day && DateTime.Today.Month == startDate.Month && DateTime.Today.Year == startDate.Year) ? ProjectStatus.OnProcess : ProjectStatus.UpComing
            };

            newVersion = DataHandler.AddVersion(newVersion);

            DataHandler.AddVersionAttachments(versionAttachments, newVersion.VersionID);

            VersionCollection.Add(newVersion);
        }

        public static void UpdateVersion(int versionID, string versionName, string versionDesc, ProjectStatus status, DateTime startDate, DateTime endDate, string clientEmail, List<VersionAttachment> versionAttachments)
        {
            foreach(var Iter in VersionCollection)
            {
                if(Iter.VersionID == versionID)
                {
                    Iter.VersionName = versionName;
                    Iter.VersionDescription = versionDesc;
                    Iter.StartDate = startDate;
                    Iter.EndDate = endDate;
                    Iter.StatusOfVersion = ProjectStatus.Completed;
                    Iter.ClientEmail = clientEmail;
                    DataHandler.UpdateVersion(Iter);
                    if (versionAttachments != null)
                        DataHandler.UpdateVersionAttachments(Iter.VersionID, versionAttachments);
                    return;
                }
            }
        }

        public static void VersionCompletion(ProjectVersion version)
        {
            UpdateVersion(version.VersionID, version.VersionName, version.VersionDescription, ProjectStatus.Completed, version.StartDate, version.EndDate, version.ClientEmail, null);
        }

        public static void ChangeToCompleteVersionStatus(ProjectVersion version)
        {
            version.StatusOfVersion = ProjectStatus.Completed;
        }

        public static Dictionary<string, ProjectVersion> FetchOnProcessProjectVersion()
        {
            Dictionary<string, ProjectVersion> result = new Dictionary<string, ProjectVersion>();

            string name = "";
            foreach (var Iter in VersionCollection)
            {
                if(Iter.StatusOfVersion == ProjectStatus.OnProcess && GetManagerIDFromProjectID(Iter.ProjectID) == EmployeeManager.CurrentEmployee.EmployeeID)
                {
                    if (!result.ContainsKey(name = GetProjectName(Iter.ProjectID)))
                        result.Add(name, Iter);
                }
            }

            return result;
        }

        public static Dictionary<string, ProjectVersion> FetchDeploymentsProjectVersion()
        {
            Dictionary<string, ProjectVersion> result = new Dictionary<string, ProjectVersion>();

            string name = "";
            foreach (var Iter in VersionCollection)
            {
                if(Iter.StatusOfVersion == ProjectStatus.Deployment && GetManagerIDFromProjectID(Iter.ProjectID) == EmployeeManager.CurrentEmployee.EmployeeID)
                {
                    if (!result.ContainsKey(name = GetProjectName(Iter.ProjectID)))
                        result.Add(name, Iter);
                }
            }

            return result;
        }

        //Checks and Sets Project Version's Deadline on everyTick
        public static void CheckVersionDeadline()
        {
            foreach(var Iter in VersionCollection)
            {
                if(Iter.StatusOfVersion == ProjectStatus.OnProcess && Iter.EndDate > DateTime.Today)
                {
                    DataHandler.AddNotify("Task Deadline", GetProjectName(Iter.ProjectID) + Iter.VersionName + Iter.EndDate.ToShortDateString(), GetManagerIDFromProjectID(Iter.ProjectID));
                }
            }
        }

        //Deploy Project Version
        public static bool DeployProjectVersion(VersionSourceCode sourceCode)
        {
            if (CheckDeployCriteria())
            {
                CurrentVersion.StatusOfVersion = ProjectStatus.Deployment;
                DataHandler.AddVersionSourceCode(sourceCode);
            }
            return false;
        }

        //Fetches On Process Version
        public static List<int> ActiveVersionID()
        {
            List<int> result = new List<int>();
            foreach(var Iter in VersionCollection)
            {
                if(Iter.StatusOfVersion == ProjectStatus.OnProcess)
                {
                    result.Add(Iter.VersionID);
                }
            }

            return result;
        }

        //Fetches All the latest Versions of a project
        public static List<ProjectVersion> FetchAllLastestVersionOfProject()
        {
            List<ProjectVersion> result = new List<ProjectVersion>();
            foreach(var Iter in ProjectCollection)
            {
                result.Add(FetchProjectLatestVersion(Iter.ProjectID));
            }

            return result;
        }

        //Fetches All the Versions of a project using projet ID int Ascending order
        public static List<ProjectVersion> FetchAllVersionFromProject(int projectID)
        {
            List<ProjectVersion> result = new List<ProjectVersion>();

            foreach (var Iter in VersionCollection)
            {
                if (Iter.ProjectID == projectID)
                {
                    result.Add(Iter);
                }
            }
            result.Sort((r1, r2) => r1.EndDate.CompareTo(r2.EndDate));

            return result;
        }

        //Fetches All Project That are only on Completed Status
        public static List<Projects> FetchAllProjectsOnCompletedStatus()
        {
            List<Projects> result = new List<Projects>();
            foreach(var Iter in ProjectCollection)
            {
                if(Iter.ManagerID == EmployeeManager.CurrentEmployee.EmployeeID && (IsProjectAvailableForVersionUpgrade(Iter.ProjectID)))
                {
                    result.Add(Iter);
                }
            }

            return result;
        }

        //Checks and Sets Project Version's On Stage Status for every Tick
        public static void CheckAndChangeVersionStatus()
        {
            foreach(var Iter in VersionCollection)
            {
                if(Iter.StatusOfVersion == ProjectStatus.UpComing && Iter.StartDate <= DateTime.Today)
                {
                    Iter.StatusOfVersion = ProjectStatus.OnStage;
                }
            }
        }

        //Fetchs On Stage Project Version for Logged In Team Leader
        public static ProjectVersion FetchOnStageVersion(int teamLeadID) 
        {
            foreach(var Iter in VersionCollection)
            {
                if(Iter.StatusOfVersion == ProjectStatus.OnStage && FetchTeamLeadIDFromProjectID(Iter.ProjectID) == teamLeadID)
                {
                    return Iter;
                }
            }

            return null;
        }
         
        //Changes On Stage Version Status to On Process Status
        public static void StartProject(ProjectVersion version)
        {
            version.StatusOfVersion = ProjectStatus.OnProcess;
            CurrentVersion = version;
        }

        //Sets Current On Process Project Version for Logged In Employee
        public static void SetCurrentWorkingVersion(int teamLeadID)
        {
            foreach(var Iter in ProjectCollection)
            {
                if (Iter.TeamLeadID == teamLeadID)
                {
                    foreach (var ctr in VersionCollection)
                    {
                        if (ctr.ProjectID == Iter.ProjectID && ctr.StatusOfVersion == ProjectStatus.OnProcess)
                        {
                            CurrentVersion = ctr;
                            return;
                        }
                    }
                }

            }
        }

        //Fetch All Version Names From Project ID Order By Descending Order
        public static List<ProjectVersion> FetchAllVersionFromProjectID(int projectID)
        {
            List<ProjectVersion> result = new List<ProjectVersion>();

            foreach(var Iter in VersionCollection)
            {
                if(Iter.ProjectID == projectID)
                {
                    result.Add(Iter);
                }
            }

            result.Sort((r1, r2) => r2.EndDate.CompareTo(r1.EndDate));

            return result;
        }

        //Fetches Team Leader Available Date for Project /  Version
        public static DateTime FetchTeamLeadAvailableDate(int teamLeadID)
        {
            DateTime availableDate = DateTime.MinValue;

            foreach(var Iter in VersionCollection)
            {
                if(teamLeadID == FetchTeamLeadIDFromProjectID(Iter.ProjectID) && (availableDate <= Iter.EndDate))
                {
                    availableDate = Iter.EndDate;
                }
            }

            return availableDate;
        }

        //Fetched Project's Latest Version
        public static ProjectVersion FetchProjectLatestVersion(int projectID)
        {
            ProjectVersion latestVersion = new ProjectVersion();
            DateTime latestDate = DateTime.MinValue;

            foreach(var Iter in VersionCollection)
            {
                if(Iter.ProjectID == projectID && (latestDate <= Iter.EndDate))
                {
                    latestVersion = Iter;
                    latestDate = Iter.EndDate;
                }
            }

            return latestVersion;
        }

        //Checks if Project Name is Already Available
        public static bool IsProjectNameAlreadyExist(string projectName)
        {
            foreach(var Iter in ProjectCollection)
            {
                if(Iter.ProjectName == projectName)
                {
                    return true;
                }
            }

            return false;
        }

        //Checks if Version Name is Already Available for the Project
        public static bool IsVersionNameAlreadyExist(string versionName, int projectID)
        {
            foreach(var Iter in VersionCollection)
            {
                if(Iter.ProjectID == projectID && Iter.VersionName == versionName)
                {
                    return false;
                }
            }

            return true;
        }

        //Checks if Team Leader is Available for Version Upgrade for Project or New Project
        public static bool IsTeamAvailableForProject(int teamLeadID, DateTime startDate, DateTime endDate)
        {
            foreach(var Iter in VersionCollection)
            {
                if(teamLeadID == FetchTeamLeadIDFromProjectID(Iter.ProjectID) && ((Iter.StartDate <= startDate && startDate <= Iter.EndDate) || (Iter.StartDate <= endDate && endDate<= Iter.EndDate)))
                {
                    return false;
                }
            }

            return true;
        }

        //Available Team Leaders for Assigning New Projects
        public static HashSet<int> AvailableTeamIDs(HashSet<int> teamIDs, DateTime projectStartDate, DateTime projectEndDate)     
        {
            int teamID = -1;
            foreach(var Iter in VersionCollection)
            {
                if(teamIDs.Contains(teamID = FetchTeamLeadIDFromProjectID(Iter.ProjectID)) && ((Iter.StartDate <= projectStartDate && projectStartDate <= Iter.EndDate) || (Iter.StartDate <= projectEndDate && projectEndDate <= Iter.EndDate) || (projectStartDate<=Iter.StartDate && Iter.EndDate<=projectEndDate)))
                {
                    teamIDs.Remove(teamID);
                    teamID = -1;
                }
            }

            return teamIDs;
        }

        //Checks Created Version Date is valid or not
        public static bool CheckDate(DateTime start, DateTime end)
        {
            if (start > DateTime.Today && start < end)
            {
                return true;
            }
            return false;
        }

        //Gets Team Leaders ID from Project ID
        public static int FetchTeamLeadIDFromProjectID(int projectID)
        {
            foreach(var Iter in ProjectCollection)
            {
                if(Iter.ProjectID == projectID)
                {
                    return Iter.TeamLeadID;
                }
            }

            return -1;
        }

        //fetches project Name using versionId
        public static string FetchProjectName(int versionId)
        {
            foreach (var Iter in VersionCollection)
            {
                if (Iter.VersionID == versionId)
                {
                    return GetProjectName(versionId);
                }
            }

            return "";
        }

        private static bool IsProjectAvailableForVersionUpgrade(int projectID)
        {
            foreach(var Iter in VersionCollection)
            {
                if(Iter.ProjectID == projectID && ((Iter.StatusOfVersion == ProjectStatus.OnProcess) || (Iter.StatusOfVersion == ProjectStatus.UpComing) || (Iter.StatusOfVersion == ProjectStatus.OnStage)))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckDeployCriteria()
        {
            foreach (var Iter in TaskManager.TaskCollection)
            {
                if(Iter.VersionID == CurrentVersion.VersionID && Iter.StatusOfTask != TaskStatus.Done)
                {
                    return false;
                }
            }
            return true;
        }

        private static int GetManagerIDFromProjectID(int projectID)
        {
            foreach(var Iter in ProjectCollection)
            {
                if(Iter.ProjectID == projectID)
                {
                    return Iter.ManagerID;
                }
            }
            return -1;
        }

        private static string GetProjectName(int projectID)
        {
            foreach(var Iter in ProjectCollection)
            {
                if(Iter.ProjectID == projectID)
                {
                    return Iter.ProjectName;
                }
            }

            return "";
        }

        public static List<Projects> ProjectCollection;
        public static List<ProjectVersion> VersionCollection;
    }
}
