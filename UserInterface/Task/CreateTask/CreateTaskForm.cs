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
        private TransparentForm transparentForm;
        public event EventHandler TaskCreate;
        public event EventHandler TaskFormClose;

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            pictureBox1.Image?.Dispose();   pictureBox2.Image?.Dispose();   pictureBox3.Image?.Dispose();   pictureBoxAttachment.Image?.Dispose();   pictureBoxFlag.Image?.Dispose();
            BtnAssignTo.Image?.Dispose();
        }

        public CreateTaskForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            InitializePageColor();
            InitializePlaceHolders();
            toolTip1.SetToolTip(pictureBoxAttachment, "Click to Add attachment");
            toolTip1.SetToolTip(buttonSetMilestone, "Milestone");
            tableLayoutPanelFileName.Hide();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label2.ForeColor = ThemeManager.GetTextColor(panel3.BackColor);
            buttonCreate.BackColor = panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            buttonCreate.ForeColor = labelTitle.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);
            label4.ForeColor = label5.ForeColor = ThemeManager.GetTextColor(BackColor);
            labelSetPriority.BackColor = textBoxDesc.BackColor = textBoxTaskName.BackColor = buttonSetMilestone.BackColor = employeeName.BackColor = label1.BackColor = label3.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            startDate.SkinColor = endDate.SkinColor = tableLayoutPanel5.BackColor = tableLayoutPanelFileName.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            labelSetPriority.ForeColor = textBoxDesc.ForeColor = textBoxTaskName.ForeColor = buttonSetMilestone.ForeColor = employeeName.ForeColor = label1.ForeColor = label3.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            label2.ForeColor = startDate.TextColor = endDate.TextColor = startDate.BorderColor = endDate.BorderColor = animatedLabelFilename.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            panel3.BackColor = ThemeManager.CurrentTheme.SecondaryI;

            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Light : Properties.Resources.Heat_Close_Light;
            pictureBox2.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Dark : Properties.Resources.Heat_Close_Dark;
            pictureBox3.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Dark_Document : Properties.Resources.Heat_Dark_Document;
            pictureBoxAttachment.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Pin : Properties.Resources.Heat_Pin;
            BtnAssignTo.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Down_Dark : Properties.Resources.Heat_Down_Dark;
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

        private void OnClickSetMilestone(object sender, EventArgs e)
        {
            Point formPoint = buttonSetMilestone.PointToScreen(new Point(buttonSetMilestone.Location.X, buttonSetMilestone.Location.Y));

            MilestoneDropForm = new MilestoneDropDownForm();
            MilestoneDropForm.Location = buttonSetMilestone.PointToScreen(new Point(0, buttonSetMilestone.Height + 2));
            MilestoneDropForm.Size = new Size(buttonSetMilestone.Width, MilestoneDropForm.Height);
            MilestoneDropForm.Show();
            MilestoneDropForm.MilestoneList = MilestoneManager.FetchMilestones(VersionManager.CurrentVersion.VersionID);
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

        private void OnClickAssignBtn(object sender, EventArgs e)
        {
            List<Employee> taskAssigneeList = EmployeeManager.FetchTeamMembersForTeamLeaders();
            taskAssigneeList.Add(EmployeeManager.CurrentEmployee);

            Point formPoint = label2.PointToScreen(new Point(0,label2.Height));
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
            //TeamMembersDropForm.Close();
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
            PriortyDropForm.Location = tableLayoutPanel5.PointToScreen(new Point(-10, tableLayoutPanel5.Height + 2));
            PriortyDropForm.Size = new Size(tableLayoutPanel5.Width + 20, PriortyDropForm.Height);
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
                    ProjectManagerMainForm.notify.AddNotification("Task Created", "Task Has Been Assigned To " + selectedTeamMember.EmployeeFirstName);
                    DataHandler.AddNotification("New Task Assigned: Action Required!", "Hello " + selectedTeamMember.EmployeeFirstName + ",\r\n\r\nWe hope this message finds you well. We are writing to inform you that a new task has been assigned to you. As a valued member of the team, your contribution to this task is essential for the projects success.", DateTime.Now, selectedTeamMember.EmployeeID);
                }
                else
                {
                    if (selectedTask.StatusOfTask == TeamTracker.TaskStatus.UnderReview)
                        TaskManager.UpdateTask(selectedTask.TaskID, textBoxTaskName.Text, textBoxDesc.Text, startDate.Value.Date, endDate.Value.Date, TeamTracker.TaskStatus.OnProcess, selectedMilestone.MileStoneID, selectedPriority, selectedTeamMember.EmployeeID, selectedAttachment);
                    else
                        TaskManager.UpdateTask(selectedTask.TaskID, textBoxTaskName.Text, textBoxDesc.Text, startDate.Value.Date, endDate.Value.Date, selectedTask.StatusOfTask, selectedMilestone.MileStoneID, selectedPriority, selectedTeamMember.EmployeeID, selectedAttachment);

                    ProjectManagerMainForm.notify.AddNotification("Project Updated", "Project Has Been Assigned To " + selectedTeamMember.EmployeeFirstName);
                    DataHandler.AddNotification("Task Updation: Action Required!", "Hello " + selectedTeamMember.EmployeeFirstName + ",\r\n\r\nWe hope this message finds you well. We are writing to inform you that a new task has been assigned to you. As a valued member of the team, your contribution to this task is essential for the projects success.", DateTime.Now, selectedTeamMember.EmployeeID);
                }
                TaskCreate?.Invoke(this, EventArgs.Empty);
                TaskFormClose?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message.Message);
            }
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            TaskFormClose?.Invoke(this, EventArgs.Empty);
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
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawRectangle(border, rec);
            e.Graphics.DrawLine(border, 245, 0, 245, 285);
            border.Dispose();
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();

            if ((sender as Control).Name == "pictureBox2")
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Dark_Hover : Properties.Resources.Heat_Close_Dark_Hover;
            }
            else
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Light_Hover : Properties.Resources.Heat_Close_Light_Hover;
            }
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();

            if ((sender as Control).Name == "pictureBox2")
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Dark : Properties.Resources.Heat_Close_Dark;
            }
            else
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Light : Properties.Resources.Heat_Close_Light;
            }
        }

        private const int CSDropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

        private void OnCreateMouseEnter(object sender, EventArgs e)
        {
            buttonCreate.BackColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.PrimaryI);
        }

        private void OnCreateMouseLeave(object sender, EventArgs e)
        {
            buttonCreate.BackColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        private void OnAssignedToMouseEnter(object sender, EventArgs e)
        {
            BtnAssignTo.Image?.Dispose();
            BtnAssignTo.Image = (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Down_Dark_Hover : Properties.Resources.Heat_Down_Dark_Hover;
        }

        private void OnAssignedToMouseLeave(object sender, EventArgs e)
        {
            BtnAssignTo.Image?.Dispose();
            BtnAssignTo.Image = (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Down_Dark : Properties.Resources.Heat_Down_Dark;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
