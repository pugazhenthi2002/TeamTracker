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
            InitializePlaceHolders();
            toolTip1.SetToolTip(pictureBoxAttachment, "Click to Add attachment");
            toolTip1.SetToolTip(buttonSetMilestone, "Milestone");
            tableLayoutPanelFileName.Hide();
        }

        private void InitializePlaceHolders()
        {
            textBoxDesc.GotFocus += RemoveDescPlaceHolders;
            textBoxDesc.LostFocus += AddDescPlaceHolders;
            textBoxTaskName.GotFocus += RemoveTaskPlaceHolders;
            textBoxTaskName.LostFocus += AddTaskPlaceHolders;
        }

        private void AddTaskPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTaskName.Text))
                textBoxTaskName.Text = "Enter Task Title..";
        }

        private void RemoveTaskPlaceHolders(object sender, EventArgs e)
        {
            if (textBoxTaskName.Text == "Enter Task Title..")
            {
                textBoxTaskName.Text = "";
            }
        }

        private void AddDescPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDesc.Text))
                textBoxDesc.Text = "Enter Task Description..";
        }

        private void RemoveDescPlaceHolders(object sender, EventArgs e)
        {
            if (textBoxDesc.Text == "Enter Task Description..")
            {
                textBoxDesc.Text = "";
            }
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

            tableLayoutPanel3.Visible = false;
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
                if (Iter.MileStoneName == (sender as Button).Text)
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
            employeeName.Text = e.EmployeeFirstName;
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
                    TaskManager.AddTask(textBoxTaskName.Text, textBoxDesc.Text, startDate.Value.Date, endDate.Value.Date, selectedMilestone.MileStoneID, selectedPriority, selectedTeamMember.EmployeeID, selectedAttachment);
                    ProjectManagerMainForm.notify.AddNotification("Project Created", "Project Has Been Assigned To " + selectedTeamMember.EmployeeFirstName);
                    DataHandler.AddNotification("Project Created", "Project Has Been Assigned To You", DateTime.Now, selectedTeamMember.EmployeeID);
                }
                else
                {
                    TaskManager.UpdateTask(selectedTask.TaskID, textBoxTaskName.Text, textBoxDesc.Text, startDate.Value.Date, endDate.Value.Date, selectedTask.StatusOfTask, selectedMilestone.MileStoneID, selectedPriority, selectedTeamMember.EmployeeID, selectedAttachment);
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
            if(textBoxTaskName.Text == "" || textBoxTaskName.Text == "Task Name")
            {
                return "Task Name has not been Entered";
            }

            if(textBoxTaskName.Text.Length > 50)
            {
                return "Task Name Length should be within 1 and 50";
            }

            if(textBoxDesc.Text == "" || textBoxDesc.Text == "Description")
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

        private void OnAssigneePanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1);
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawRectangle(border, rec);
            e.Graphics.DrawLine(border, 245, 0, 245, 285);
            border.Dispose();
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            if ((sender as Control).Name == "pictureBox2")
            {
                if (pictureBox2.Image != null) pictureBox2.Image.Dispose();

                pictureBox2.Image = Properties.Resources.Close_Light_Blue_Hover;
            }
            else
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

                pictureBox1.Image = Properties.Resources.Close_Dark_Blue_Hover;
            }
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            if ((sender as Control).Name == "pictureBox2")
            {
                if (pictureBox2.Image != null) pictureBox2.Image.Dispose();

                pictureBox2.Image = Properties.Resources.Close_Dark_Blue;
            }
            else
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

                pictureBox1.Image = Properties.Resources.Close_30;
            }
        }

        private void OnTextBoxBorderPaint(object sender, PaintEventArgs e)
        {

        }
    }
}
