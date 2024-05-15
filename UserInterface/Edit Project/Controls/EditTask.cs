using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;
using GoLibrary;
using System.IO;

namespace UserInterface.Edit_Project.Controls
{
    public partial class EditTask : UserControl
    {
        public EditTask()
        {
            InitializeComponent();
        }

        public void InitializePage()
        {
            requiredTaskCollection = TaskManager.FetchEditTask();
            InitializeRequiredControl();
        }

        private void OnTaskNameChanged(object sender, string e)
        {

        }

        private void InitializeRequiredControl()
        {
            if (tabControl1.SelectedIndex == 0)
                taskCollection = requiredTaskCollection;

            startIdx = 0; isBackEnable = false;
            endIdx = taskCollection.Count >= 5 ? 4 : taskCollection.Count - 1;
            isNextEnable = taskCollection.Count > 5 ? true : false;

            boardBasePanel.Controls.Clear();

            for (int ctr = 0; ctr <= endIdx; ctr++)
            {
                template = new UCTaskBoard()
                {
                    Dock = DockStyle.Left,
                    TaskData = taskCollection[ctr]
                };
                template.TaskSelect += OnTaskSelected;
                boardBasePanel.Controls.Add(template);
            }

            foreach (Control Iter in boardBasePanel.Controls)
            {
                Iter.BringToFront();
            }
        }

        private void OnTaskSelected(object sender, TeamTracker.Task e)
        {
            selectedTask = e;
            textBoxTaskName.Text = selectedTask.TaskName;
            textBoxDesc.Text = selectedTask.TaskDesc;
            var milestoneList = MilestoneManager.FetchMilestones(VersionManager.CurrentVersion.VersionID);
            foreach (var Iter in milestoneList)
            {
                if (Iter.MileStoneID == selectedTask.MilestoneID)
                {
                    selectedMilestone = Iter;
                    buttonSetMilestone.Text = Iter.MileStoneName;
                }
            }
            selectedTeamMember = EmployeeManager.FetchEmployeeFromID(selectedTask.AssignedTo);
            employeeName.Text = selectedTeamMember.EmployeeFirstName;
            startDate.Value = selectedTask.StartDate;
            endDate.Value = selectedTask.EndDate;
            labelSetPriority.Text = selectedTask.TaskPriority.ToString();
            SetFlag(selectedTask.TaskPriority);
            selectedAttachment = DataHandler.GetTaskAttachment(selectedTask.TaskID);
            tableLayoutPanelFileName.Visible = true;
            if (selectedAttachment != null)
            {
                animatedLabelFilename.Text = selectedAttachment.TaskAttachmentName;
            }
            else
            {
                tableLayoutPanelFileName.Visible = false;
            }
            buttonUpdate.Text = "Update";
        }

        private void SetFlag(Priority priority)
        {
            switch (priority)
            {
                case Priority.Critical: pictureBoxFlag.Image = Properties.Resources.Critical; break;
                case Priority.Hard: pictureBoxFlag.Image = Properties.Resources.Hard; break;
                case Priority.Medium: pictureBoxFlag.Image = Properties.Resources.Medium; break;
                case Priority.Easy: pictureBoxFlag.Image = Properties.Resources.Easy; break;
                default: pictureBoxFlag.Image = Properties.Resources.flag_empty; break;
            }
        }

        private void OnClickSetMilestone(object sender, EventArgs e)
        {
            Point formPoint = buttonSetMilestone.PointToScreen(new Point(buttonSetMilestone.Location.X, buttonSetMilestone.Location.Y));

            MilestoneDropForm = new MilestoneDropDownForm();
            MilestoneDropForm.Location = buttonSetMilestone.PointToScreen(new Point(0, buttonSetMilestone.Height + 2));
            MilestoneDropForm.Size = new Size(buttonSetMilestone.Width, MilestoneDropForm.Height);
            MilestoneDropForm.Show();
            MilestoneDropForm.MilestoneList = MilestoneManager.FetchMilestones(selectedTask.VersionID);
            MilestoneDropForm.MilestoneClick += OnClickMilestoneBtn;
        }

        private void OnClickMilestoneBtn(object sender, Milestone e)
        {
            if (e != null)
            {
                selectedMilestone = e;
                buttonSetMilestone.Text = e.MileStoneName;
                ProjectManagerMainForm.notify.AddNotification("Milestone Date", "For the selected Milestone - " + e.MileStoneName + "\nThe Milestone Start Date is Between " + e.StartDate.ToShortDateString() + " and " + e.EndDate.ToShortDateString());
            }
        }

        private void OnClickSetPriority(object sender, EventArgs e)
        {
            Point formPoint = labelSetPriority.PointToScreen(new Point(labelSetPriority.Location.X, labelSetPriority.Location.Y));

            PriortyDropForm = new PriorityDropDownForm();
            PriortyDropForm.Show();
            PriortyDropForm.Location = tableLayoutPanel5.PointToScreen(new Point(-10, tableLayoutPanel5.Height + 2));
            PriortyDropForm.Size = new Size(tableLayoutPanel5.Width + 20, PriortyDropForm.Height);
            PriortyDropForm.PrioritySelect += OnClickPriorityBtn;
        }

        private void OnClickPriorityBtn(object sender, Priority e)
        {
            SetFlag(e);
            selectedPriority = e;
            labelSetPriority.Text = e.ToString();
        }

        private void OnClickAssignBtn(object sender, EventArgs e)
        {
            List<Employee> taskAssigneeList = EmployeeManager.FetchTeamMembersForTeamLeaders();
            taskAssigneeList.Add(EmployeeManager.CurrentEmployee);

            Point formPoint = label2.PointToScreen(new Point(0, label2.Height));
            TeamMembersDropForm = new TeamMembersListForm();
            TeamMembersDropForm.Location = panel2.PointToScreen(new Point(-10, panel2.Height + 2));
            TeamMembersDropForm.Size = new Size(panel2.Width + 20, TeamMembersDropForm.Height);
            TeamMembersDropForm.Show();
            TeamMembersDropForm.TeamList = taskAssigneeList;
            TeamMembersDropForm.TeamMemberClick += OnClickTeamMember;
        }

        private void OnClickTeamMember(object sender, Employee e)
        {
            selectedTeamMember = e;
            Button clickedBtn = (sender as Button);
            employeeName.Text = e.EmployeeFirstName;
            TeamMembersDropForm.Dispose();
        }

        private void OnClickAddAttachment(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string safeFile = openFileDialog.SafeFileName;
                string extension = Path.GetExtension(openFileDialog.SafeFileName);

                selectedAttachment = new TaskAttachment()
                {
                    DisplayName = safeFile,
                    TaskAttachmentName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + extension,
                    TaskAttachmentLocation = selectedFilePath
                };
                tableLayoutPanelFileName.Show();
                animatedLabelFilename.Text = Path.GetFileNameWithoutExtension(safeFile);
            }
        }

        private void OnClickCloseFile(object sender, EventArgs e)
        {
            selectedAttachment = null;
            tableLayoutPanelFileName.Hide();
        }

        private BooleanMsg CheckConstraints()
        {
            if (textBoxTaskName.Text == "" || textBoxTaskName.Text == "Task Name")
            {
                return "Task Name has not been Entered";
            }

            if (textBoxTaskName.Text.Length > 50)
            {
                return "Task Name Length should be within 1 and 50";
            }

            if (textBoxDesc.Text == "" || textBoxDesc.Text == "Description")
            {
                return "Description has not been Entered";
            }

            if (selectedMilestone == null)
            {
                return "Milestone Has Not been Selected";
            }

            if (labelSetPriority.Text == "Set Priority")
            {
                return "Priority Has Not been Selected";
            }

            if (startDate.Value.Date > endDate.Value.Date)
            {
                return "Task Due Date is is Beyond Today's Date";
            }

            var x = endDate.Value.Date - startDate.Value.Date;

            if (!(VersionManager.CurrentVersion.StartDate <= startDate.Value.Date && endDate.Value.Date <= VersionManager.CurrentVersion.EndDate))
            {
                return "Task Due Date is Not Within the Projects End Date and StartDate";
            }

            if (!(selectedMilestone.StartDate <= startDate.Value.Date && endDate.Value.Date <= selectedMilestone.EndDate))
            {
                return "Task Due Date is Not Within the Milestones End Date and StartDate";
            }

            if (selectedAttachment == null)
            {
                return "Task Attachment Has not been Added";
            }

            if (selectedTeamMember == null)
            {
                return "Team Member has not been Selected";
            }

            return true;
        }

        private Priority selectedPriority;
        private UCTaskBoard template;
        private PriorityDropDownForm PriortyDropForm;
        private MilestoneDropDownForm MilestoneDropForm;
        private TeamMembersListForm TeamMembersDropForm;
        private Employee selectedTeamMember;
        private Milestone selectedMilestone;
        private TaskAttachment selectedAttachment;
        private List<TeamTracker.Task> requiredTaskCollection;
        private List<TeamTracker.Task> taskCollection;
        private TeamTracker.Task selectedTask;
        private bool isBackEnable, isNextEnable;

        private void OnTaskUpdate(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                TaskManager.UpdateTask()
                requiredTaskCollection.RemoveAll(t1 => t1.TaskID == selectedTask.TaskID);
            }
        }

        private void OnTaskDelete(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

            }
        }

        private int startIdx, endIdx;
    }
}
