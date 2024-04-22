using DatabaseLibrary;
using GoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class DataHandler
    {
        private static DatabaseManager manager;

        public static BooleanMsg ConnectDatabase()
        {
            //manager = new MySqlHandler("192.168.3.55", "Ilam", "Lucid123", "teamtracker");
            manager = new MySqlHandler("localhost", "root", "Lucid123", "projectmanagement");
            BooleanMsg result = manager.Connect();

            return result.Result;
        }

        public static Projects AddProject(Projects project)
        {
            var x = manager.InsertData("project", new ParameterData[] 
            {
                new ParameterData("ProjectName", project.ProjectName),
                new ParameterData("ManagerID", project.ManagerID),
                new ParameterData("TeamLeadID", project.TeamLeadID)
            }).Result;

            var result = manager.FetchData("project", $"ProjectName='{project.ProjectName}'").Value;
            project.ProjectID = Convert.ToInt32(result["ProjectID"][0]);
          
            return project;
        }

        public static ProjectVersion AddVersion(ProjectVersion version)
        {
            var x = manager.InsertData("projectversion", new ParameterData[] 
            {
                new ParameterData("ProjectID", version.ProjectID),
                new ParameterData("VersionName", version.VersionName),
                new ParameterData("VersionDesc", version.VersionDescription),
                new ParameterData("ClientEmail", version.ClientEmail),
                new ParameterData("StartDate", version.StartDate),
                new ParameterData("EndDate", version.EndDate),
                new ParameterData("StatusOfProject", version.StatusOfVersion.ToString())
            });

            var result = manager.FetchData("projectversion", $"VersionName='{version.VersionName}' AND ProjectID='{version.ProjectID}'").Value;
            version.VersionID = Convert.ToInt32(result["VersionID"][0]);

            return version;
        }

        public static SourceCode GetTaskSourceBySourceCodeID(int sourceCodeID)
        {
            SourceCode result = new SourceCode();
            var attachments = manager.FetchData("sourcecode", $"SourceCodeID='{sourceCodeID}", orderBy: "SubmittedDate", limitCount: 1).Value;

            result = new SourceCode()
            {
                SourceCodeID = Convert.ToInt32(attachments["SourceCodeID"][0]),
                TaskID = Convert.ToInt32(attachments["TaskID"][0]),
                CommitedBy = Convert.ToInt32(attachments["CommitedBy"][0]),
                CommitName = Convert.ToString(attachments["CommitName"][0]),
                SourceCodeLocation = Convert.ToString(attachments["SourceCodeLocation"][0])
            };

            return result;
        }

        public static Task AddTask(Task task)
        {
            var x = manager.InsertData("task", new ParameterData[]
            {
                new ParameterData("TaskName", task.TaskName),
                new ParameterData("TaskDesc", task.TaskDesc),
                new ParameterData("StartDate", task.StartDate),
                new ParameterData("EndDate", task.EndDate),
                new ParameterData("VersionID", task.VersionID),
                new ParameterData("MilestoneID", task.MilestoneID),
                new ParameterData("StatusOfTask", task.StatusOfTask.ToString()),
                new ParameterData("PriorityOfTask", task.TaskPriority.ToString()),
                new ParameterData("AssignedBy", task.AssignedBy),
                new ParameterData("AssignedTo", task.AssignedTo)
            });

            var result = manager.FetchData("task", $"TaskName='{task.TaskName}' AND VersionID='{task.VersionID}'").Value;

            task.TaskID = Convert.ToInt32(result["TaskID"][0]);

            return task;
        }

        public static List<Milestone> AddMilestones(int versionID, List<Milestone> milestoneCollections)
        {
            foreach(var Iter in milestoneCollections)
            {
                var x = manager.InsertData("milestone", new ParameterData[]
                {
                    new ParameterData("MilestoneName", Iter.MileStoneName),
                    new ParameterData("VersionID", versionID),
                    new ParameterData("StartDate", Iter.StartDate),
                    new ParameterData("EndDate", Iter.EndDate),
                    new ParameterData("Status", Iter.Status.ToString())
                });
            }

            var result = manager.FetchData("milestone", $"VersionID='{versionID}'", orderBy:"EndDate").Value;

            for(int ctr=0; ctr < result["MilestoneID"].Count; ctr++)
            {
                milestoneCollections[ctr].MileStoneID = Convert.ToInt32(result["MilestoneID"][ctr]);
            }

            return milestoneCollections;
        }

        public static void SubmitSourceCode(SourceCode sourceCode)
        {
            string savePath = @"\\\\SPARE-2709DFQ\\Project Management Tool\\SourceCode\\Task\\"; // Change this to your desired save path
            try
            {
                string filePath = System.IO.Path.Combine(savePath, sourceCode.SourceCodeName);
                System.IO.File.Copy(sourceCode.SourceCodeLocation, filePath, true);

                var x = manager.InsertData("sourcecode", new ParameterData[]
                {
                    new ParameterData("TaskID", sourceCode.TaskID),
                    new ParameterData("CommitName", sourceCode.CommitName),
                    new ParameterData("CommitedBy", sourceCode.CommitedBy),
                    new ParameterData("SourceCodeName", sourceCode.SourceCodeName),
                    new ParameterData("SubmittedDate", sourceCode.SubmittedDate),
                    new ParameterData("SourceCodeLocation", filePath),
                });
            }
            catch
            {
                ;
            }
            
        }

        public static List<SourceCode> FetchCommitsByFilter(int month, int year, int priority)
        {
            List<SourceCode> result = new List<SourceCode>();

            var attachments = manager.FetchData("sourcecode", $"CommitedBy={EmployeeManager.CurrentEmployee.EmployeeID} && Month(SubmittedDate)={month} && Year(SubmittedDate)={year}").Value;

            for (int ctr = 0; attachments.Count > 0 && ctr < attachments["TaskID"].Count; ctr++)
            {
                result.Add(new SourceCode()
                {
                    TaskID = Convert.ToInt32(attachments["TaskID"][ctr]),
                    CommitName = Convert.ToString(attachments["CommitName"][ctr]),
                    SourceCodeLocation = Convert.ToString(attachments["SourceCodeLocation"][ctr]),
                    SourceCodeName = Convert.ToString(attachments["SourceCodeName"][ctr]),
                    SubmittedDate = Convert.ToDateTime(attachments["SubmittedDate"][ctr]),
                });
            }

            return result;
        }

        public static BooleanMsg DeleteSourceCode(int taskID)
        {
            var result = manager.FetchData("sourcecode", $"TaskID='{taskID}'", orderBy: "SubmittedDate", limitCount:1).Value;

            if (result == null || result["SourceCodeID"].Count > 1) return null;

            var x = manager.DeleteData("sourcecode", $"SourceCodeID='{result["SourceCodeID"][0]}'");

            return true;
        }

        public static void SubmitVersionSourceCode(VersionSourceCode selectedVersionSourceCode)
        {
            string savePath = @"\\\\SPARE-2709DFQ\\Project Management Tool\\SourceCode\\Version\\"; // Change this to your desired save path
            try
            {
                string filePath = System.IO.Path.Combine(savePath, selectedVersionSourceCode.SourceCodeName);
                System.IO.File.Copy(selectedVersionSourceCode.VersionLocation, filePath, true);

                var x = manager.InsertData("versionsourcecode", new ParameterData[]
                {
                    new ParameterData("VersionID", selectedVersionSourceCode.VersionID),
                    new ParameterData("DisplayName", selectedVersionSourceCode.DisplayName),
                    new ParameterData("SourceCodeName", selectedVersionSourceCode.SourceCodeName),
                    new ParameterData("SourceCodeLocation", filePath),
                });
            }
            catch
            {
                ;
            }
            
        }

        public static void DeleteTask(int taskID)
        {
            var x = manager.DeleteData("task", $"TaskID='{taskID}'");
        }

        public static void UpdateVersion(ProjectVersion version)
        {
            manager.UpdateData("projectversion", $"VersionID='{version.VersionID}'", new ParameterData[]
            {
                new ParameterData("ProjectID", version.ProjectID),
                new ParameterData("VersionName", version.VersionName),
                new ParameterData("VersionDesc", version.VersionDescription),
                new ParameterData("ClientEmail", version.ClientEmail),
                new ParameterData("StartDate", version.StartDate),
                new ParameterData("EndDate", version.EndDate),
                new ParameterData("StatusOfProject", version.StatusOfVersion.ToString())
            });
        }

        public static void UpdateTask(Task task)
        {
            var x = manager.UpdateData("task", $"TaskID='{task.TaskID}'", new ParameterData[]
            {
                new ParameterData("TaskName", task.TaskName),
                new ParameterData("TaskDesc", task.TaskDesc),
                new ParameterData("StartDate", task.StartDate),
                new ParameterData("EndDate", task.EndDate),
                new ParameterData("VersionID", task.VersionID),
                new ParameterData("MilestoneID", task.MilestoneID),
                new ParameterData("StatusOfTask", task.StatusOfTask.ToString()),
                new ParameterData("PriorityOfTask", task.TaskPriority.ToString()),
                new ParameterData("AssignedBy", task.AssignedBy),
                new ParameterData("AssignedTo", task.AssignedTo)
            });
        }

        public static void UpdateMilestone(Milestone milestone)
        {
            var x = manager.UpdateData("milestone", $"MilestoneID='{milestone.MileStoneID}'", new ParameterData[]
            {
                new ParameterData("MilestoneName", milestone.MileStoneName),
                new ParameterData("VersionID", milestone.VersionID),
                new ParameterData("StartDate", milestone.StartDate),
                new ParameterData("EndDate", milestone.EndDate),
                new ParameterData("Status", milestone.Status.ToString()),
            });
        }

        public static void AddVersionAttachments(List<VersionAttachment> versionAttachments, int versionID)
        {
            string savePath = @"\\\\SPARE-2709DFQ\\Project Management Tool\\Version Attachment\\"; // Change this to your desired save path
            string filePath;
            try
            {
                foreach (var Iter in versionAttachments)
                {
                    filePath = System.IO.Path.Combine(savePath, Iter.AttachmentName);
                    System.IO.File.Copy(Iter.AttachmentLocation, filePath, true);

                    manager.InsertData("versionattachment", new ParameterData[]
                    {
                        new ParameterData("VersionID", versionID),
                        new ParameterData("DisplayName", Iter.DisplayName),
                        new ParameterData("AttachmentName", Iter.AttachmentName),
                        new ParameterData("AttachmentLocation", filePath)
                    });
                }
            }
            catch
            {
                ;
            }
            
        }

        public static BooleanMsg CommitNameAlreadyExists(int taskID, string commitName)
        {
            var result = manager.FetchData("sourcecode", $"TaskID='{taskID}' && CommitName='{commitName}'").Value;
            if (result == null) return true;
            return result.Count > 0;
        }

        public static void AddTaskAttachment(TaskAttachment taskAttachment)
        {
            string savePath = @"\\\\SPARE-2709DFQ\\Project Management Tool\\Task Attachment\\"; // Change this to your desired save path
            try
            {
                string filePath = System.IO.Path.Combine(savePath, taskAttachment.TaskAttachmentName);
                System.IO.File.Copy(taskAttachment.TaskAttachmentLocation, filePath, true);

                manager.InsertData("taskattachment", new ParameterData[]
                {
                    new ParameterData("TaskID", taskAttachment.TaskID),
                    new ParameterData("DisplayName", taskAttachment.DisplayName),
                    new ParameterData("TaskAttachmentName", taskAttachment.TaskAttachmentName),
                    new ParameterData("TaskAttachmentLocation", filePath)
                });
            }
            catch
            {
                ;
            }
            
        }

        public static void AddSourceCode(List<SourceCode> sourceCodeAttachments)
        {
            foreach (var Iter in sourceCodeAttachments)
            {
                manager.InsertData("sourcecode", new ParameterData[]
                {
                    new ParameterData("CommitName", Iter.CommitName),
                    new ParameterData("SourceCodeLocation", Iter.SourceCodeLocation),
                    new ParameterData("CommitedBy", Iter.CommitedBy),
                    new ParameterData("SubmittedDate", Iter.SubmittedDate),
                    new ParameterData("TaskID", Iter.TaskID)
                });
            }
        }

        public static void AddVersionSourceCode(VersionSourceCode sourceCode)
        {
            string savePath = @"\\\\SPARE-2709DFQ\\Project Management Tool\\SourceCode\\Version\\";
            string filePath = System.IO.Path.Combine(savePath, sourceCode.SourceCodeName);
            System.IO.File.Copy(sourceCode.VersionLocation, filePath, true);

            var x = manager.InsertData("versionsourcecode", new ParameterData[]
            {
                new ParameterData("VersionID", sourceCode.VersionID),
                new ParameterData("DisplayName", sourceCode.DisplayName),
                new ParameterData("SourceCodeName", sourceCode.SourceCodeName),
                new ParameterData("SourceCodeLocation", filePath)
            });
            

        }

        public static void AddNotification(string header, string content, DateTime date, int assignedTo)
        {
            var x = manager.InsertData("notification", new ParameterData[]
            {
                new ParameterData("Header", header),
                new ParameterData("Content", content),
                new ParameterData("AssignedTo", assignedTo),
                new ParameterData("NotifyDate", date),
            });
        }

        public static void UpdateVersionAttachments(int versionID, List<VersionAttachment> versionAttachments)
        {
            var x = manager.DeleteData("versionattachment", $"VersionID='{versionID}'");

            foreach (var Iter in versionAttachments)
            {
                manager.InsertData("versionattachment", new ParameterData[]
                {
                    new ParameterData("VersionID", Iter.VersionID),
                    new ParameterData("AttachmentName", Iter.AttachmentName),
                    new ParameterData("AttachmentLocation", Iter.AttachmentLocation)
                });
            }
        }

        public static void UpdateTaskAttachment(int taskID, TaskAttachment taskAttachments)
        {
            var x = manager.DeleteData("taskattachment", $"TaskID='{taskID}'");

            manager.InsertData("taskattachment", new ParameterData[]
            {
                new ParameterData("TaskID", taskAttachments.TaskID),
                new ParameterData("DisplayName", taskAttachments.DisplayName),
                new ParameterData("TaskAttachmentName", taskAttachments.TaskAttachmentName),
                new ParameterData("TaskAttachmentLocation", taskAttachments.TaskAttachmentLocation)
            });
        }

        public static void DeleteNotification(int notifyID)
        {
            manager.DeleteData("notification", $"NotifyID={notifyID}");
        }

        public static void DeleteAllNotification()
        {
            manager.DeleteData("notification", $"AssignedTo={EmployeeManager.CurrentEmployee.EmployeeID}");
        }

        public static List<VersionAttachment> FetchAttachmentsByVersionID(int versionID)
        {
            List<VersionAttachment> result = new List<VersionAttachment>();

            var attachments = manager.FetchData("versionattachment", $"VersionID={versionID}").Value;

            for (int ctr = 0; attachments.Count > 0 &&  ctr < attachments["VersionAttachmentID"].Count; ctr++)
            {
                result.Add(new VersionAttachment()
                {
                    VersionID = Convert.ToInt32(attachments["VersionID"][ctr]),
                    AttachmentLocation = Convert.ToString(attachments["AttachmentLocation"][ctr]),
                    AttachmentName = Convert.ToString(attachments["AttachmentName"][ctr]),
                    DisplayName = Convert.ToString(attachments["DisplayName"][ctr])
                });
            }

            return result;
        }

        public static List<SourceCode> FetchLastCommitedSourceCodeByTaskID(int taskID)
        {
            List<SourceCode> result = new List<SourceCode>();

            var x = manager.FetchData("sourcecode", $"TaskID={taskID}", orderBy:"SubmittedDate Desc", limitCount:1).Value;
            DateTime date = Convert.ToDateTime(x["SubmittedDate"][0]);
            var lastCommited = manager.FetchData("sourcecode", $"TaskID={taskID} AND SubmittedDate='{date}'").Value;

            for (int ctr = 0; lastCommited.Count > 0 && ctr < lastCommited["SourceCodeID"].Count; ctr++)
            {
                result.Add(new SourceCode()
                {
                    SourceCodeID = Convert.ToInt32(lastCommited["SourceCodeID"][ctr]),
                    CommitName = Convert.ToString(lastCommited["CommitName"][ctr]),
                    CommitedBy = Convert.ToInt32(lastCommited["CommitedBy"][ctr]),
                    SourceCodeLocation = Convert.ToString(lastCommited["SourceCodeLocation"][ctr]),
                    SubmittedDate = Convert.ToDateTime(lastCommited["SubmittedDate"][ctr]),
                    TaskID = Convert.ToInt32(lastCommited["TaskID"][ctr])
                });
            }

            return result;
        }

        public static List<List<SourceCode>> FetchAllSourceCodeByTaskID(int taskID)
        {
            List<List<SourceCode>> result = new List<List<SourceCode>>();
            List<SourceCode> temp = new List<SourceCode>();
            DateTime prevCommitDate = DateTime.MaxValue;

            var sourceCodeCollection = manager.FetchDistinctData("sourcecode", $"TaskID={taskID}", orderBy: "SubmittedDate Desc").Value;

            for (int ctr = 0; sourceCodeCollection.Count > 0 && ctr < sourceCodeCollection["SourceCodeID"].Count; ctr++)
            {
                if (prevCommitDate > Convert.ToDateTime(sourceCodeCollection["SubmittedDate"][ctr]))
                {
                    prevCommitDate = Convert.ToDateTime(sourceCodeCollection["SubmittedDate"][ctr]);
                    result.Add(temp);
                    temp = new List<SourceCode>();
                }

                temp.Add(new SourceCode()
                {
                    SourceCodeID = Convert.ToInt32(sourceCodeCollection["SourceCodeID"][ctr]),
                    SourceCodeName = Convert.ToString(sourceCodeCollection["SourceCodeName"][ctr]),
                    CommitName = Convert.ToString(sourceCodeCollection["CommitName"][ctr]),
                    CommitedBy = Convert.ToInt32(sourceCodeCollection["CommitedBy"][ctr]),
                    SourceCodeLocation = Convert.ToString(sourceCodeCollection["SourceCodeLocation"][ctr]),
                    SubmittedDate = Convert.ToDateTime(sourceCodeCollection["SubmittedDate"][ctr]),
                    TaskID = Convert.ToInt32(sourceCodeCollection["TaskID"][ctr])
                });
            }

            return result;
        }

        //fetches source code by taskId
        public static List<SourceCode> FetchSourceCodeByTaskID(int taskID)
        {
            List<SourceCode> result = new List<SourceCode>();

            var sourceCodeCollection = manager.FetchDistinctData("sourcecode", $"TaskID={taskID}", orderBy: "SubmittedDate Desc").Value;

            if(sourceCodeCollection==null)
            {
                return null;
            }

            for (int ctr = 0; sourceCodeCollection.Count > 0 && ctr < sourceCodeCollection["SourceCodeID"].Count; ctr++)
            {
                result.Add(new SourceCode()
                {
                    SourceCodeID = Convert.ToInt32(sourceCodeCollection["SourceCodeID"][ctr]),
                    CommitName = Convert.ToString(sourceCodeCollection["CommitName"][ctr]),
                    CommitedBy = Convert.ToInt32(sourceCodeCollection["CommitedBy"][ctr]),
                    SourceCodeLocation = Convert.ToString(sourceCodeCollection["SourceCodeLocation"][ctr]),
                    SubmittedDate = Convert.ToDateTime(sourceCodeCollection["SubmittedDate"][ctr]),
                    TaskID = Convert.ToInt32(sourceCodeCollection["TaskID"][ctr])
                });
            }

            return result;
        }

        public static VersionSourceCode FetchVersionSourceCodeByVersionID(int versionID)
        {
            var result = manager.FetchData("versionsourcecode", $"VersionID={versionID}").Value;

            VersionSourceCode sourceCode = new VersionSourceCode()
            {
                VersionID = Convert.ToInt32(result["VersionID"][0]),
                DisplayName = Convert.ToString(result["DisplayName"][0]),
                SourceCodeName = Convert.ToString(result["SourceCodeName"][0]),
                VersionLocation = Convert.ToString(result["SourceCodeLocation"][0]),
                SubmissionDate = Convert.ToDateTime(result["SubmissionDate"][0])
            };

            return sourceCode;
        }

        public static void AddNotify(string header, string message, int assignedTo)
        {
            manager.InsertData("notification", new ParameterData[]
                {
                    new ParameterData("Header", header),
                    new ParameterData("Message", message),
                    new ParameterData("AssignedTo", assignedTo)
                });
        }

        public static TaskAttachment GetTaskAttachment(int taskID)
        {
            TaskAttachment result = new TaskAttachment();
            var attachments = manager.FetchData("taskattachment", $"TaskID={taskID}").Value;
            if (attachments == null)
            {
                return null;
            }

            result = new TaskAttachment()
            {
                TaskAttachmentID = Convert.ToInt32(attachments["AttachmentID"][0]),
                TaskID = Convert.ToInt32(attachments["TaskID"][0]),
                TaskAttachmentName = Convert.ToString(attachments["TaskAttachmentName"][0]),
                TaskAttachmentLocation = Convert.ToString(attachments["TaskAttachmentLocation"][0]),
                DisplayName = Convert.ToString(attachments["DisplayName"][0])
            };

            return result;
        }

        public static SourceCode GetTaskSource(int taskID)
        {
            SourceCode result = new SourceCode();
            var attachments = manager.FetchData("sourcecode", $"TaskID={taskID}", orderBy:"SubmittedDate", limitCount:1).Value;

                result = new SourceCode()
                {
                    SourceCodeID = Convert.ToInt32(attachments["SourceCodeID"][0]),
                    TaskID = Convert.ToInt32(attachments["TaskID"][0]),
                    CommitedBy = Convert.ToInt32(attachments["CommitedBy"][0]),
                    CommitName = Convert.ToString(attachments["CommitName"][0]),
                    SourceCodeLocation = Convert.ToString(attachments["SourceCodeLocation"][0]),
                    SourceCodeName = Convert.ToString(attachments["SourceCodeName"][0]),
                };

            return result;
        }

        public static List<Notification> FetchNotification()
        {
            List<Notification> result = new List<Notification>();
            var notifyCollection = manager.FetchData("notification", $"AssignedTo={EmployeeManager.CurrentEmployee.EmployeeID}").Value;

            if (notifyCollection == null) return null;

            for (int ctr = 0; notifyCollection.Count > 0 && ctr < notifyCollection["NotifyID"].Count; ctr++)
            {
                result.Add(new Notification()
                {
                    NotificationId = Convert.ToInt32(notifyCollection["NotifyID"][ctr]),
                    NotificationHeader = Convert.ToString(notifyCollection["Header"][ctr]),
                    NotificationContent = Convert.ToString(notifyCollection["Content"][ctr]),
                    AssignedTo = Convert.ToInt32(notifyCollection["AssignedTo"][ctr]),
                    NotificationDateTime = Convert.ToDateTime(notifyCollection["NotifyDate"][ctr])
                });
            }

            return result;
        }

        public static List<Employee> StoreEmployeeDetails()
        {
            var result = manager.FetchData("employee", "").Value;
            List<Employee> employeeResult = new List<Employee>();

            if (result == null) return null;

            for (int ctr = 0; result.Count > 0 && ctr < result["EmpID"].Count; ctr++)
            {
                employeeResult.Add(new Employee()
                {
                    EmployeeID = Convert.ToInt32(result["EmpID"][ctr]),
                    EmployeeFirstName = result["EmpFirstName"][ctr].ToString(),
                    EmployeeLastName = result["EmpLastName"][ctr].ToString(),
                    EmpRoleName = result["EmpDesignation"][ctr].ToString(),
                    EmpEmail = result["EmpEmail"][ctr].ToString(),
                    EmpDOB = Convert.ToDateTime(result["EmpDOB"][ctr]),
                    EmpProfileLocation = result["EmpProfileLocation"][ctr].ToString(),
                    EmpPassword = result["EmpPassword"][ctr].ToString()
                });
            }

            return employeeResult;
        }

        public static List<ManagingEmployee> StoreEmployeeManagingDetails()
        {
            var result = manager.FetchData("projectmanaging", "").Value;
            List<ManagingEmployee> employeeManagingResult = new List<ManagingEmployee>();

            if (result == null) return null;

            for (int ctr = 0; result.Count > 0 && ctr < result["ProjectManagingID"].Count; ctr++)
            {
                employeeManagingResult.Add(new ManagingEmployee()
                {
                    ManagingEmployeeID = Convert.ToInt32(result["ProjectManagingID"][ctr]),
                    ManagerID = Convert.ToInt32(result["ManagerID"][ctr]),
                    TeamLeadID = Convert.ToInt32(result["TeamLeadID"][ctr]),
                    TeamMemberID = Convert.ToInt32(result["TeamMemberID"][ctr]),
                });
            }

            return employeeManagingResult;
        }

        public static List<Projects> StoreProjectDetails()
        {
            var result = manager.FetchData("project", "").Value;
            List<Projects> projectResult = new List<Projects>();

            if (result == null) return null;
            for (int ctr = 0; result.Count > 0 && ctr < result["ProjectID"].Count; ctr++)
            {
                projectResult.Add(new Projects()
                {
                    ProjectID = Convert.ToInt32(result["ProjectID"][ctr]),
                    ProjectName = Convert.ToString(result["ProjectName"][ctr]),
                    ManagerID = Convert.ToInt32(result["ManagerID"][ctr]),
                    TeamLeadID = Convert.ToInt32(result["TeamLeadID"][ctr]),
                });
            }
            return projectResult;
        }

        public static List<ProjectVersion> StoreProjectVersionDetails()
        {
            ProjectStatus status;
            string sts;
            var result = manager.FetchData("ProjectVersion", "").Value;

            if (result == null) return null;

            List<ProjectVersion> versionResult = new List<ProjectVersion>();
            for (int ctr = 0; result.Count > 0 && ctr < result["VersionID"].Count; ctr++)
            {
                sts = Convert.ToString(result["StatusOfProject"][ctr]);
                if (sts == "OnProcess")
                {
                    status = ProjectStatus.OnProcess;
                }
                else if (sts == "UpComing")
                {
                    status = ProjectStatus.UpComing;
                }
                else if(sts == "Deployment")
                {
                    status = ProjectStatus.Deployment;
                }
                else if(sts == "OnStage")
                {
                    status = ProjectStatus.OnStage;
                }
                else
                {
                    status = ProjectStatus.Completed;
                }

                versionResult.Add(new ProjectVersion()
                {
                    VersionID = Convert.ToInt32(result["VersionID"][ctr]),
                    VersionName = Convert.ToString(result["VersionName"][ctr]),
                    VersionDescription = Convert.ToString(result["VersionDesc"][ctr]),
                    ClientEmail = Convert.ToString(result["ClientEmail"][ctr]),
                    StartDate = Convert.ToDateTime(result["StartDate"][ctr]),
                    EndDate = Convert.ToDateTime(result["EndDate"][ctr]),
                    StatusOfVersion = status,
                    ProjectID = Convert.ToInt32(result["ProjectID"][ctr])
                });
            }

            return versionResult;
        }

        public static List<Task> StoreTaskDetails()
        {
            var result = manager.FetchData("task", "").Value;
            if (result == null) return null;

            List<Task> TaskCollection = new List<Task>();
            string status, priority;
            for (int ctr = 0; result.Count > 0 && ctr < result["TaskID"].Count; ctr++)
            {
                status = result["StatusOfTask"][ctr].ToString();
                priority = result["PriorityOfTask"][ctr].ToString();
                TaskCollection.Add(new Task()
                {
                    TaskID = Convert.ToInt32(result["TaskID"][ctr]),
                    TaskName = Convert.ToString(result["TaskName"][ctr]),
                    TaskDesc = Convert.ToString(result["TaskDesc"][ctr]),
                    StartDate = Convert.ToDateTime(result["StartDate"][ctr]),
                    EndDate = Convert.ToDateTime(result["EndDate"][ctr]),
                    AssignedBy = Convert.ToInt32(result["AssignedBy"][ctr]),
                    AssignedTo = Convert.ToInt32(result["AssignedTo"][ctr]),
                    StatusOfTask = (status == "NotYetStarted") ? TaskStatus.NotYetStarted : (status == "Stuck" ? TaskStatus.Stuck : (status == "OnProcess" ? TaskStatus.OnProcess : (status == "UnderReview"?TaskStatus.UnderReview:TaskStatus.Done))),
                    TaskPriority = (priority == "Critical") ? Priority.Critical : (priority == "Hard" ? Priority.Hard : (priority == "Medium" ? Priority.Medium : Priority.Easy)),
                    VersionID = Convert.ToInt32(result["VersionID"][ctr]),
                    MilestoneID = Convert.ToInt32(result["MilestoneID"][ctr])
                });
            }

            return TaskCollection;
        }

        public static List<Milestone> StoreMilestones()
        {
            var result = manager.FetchData("milestone", "").Value;

            if (result == null) return null;

            List<Milestone> MilestoneCollection = new List<Milestone>();
            string status;
            for (int ctr = 0; result.Count > 0 && ctr < result["MilestoneID"].Count; ctr++)
            {
                status = result["Status"][ctr].ToString();
                MilestoneCollection.Add(new Milestone()
                {
                    MileStoneID = Convert.ToInt32(result["MilestoneID"][ctr]),
                    MileStoneName = Convert.ToString(result["MilestoneName"][ctr]),
                    StartDate = Convert.ToDateTime(result["StartDate"][ctr]),
                    EndDate = Convert.ToDateTime(result["EndDate"][ctr]),
                    VersionID = Convert.ToInt32(result["VersionID"][ctr]),
                    Status = (status == "Completed") ? MilestoneStatus.Completed : ((status == "OnProcess") ? MilestoneStatus.OnProcess : ((status == "Upcoming") ? MilestoneStatus.Upcoming : MilestoneStatus.Delay))
                });
            }

            return MilestoneCollection;
        }

        
    }
}
