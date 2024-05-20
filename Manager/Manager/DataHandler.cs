using DatabaseLibrary;
using GoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
            manager = new MySqlHandler("localhost", "root", "Lucid123", "teamtracker");
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

        public static List<Edit> FetchEditByMode(EditMode version)
        {
            var edit = manager.FetchData("edit", $"ModeOfEdit='{version.ToString()}'").Value;
            List<Edit> result = new List<Edit>();

            for (int ctr = 0; edit.Count > 0 && ctr < edit["EditID"].Count; ctr++)
            {
                string mode = Convert.ToString(edit["ModeOfEdit"][ctr]);
                result.Add(new Edit()
                {
                    EditID = Convert.ToInt32(edit["EditID"][ctr]),
                    EditModeID = Convert.ToInt32(edit["EditModeID"][ctr]),
                    ModeOfEdit = mode == "Task" ? EditMode.Task : EditMode.Version
                });
            }

            return result;
        }

        public static ProjectVersion AddVersion(ProjectVersion version)
        {
            var y = manager.ColumnExist("projectversion", "EndDate");
            var x = manager.InsertData("projectversion", new ParameterData[]
            {
                new ParameterData("ProjectID", version.ProjectID),
                new ParameterData("VersionName", version.VersionName),
                new ParameterData("VersionDesc", version.VersionDescription),
                new ParameterData("ClientEmail", version.ClientEmail),
                new ParameterData("StartDate", version.StartDate),
                new ParameterData("EndDate", version.EndDate),
                new ParameterData("StatusOfProject", version.StatusOfVersion.ToString()),
                new ParameterData("IsDelayed", version.IsDelayed.ToString())
            });

            var result = manager.FetchData("projectversion", $"VersionName='{version.VersionName}' AND ProjectID='{version.ProjectID}'").Value;
            version.VersionID = Convert.ToInt32(result["VersionID"][0]);

            return version;
        }

        public static SourceCode GetTaskSourceBySourceCodeID(int sourceCodeID)
        {
            SourceCode result = new SourceCode();
            var attachments = manager.FetchData("sourcecode", $"SourceCodeID={sourceCodeID}", orderBy: "SubmittedDate", limitCount: 1).Value;


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
                new ParameterData("AssignedTo", task.AssignedTo),
                new ParameterData("IsDelayed", task.IsDelayed.ToString()),
            });

            var result = manager.FetchData("task", "", orderBy: "TaskID desc", limitCount: 1).Value;

            task.TaskID = Convert.ToInt32(result["TaskID"][0]);

            return task;
        }

        public static List<Milestone> AddMilestones(int versionID, List<Milestone> milestoneCollections)
        {
            foreach (var Iter in milestoneCollections)
            {
                var x = manager.InsertData("milestone", new ParameterData[]
                {
                    new ParameterData("MilestoneName", Iter.MileStoneName),
                    new ParameterData("VersionID", versionID),
                    new ParameterData("StartDate", Iter.StartDate),
                    new ParameterData("EndDate", Iter.EndDate),
                    new ParameterData("Status", Iter.Status.ToString()),
                    new ParameterData("IsDelayed", Iter.IsDelayed.ToString())
                });
            }

            var result = manager.FetchData("milestone", $"VersionID='{versionID}'", orderBy: "EndDate").Value;

            for (int ctr = 0; ctr < result["MilestoneID"].Count; ctr++)
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
                    SourceCodeID = Convert.ToInt32(attachments["SourceCodeID"][ctr]),
                    SubmittedDate = Convert.ToDateTime(attachments["SubmittedDate"][ctr]),
                });
            }

            return result;
        }

        public static BooleanMsg DeleteSourceCode(int taskID)
        {
            var result = manager.FetchData("sourcecode", $"TaskID='{taskID}'", orderBy: "SubmittedDate", limitCount: 1).Value;

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

        public static void DeleteMilestone(int mileStoneID)
        {
            var x = manager.DeleteData("milestone", $"MilestoneID='{mileStoneID}'");
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
                new ParameterData("StatusOfProject", version.StatusOfVersion.ToString()),
                new ParameterData("IsDelayed", version.IsDelayed.ToString()),
            });
        }

        public static void DeleteVersionSourceCode(ProjectVersion iter)
        {
            var x = manager.DeleteData("versionsourcecode", $"versionsourcecode='{iter.VersionID}'");
        }

        public static void DeleteAllSourceCode(int taskID)
        {
            var x = manager.DeleteData("sourcecode", $"TaskID='{taskID}'");
        }

        public static void DeleteTaskAttachment(int taskID)
        {
            var x = manager.DeleteData("taskattachment", $"TaskID='{taskID}'");
        }

        public static void DeleteVersionAttachment(ProjectVersion iter)
        {
            var x = manager.DeleteData("versionattachment", $"VersionID='{iter.VersionID}'");
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
                new ParameterData("AssignedTo", task.AssignedTo),
                new ParameterData("IsDelayed", task.IsDelayed),
            });
        }

        public static void RemoveEdit(int editModeID, EditMode mode)
        {
            var x = manager.DeleteData("edit", $"EditModeID='{editModeID}' && ModeOfEdit='{mode.ToString()}'");
        }

        public static void DeleteVersion(ProjectVersion iter)
        {
            var x = manager.DeleteData("projectversion", $"VersionID ='{iter.VersionID}'");
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
                new ParameterData("IsDelayed", milestone.IsDelayed.ToString()),
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
                    new ParameterData("TaskAttachmentName", taskAttachment.DisplayName),
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
            string savePath = @"\\\\SPARE-2709DFQ\\Project Management Tool\\Version Attachment\\"; // Change this to your desired save path
            string filePath;
            var x = manager.DeleteData("versionattachment", $"VersionID='{versionID}'");

            if (versionAttachments != null)
            {
                foreach (var Iter in versionAttachments)
                {
                    filePath = System.IO.Path.Combine(savePath, Iter.AttachmentName);
                    
                    if (!Iter.AttachmentLocation.Contains("SPARE-2709DFQ"))
                    {
                        System.IO.File.Copy(Iter.AttachmentLocation, filePath, true);
                    }
                    manager.InsertData("versionattachment", new ParameterData[]
                    {
                        new ParameterData("VersionID", versionID),
                        new ParameterData("DisplayName", Iter.DisplayName),
                        new ParameterData("AttachmentName", Iter.AttachmentName),
                        new ParameterData("AttachmentLocation", filePath)
                    });
                }
            }
        }

        public static void UpdateTaskAttachment(int taskID, TaskAttachment taskAttachment)
        {
            if (taskAttachment == null) return;
            if (taskAttachment.TaskAttachmentLocation.Contains("SPARE-2709DFQ") && System.IO.File.Exists(taskAttachment.TaskAttachmentLocation))
                return;

            string savePath = @"\\\\SPARE-2709DFQ\\Project Management Tool\\Task Attachment\\";
            var x = manager.DeleteData("taskattachment", $"TaskID='{taskID}'");

            if (taskAttachment != null)
            {
                string filePath = System.IO.Path.Combine(savePath, taskAttachment.TaskAttachmentName);

                System.IO.File.Copy(taskAttachment.TaskAttachmentLocation, filePath, true);

                manager.InsertData("taskattachment", new ParameterData[]
                {
                    new ParameterData("TaskID", taskID),
                    new ParameterData("TaskAttachmentName", taskAttachment.DisplayName),
                    new ParameterData("TaskAttachmentLocation", filePath)
                });
            }
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

            for (int ctr = 0; attachments.Count > 0 && ctr < attachments["VersionAttachmentID"].Count; ctr++)
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

            var x = manager.FetchData("sourcecode", $"TaskID={taskID}", orderBy: "SubmittedDate Desc", limitCount: 1).Value;
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

            if (sourceCodeCollection == null)
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
            if (attachments == null || attachments.Count == 0)
            {
                return null;
            }

            result = new TaskAttachment()
            {
                TaskAttachmentID = Convert.ToInt32(attachments["AttachmentID"][0]),
                TaskID = Convert.ToInt32(attachments["TaskID"][0]),
                TaskAttachmentName = Convert.ToString(attachments["TaskAttachmentName"][0]),
                TaskAttachmentLocation = Convert.ToString(attachments["TaskAttachmentLocation"][0]),
            };

            return result;
        }

        public static SourceCode GetTaskSource(int taskID)
        {
            SourceCode result = new SourceCode();
            var attachments = manager.FetchData("sourcecode", $"TaskID={taskID}", orderBy: "SubmittedDate", limitCount: 1).Value;

            if (attachments.Count == 0)
                return null;

            result = new SourceCode()
            {
                SourceCodeID = Convert.ToInt32(attachments["SourceCodeID"][0]),
                TaskID = Convert.ToInt32(attachments["TaskID"][0]),
                CommitedBy = Convert.ToInt32(attachments["CommitedBy"][0]),
                CommitName = Convert.ToString(attachments["CommitName"][0]),
                SourceCodeLocation = Convert.ToString(attachments["SourceCodeLocation"][0]),
                SubmittedDate = Convert.ToDateTime(attachments["SubmittedDate"][0]),
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
                else if (sts == "Deployment")
                {
                    status = ProjectStatus.Deployment;
                }
                else if (sts == "OnStage")
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
                    ProjectID = Convert.ToInt32(result["ProjectID"][ctr]),
                    IsDelayed = Convert.ToString(result["IsDelayed"][ctr]) == "true" ? true : false
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
                    StatusOfTask = (status == "NotYetStarted") ? TaskStatus.NotYetStarted : (status == "Stuck" ? TaskStatus.Stuck : (status == "OnProcess" ? TaskStatus.OnProcess : (status == "UnderReview" ? TaskStatus.UnderReview : TaskStatus.Done))),
                    TaskPriority = (priority == "Critical") ? Priority.Critical : (priority == "Hard" ? Priority.Hard : (priority == "Medium" ? Priority.Medium : Priority.Easy)),
                    VersionID = Convert.ToInt32(result["VersionID"][ctr]),
                    MilestoneID = Convert.ToInt32(result["MilestoneID"][ctr]),
                    IsDelayed = Convert.ToString(result["IsDelayed"][ctr]) == "true" ? true : false
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
                    Status = (status == "Completed") ? MilestoneStatus.Completed : ((status == "OnProcess") ? MilestoneStatus.OnProcess : ((status == "Upcoming") ? MilestoneStatus.Upcoming : MilestoneStatus.Delay)),
                    IsDelayed = Convert.ToString(result["IsDelayed"][ctr]) == "true" ? true : false
                });
            }

            return MilestoneCollection;
        }

        public static IssueSolutionAttachment FetchIssueSolutionAttachment(int issueSolutionID)
        {
            IssueSolutionAttachment result = new IssueSolutionAttachment();
            var attachments = manager.FetchData("issuesolutionattachment", $"IssueSolutionID={issueSolutionID}").Value;
            if (attachments != null && attachments.Count == 0)
                return null;
            result = new IssueSolutionAttachment()
            {
                DisplayName = Convert.ToString(attachments["DisplayName"][0]),
                IssueSolnAttachmentID = Convert.ToInt32(attachments["IssueSolutionAttachmentID"][0]),
                IssueSolnAttachmentLocation = Convert.ToString(attachments["AttachmentLocation"][0]),
                IssueSolnAttachmentName = Convert.ToString(attachments["AttachmentName"][0]),
                IssueSolutionID = Convert.ToInt32(attachments["IssueSolutionID"][0])
            };

            return result;
        }

        public static List<Issue> StoreIssueDetails()
        {
            var result = manager.FetchData("issue", "").Value;

            if (result == null) return null;

            List<Issue> IssueCollection = new List<Issue>();
            string issuePriority, issueType;
            string tagString;

            for (int ctr = 0; result.Count > 0 && ctr < result["IssueID"].Count; ctr++)
            {
                issuePriority = result["Priority"][ctr].ToString();
                issueType = result["Type"][ctr].ToString();

                tagString = result["Tags"][ctr].ToString();
                string[] tagsArray = tagString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                IssueCollection.Add(new Issue()
                {
                    IssueID = Convert.ToInt32(result["IssueID"][ctr]),
                    PostedBy = Convert.ToInt32(result["PostedBy"][ctr]),
                    IssueName = Convert.ToString(result["Title"][ctr]),
                    IssueDesc = Convert.ToString(result["Description"][ctr]),
                    PostedDate = Convert.ToDateTime(result["Date"][ctr]),
                    Type = (issueType == "Bug") ? Issue.IssueType.Bug : ((issueType == "FeatureRequest") ? Issue.IssueType.FeatureRequest : ((issueType == "Optimization") ? Issue.IssueType.Optimization : ((issueType == "Security") ? Issue.IssueType.Security : ((issueType == "LogicalNeed") ? Issue.IssueType.LogicalNeed : Issue.IssueType.Other)))),
                    Priority = (issuePriority == "High") ? Issue.IssuePriority.High : ((issuePriority == "Medium") ? Issue.IssuePriority.Medium : Issue.IssuePriority.Low),
                    Tags = new List<string>(tagsArray)
                });
            }

            return IssueCollection;
        }

        public static List<IssueAttachment> StoreIssueAttachmentDetails()
        {
            var result = manager.FetchData("issueattachment", "").Value;

            if (result == null) return null;

            List<IssueAttachment> IssueAttachmentCollection = new List<IssueAttachment>();


            for (int ctr = 0; result.Count > 0 && ctr < result["IssueID"].Count; ctr++)
            {

                IssueAttachmentCollection.Add(new IssueAttachment()
                {
                    IssueAttachmentID = Convert.ToInt32(result["IssueAttachmentID"][ctr]),
                    IssueID = Convert.ToInt32(result["IssueID"][ctr]),
                    DisplayName = Convert.ToString(result["DisplayName"][ctr]),
                    IssueAttachmentName = Convert.ToString(result["AttachmentName"][ctr]),
                    IssueAttachmentLocation = Convert.ToString(result["Location"][ctr])

                });
            }

            return IssueAttachmentCollection;
        }

        public static IssueAttachment FetchIssueAttachementById(int id)
        {
            List<IssueAttachment> IssueAttachmentCollection = StoreIssueAttachmentDetails();

            foreach (IssueAttachment attachment in IssueAttachmentCollection)
            {
                if (attachment.IssueID == id)
                {
                    return attachment;
                }
            }

            return null;
        }

        public static List<IssueSolution> StoreIssueSolutionDetails()
        {
            var result = manager.FetchData("issuesolution", "").Value;

            if (result == null) return null;

            List<IssueSolution> IssueSolutionCollection = new List<IssueSolution>();


            for (int ctr = 0; result.Count > 0 && ctr < result["IssueID"].Count; ctr++)
            {

                IssueSolutionCollection.Add(new IssueSolution()
                {
                    IssueSolutionID = Convert.ToInt32(result["IssueSolutionID"][ctr]),
                    IssueID = Convert.ToInt32(result["IssueID"][ctr]),
                    Solution = Convert.ToString(result["Solution"][ctr]),
                    SolvedByID = Convert.ToInt32(result["SolvedBy"][ctr])

                });
            }

            return IssueSolutionCollection;
        }

        public static List<IssueSolutionAttachment> StoreIssueSolutionAttachmentDetails()
        {
            var result = manager.FetchData("issuesolutionattachment", "").Value;

            if (result == null) return null;

            List<IssueSolutionAttachment> IssueSolnAttachmentCollection = new List<IssueSolutionAttachment>();


            for (int ctr = 0; result.Count > 0 && ctr < result["IssueID"].Count; ctr++)
            {

                IssueSolnAttachmentCollection.Add(new IssueSolutionAttachment()
                {
                    IssueSolnAttachmentID = Convert.ToInt32(result["IssueSolutionAttachmentID"][ctr]),
                    IssueSolutionID = Convert.ToInt32(result["IssueSolutionID"][ctr]),
                    DisplayName = Convert.ToString(result["DisplayName"][ctr]),
                    IssueSolnAttachmentName = Convert.ToString(result["AttachmentName"][ctr]),
                    IssueSolnAttachmentLocation = Convert.ToString(result["Location"][ctr])

                });
            }

            return IssueSolnAttachmentCollection;
        }


        public static Issue AddIssue(Issue issue)
        {

            string tags = "";
            foreach (string str in issue.Tags)
            {
                tags += str + ",";
            }

            var x = manager.InsertData("issue", new ParameterData[]
            {
                new ParameterData("Title", issue.IssueName),
                new ParameterData("Description", issue.IssueDesc),
                new ParameterData("PostedBy", issue.PostedBy),
                new ParameterData("Priority", issue.Priority+""),
                new ParameterData("Type", issue.Type+""),
                new ParameterData("Date", issue.PostedDate.Date),
                new ParameterData("Tags", tags)
            }).Result;

            var result = manager.FetchData("issue", $"Title='{issue.IssueName}'").Value;
            issue.IssueID = Convert.ToInt32(result["IssueID"][0]);

            return issue;
        }

        public static void UpdateIssue(Issue issue)
        {
            string tags = "";
            foreach (string str in issue.Tags)
            {
                tags += str + ",";
            }
            var x = manager.UpdateData("issue", $"IssueID='{issue.IssueID}'", new ParameterData[]
            {
                new ParameterData("Title", issue.IssueName),
                new ParameterData("Description", issue.IssueDesc),
                new ParameterData("PostedBy", issue.PostedBy),
                new ParameterData("Date", issue.PostedDate),
                new ParameterData("Priority", issue.Priority+""),
                new ParameterData("Type", issue.Type+""),
                new ParameterData("Tags", tags)
            });
        }

        public static void RemoveIssue(Issue issue)
        {
            var x = manager.DeleteData("issue", $"IssueID='{issue.IssueID}'");
            RemoveAllSolutionOfIssue(issue);
        }

        public static void AddIssueAttachment(IssueAttachment attachment)
        {
            string savePath = @"\\\\SPARE-2709DFQ\\Project Management Tool\\Issue\\Issue Attachment\\"; // Change this to your desired save path
            try
            {
                string filePath = System.IO.Path.Combine(savePath, attachment.IssueAttachmentName);
                System.IO.File.Copy(attachment.IssueAttachmentLocation, filePath, true);

                manager.InsertData("issueattachment", new ParameterData[]
                {
                    new ParameterData("IssueID", attachment.IssueID),
                    new ParameterData("DisplayName", attachment.DisplayName),
                    new ParameterData("AttachmentName", attachment.IssueAttachmentName),
                    new ParameterData("Location", filePath)
                });
            }
            catch
            {
                ;
            }
        }

        public static void RemoveIssueAttachment(Issue issue)
        {
            var x = manager.DeleteData("issueattachment", $"IssueAttachmentID='{issue.IssueID}'");
        }

        public static void UpdateIssueAttachment(int issueId, IssueAttachment attachment)
        {

        }

        public static IssueSolution AddIssueSolution(IssueSolution issueSoln)
        {
            var result = manager.InsertData("issuesolution", new ParameterData[]
            {
                new ParameterData("IssueID", issueSoln.IssueID),
                new ParameterData("Solution", issueSoln.Solution),
                new ParameterData("SolvedBy", issueSoln.SolvedByID)

            }).Value;

            issueSoln.IssueSolutionID = Convert.ToInt32(result);

            return issueSoln;
        }

        public static void AddIssueSolutionAttachment(IssueSolutionAttachment attachment)
        {
            string savePath = @"\\\\SPARE-2709DFQ\\Project Management Tool\\Issue\\Issue Solution Attachment\\"; // Change this to your desired save path
            try
            {
                string filePath = System.IO.Path.Combine(savePath, attachment.IssueSolnAttachmentName);
                System.IO.File.Copy(attachment.IssueSolnAttachmentLocation, filePath, true);

                manager.InsertData("issuesolutionattachment", new ParameterData[]
                {
                    new ParameterData("IssueSolutionID", attachment.IssueSolutionID),
                    new ParameterData("DisplayName", attachment.DisplayName),
                    new ParameterData("AttachmentName", attachment.IssueSolnAttachmentName),
                    new ParameterData("AttachmentLocation", filePath)
                });
            }
            catch
            {
                ;
            }
        }



        public static void RemoveSolutionAttachment(IssueSolution issueSoln)
        {
            var x = manager.DeleteData("issuesolution", $"IssueSolutionID='{issueSoln.IssueSolutionID}'");
        }

        public static void RemoveSolution(IssueSolution issueSoln)
        {
            var x = manager.DeleteData("issuesolution", $"IssueSolutionID='{issueSoln.IssueSolutionID}'");
        }

        public static void RemoveAllSolutionOfIssue(Issue issue)
        {
            var x = manager.DeleteData("issuesolution", $"IssueID='{issue.IssueID}'");
        }

        public static void AddEdit(Edit edit)
        {
            var x = manager.DeleteData("edit", $"EditModeID='{edit.EditModeID}' && ModeOfEdit='{edit.ModeOfEdit}'");
            manager.InsertData("edit", new ParameterData[]
            {
                new ParameterData("EditModeID", edit.EditModeID),
                new ParameterData("ModeOfEdit", edit.ModeOfEdit.ToString()),
            });
        }

        public static void DeleteEdit(Edit edit)
        {
            var x = manager.DeleteData("edit", $"EditID='{edit.EditID}'");
        }

        public static void SendEmail(string mailTo)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("pugazhenthiir2002@gmail.com");
            message.To.Add(new MailAddress(mailTo));
            message.Subject = "Test";
            message.IsBodyHtml = true; //to make message body as html
            message.Body = @"
                <!DOCTYPE html>
                <html>
                <head>
                    <style>
                        body {
                            font-family: Arial, sans-serif;
                            line-height: 1.6;
                            color: #333;
                        }
                        .container {
                            width: 90%;
                            max-width: 600px;
                            margin: 0 auto;
                            padding: 20px;
                            border: 1px solid #ddd;
                            border-radius: 8px;
                            background-color: #f9f9f9;
                        }
                        .header {
                            background-color: #4CAF50;
                            color: white;
                            padding: 10px 0;
                            text-align: center;
                            border-radius: 8px 8px 0 0;
                        }
                        .content {
                            padding: 20px;
                        }
                        .footer {
                            margin-top: 20px;
                            text-align: center;
                            font-size: 12px;
                            color: #777;
                        }
                        .btn {
                            display: inline-block;
                            padding: 10px 20px;
                            margin-top: 20px;
                            font-size: 16px;
                            color: white;
                            background-color: #4CAF50;
                            text-decoration: none;
                            border-radius: 5px;
                        }
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <div class='header'>
                            <h1>Project Delivery</h1>
                        </div>
                        <div class='content'>
                            <p>Dear Client,</p>
                            <p>We are pleased to deliver the project you requested. Attached you will find the project files. If you have any questions or need further assistance, please do not hesitate to contact us.</p>
                            <p>Thank you for choosing our services.</p>
                            <p>Sincerely,</p>
                            <p>[Project Manager's Name]</p>
                            <a href='mailto:[MailTo]' class='btn'>Contact Us</a>
                        </div>
                        <div class='footer'>
                            <p>© [Year] Your Company. All rights reserved.</p>
                        </div>
                    </div>
                </body>
                </html>";
            message.Body = message.Body
                .Replace("[MailTo]", mailTo)
                .Replace("[Project Name]", "Awesome Project")
                .Replace("[Project Manager's Name]", EmployeeManager.CurrentEmployee.EmployeeFirstName + EmployeeManager.CurrentEmployee.EmployeeLastName)
                .Replace("[Year]", DateTime.Now.Year.ToString());

            string attachmentPath = @"C:\Users\pugaz\Downloads\IRJMETS60300120229-3.pdf";
            
            try
            {
                Attachment attachment = new Attachment(attachmentPath);
                message.Attachments.Add(attachment);

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("pugazhenthiir2002@gmail.com", "rewc jrha npss hrev");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch
            {

            }
        }
    }
}
