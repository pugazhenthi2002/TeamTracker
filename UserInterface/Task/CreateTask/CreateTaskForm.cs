using GoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Task.CreateTask
{
    public partial class CreateTaskForm : Form
    {
        public event EventHandler TaskCreate;
        public CreateTaskForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            toolTip1.SetToolTip(pictureBoxAttachment, "Click to Add attachment");
            toolTip1.SetToolTip(buttonSetMilestone, "Milestone");
            tableLayoutPanelFileName.Hide();
        }

        private TeamTracker.Task selectedTask;
        public TeamTracker.Task SelectedTask
        {
            set
            {
                selectedTask = value;
                InitializePage();
            }
        }

        private void InitializePage()
        {
            textBoxTaskName.TextBoxtext = selectedTask.TaskName;
            textBoxDesc.TextBoxtext = selectedTask.TaskDesc;
            var milestoneList = MilestoneManager.FetchMilestones(VersionManager.CurrentVersion.VersionID);
            foreach (var Iter in milestoneList)
            {
                if (Iter.MileStoneID == selectedTask.MilestoneID)
                {
                    selectedMilestone = Iter;
                    buttonSetMilestone.Text = Iter.MileStoneName;
                }
            }

            tableLayoutPanel3.Visible = false;
            employeeProfilePicAndName1.Profile = EmployeeManager.FetchEmployeeFromID(selectedTask.AssignedTo);
            startDate.Value = selectedTask.StartDate;
            endDate.Value = selectedTask.EndDate;
            labelSetPriority.Text = selectedTask.TaskPriority.ToString();
            SetFlag(selectedTask.TaskPriority);
            selectedAttachment = DataHandler.GetTaskAttachment(selectedTask.TaskID);
            tableLayoutPanelFileName.Visible = true;
            animatedLabelFilename.Text = selectedAttachment.DisplayName;
            buttonCreate.Text = "Update";
        }

        private TaskAttachment selectedAttachment;
        private Priority selectedPriority;
        private Milestone selectedMilestone = null;
        private Employee selectedTeamMember = null;
        private PriorityDropDownForm PriortyDropForm;
        private MilestoneDropDownForm MilestoneDropForm;
        private TeamMembersListForm TeamMembersDropForm;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );



        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            tableLayoutPanel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel4.Width, tableLayoutPanel4.Height, 20, 20));
            tableLayoutPanel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel5.Width, tableLayoutPanel5.Height, 20, 20));
            textBoxTaskName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxTaskName.Width, textBoxTaskName.Height, 10, 10));
            textBoxDesc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxDesc.Width, textBoxDesc.Height, 10, 10));
            buttonCreate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonCreate.Width, buttonCreate.Height, 10, 10));
            buttonClose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonClose.Width, buttonClose.Height, 10, 10));
            buttonSetMilestone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSetMilestone.Width, buttonSetMilestone.Height, 10, 10));
            buttonSetMilestone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSetMilestone.Width, buttonSetMilestone.Height, 10, 10));
            labelSetPriority.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelSetPriority.Width, labelSetPriority.Height, 10, 10));
            tableLayoutPanelFileName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanelFileName.Width, tableLayoutPanelFileName.Height, 10, 10));
        }

        private void OnClickPriorityBtn(object sender, Priority e)
        {
            SetFlag(e);
            selectedPriority = e;
            labelSetPriority.Text = e.ToString();
        }
        
        private void OnClickAddAttachment(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open File";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string safeFile = openFileDialog.SafeFileName;

                selectedAttachment = new TaskAttachment()
                {
                    DisplayName = safeFile,
                    TaskAttachmentName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".pdf",
                    TaskAttachmentLocation = selectedFilePath
                };
                tableLayoutPanelFileName.Show();
                animatedLabelFilename.Text = Path.GetFileNameWithoutExtension(safeFile);
            }
        }

        private void OnClickSetMilestone(object sender, EventArgs e)
        {
            Point formPoint = buttonSetMilestone.PointToScreen(new Point(buttonSetMilestone.Location.X, buttonSetMilestone.Location.Y));

            MilestoneDropForm = new MilestoneDropDownForm();
            MilestoneDropForm.MilestoneList = MilestoneManager.FetchMilestones(VersionManager.CurrentVersion.VersionID);
            MilestoneDropForm.Show();
            MilestoneDropForm.Location = new Point(formPoint.X - 3, formPoint.Y + buttonSetMilestone.Height);
            MilestoneDropForm.Size = new Size(buttonSetMilestone.Width, MilestoneDropForm.Height);

            MilestoneDropForm.MilestoneClick += OnClickMilestoneBtn;
        }

        private void OnClickMilestoneBtn(object sender, EventArgs e)
        {
            var milestoneList = MilestoneManager.FetchMilestones(VersionManager.CurrentVersion.VersionID);
            foreach (var Iter in milestoneList)
            {
                if(Iter.MileStoneName == (sender as Button).Text)
                {
                    selectedMilestone = Iter;
                    buttonSetMilestone.Text = Iter.MileStoneName;
                }
            }
        }

        private void OnClickAssignBtn(object sender, EventArgs e)
        {
            List<Employee> taskAssigneeList = EmployeeManager.FetchTeamMembersForTeamLeaders();
            taskAssigneeList.Add(EmployeeManager.CurrentEmployee);

            Point formPoint = label2.PointToScreen(new Point(0,label2.Height));
            TeamMembersDropForm = new TeamMembersListForm();
            TeamMembersDropForm.TeamList = taskAssigneeList;
            TeamMembersDropForm.Show();
            TeamMembersDropForm.Location = formPoint;
            TeamMembersDropForm.Size = new Size(buttonSetMilestone.Width, TeamMembersDropForm.Height);

            TeamMembersDropForm.TeamMemberClick += OnClickTeamMember;

        }

        private void OnClickTeamMember(object sender, Employee e)
        {
            selectedTeamMember = e;
            Button clickedBtn = (sender as Button);
            tableLayoutPanel3.Hide();
            employeeProfilePicAndName1.Profile = e;
            TeamMembersDropForm.Dispose();
        }

        private void OnClickCloseFile(object sender, EventArgs e)
        {
            selectedAttachment = null;
            tableLayoutPanelFileName.Hide();
        }
        
        private void OnClickSetPriority(object sender, EventArgs e)
        {
            Point formPoint = labelSetPriority.PointToScreen(new Point(labelSetPriority.Location.X, labelSetPriority.Location.Y));

            PriortyDropForm = new PriorityDropDownForm();
            PriortyDropForm.Show();
            PriortyDropForm.Location = new Point(formPoint.X - 45, formPoint.Y + labelSetPriority.Height + 2);
            PriortyDropForm.Size = new Size(labelSetPriority.Width, PriortyDropForm.Height);
            PriortyDropForm.PrioritySelect += OnClickPriorityBtn;
        }

        private void OnCreateClick(object sender, EventArgs e)
        {
            BooleanMsg message = CheckConstraints();
            if (message)
            {
                if(buttonCreate.Text == "Create")
                {
                    TaskManager.AddTask(textBoxTaskName.TextBoxtext, textBoxDesc.TextBoxtext, startDate.Value.Date, endDate.Value.Date, selectedMilestone.MileStoneID, selectedPriority, selectedTeamMember.EmployeeID, selectedAttachment);
                    ProjectManagerMainForm.notify.AddNotification("Project Created", "Project Has Been Assigned To " + selectedTeamMember.EmployeeFirstName);
                    DataHandler.AddNotification("Project Created", "Project Has Been Assigned To You", DateTime.Now, selectedTeamMember.EmployeeID);
                }
                else
                {
                    TaskManager.UpdateTask(selectedTask.TaskID, textBoxTaskName.TextBoxtext, textBoxDesc.TextBoxtext, startDate.Value.Date, endDate.Value.Date, selectedTask.StatusOfTask, selectedMilestone.MileStoneID, selectedPriority, selectedTeamMember.EmployeeID, selectedAttachment);
                    ProjectManagerMainForm.notify.AddNotification("Project Updated", "Project Has Been Assigned To " + selectedTeamMember.EmployeeFirstName);
                    DataHandler.AddNotification("Project Updated", "Project Has Been Assigned To You", DateTime.Now, selectedTeamMember.EmployeeID);
                }
                TaskCreate?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message.Message);
            }
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private BooleanMsg CheckConstraints()
        {
            if(textBoxTaskName.TextBoxtext == "" || textBoxTaskName.TextBoxtext == "Task Name")
            {
                return "Task Name has not been Entered";
            }

            if(textBoxDesc.TextBoxtext == "" || textBoxDesc.TextBoxtext == "Description")
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

            if (startDate.Value > endDate.Value)
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

            if(selectedTeamMember == null)
            {
                return "Team Member has not been Selected";
            }

            return true;
        }

        private void SetFlag(Priority priority)
        {
            switch (priority)
            {
                case Priority.Critical: pictureBoxFlag.Image = Properties.Resources.Critical; break;
                case Priority.Hard: pictureBoxFlag.Image = Properties.Resources.Hard; break;
                case Priority.Medium: pictureBoxFlag.Image = Properties.Resources.Medium; break;
                case Priority.Easy: pictureBoxFlag.Image = Properties.Resources.Easy; break;
                default: pictureBoxFlag.Image = Properties.Resources.flag_empty;break;
            }
        }
    }
}
