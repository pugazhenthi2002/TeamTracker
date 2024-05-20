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
using UserInterface.ViewPage;

namespace UserInterface.Edit_Project.Controls
{
    public partial class EditTask : UserControl
    {
        public List<TeamTracker.Task> TaskCollection { get; set; }
        public EditTask()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        public void InitializePageColor()
        {
            requiredEdit.ForeColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            textBoxDesc.BackColor = textBoxTaskName.BackColor = buttonSetMilestone.BackColor = tableLayoutPanel5.BackColor = employeeName.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label1.BackColor = label3.BackColor = tableLayoutPanelFileName.BackColor = boardBasePanel.BackColor = boardBaseManualPanel.BackColor = panel1.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            startDate.SkinColor = endDate.SkinColor = ThemeManager.CurrentTheme.SecondaryII;
            panel6.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            label4.ForeColor = label5.ForeColor = animatedLabelFilename.ForeColor = textBoxDesc.ForeColor = textBoxTaskName.ForeColor = manualEdit.ForeColor = buttonSetMilestone.ForeColor = labelSetPriority.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = label3.ForeColor = employeeName.ForeColor = startDate.TextColor = startDate.BorderColor = endDate.TextColor = endDate.BorderColor = requiredEdit.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label2.ForeColor = buttonUpdate.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            ucNotFound1.BackColor = ucNotFound2.BackColor = buttonDelete.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            buttonUpdate.ForeColor = ThemeManager.GetTextColor(buttonUpdate.BackColor);
            buttonDelete.ForeColor = ThemeManager.GetTextColor(buttonDelete.BackColor);

            ResetButton();

            BackBtn.Image?.Dispose();
            NextBtn.Image?.Dispose();
            BtnAssignTo.Image?.Dispose();
            pictureBox3.Image?.Dispose();
            pictureBox3.Image?.Dispose();
            pictureBoxAttachment.Image?.Dispose();

            BtnAssignTo.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Down_Dark : Properties.Resources.Heat_Down_Dark;
            pictureBox2.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Dark : Properties.Resources.Heat_Close_Dark;
            pictureBox3.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Dark_Document : Properties.Resources.Heat_Dark_Document;
            pictureBoxAttachment.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Pin : Properties.Resources.Heat_Pin;

            if (tabControl1.SelectedIndex == 0)
            {
                requiredEdit.ForeColor = manualEdit.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
                requiredEdit.BackColor = manualEdit.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            }
            else
            {
                requiredEdit.ForeColor = manualEdit.BackColor = ThemeManager.CurrentTheme.PrimaryI;
                requiredEdit.BackColor = manualEdit.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            BtnAssignTo.Image?.Dispose();   pictureBox2.Image?.Dispose();   pictureBox3.Image?.Dispose();   BackBtn.Image?.Dispose();   NextBtn.Image?.Dispose();
            pictureBoxAttachment.Image?.Dispose();  pictureBoxFlag.Image?.Dispose();

            BoardBaseClearControl();    BoardBaseManualPanelControlClear();
            ThemeManager.ThemeChange -= OnThemeChanged;
            BackBtn.Click -= OnBackClick;   NextBtn.Click -= OnNextClick;   BtnAssignTo.Click -= OnClickAssignBtn;  buttonSetMilestone.Click -= OnClickSetMilestone;
            labelSetPriority.Click -= OnClickSetPriority;   buttonDelete.Click -= OnTaskDelete; buttonUpdate.Click -= OnTaskUpdate; manualEdit.Click -= OnManualClick;
            panel2.Paint -= OnLineSeperatePaint;    panel5.Paint -= OnLineSeperatePaint;    panel7.Paint -= OnLineSeperatePaint;    panel8.Paint -= OnLineSeperatePaint;
            requiredEdit.Click -= OnRequiredClick; pictureBox2.Click -= OnClickCloseFile;   pictureBoxAttachment.Click -= OnClickAddAttachment; searchTask1.TaskNameChange -= OnTaskNameChanged;
        }

        public void InitializePage()
        {
            SuspendLayout();
            if (tabControl1.SelectedIndex == 0)
            {
                requiredTaskCollection = TaskManager.FetchEditTask();
                InitializeRequiredControl();
            }
            else
            {
                taskCollection = TaskCollection;
                InitializeManualControl();
            }
            ResumeLayout();
        }

        private void OnTaskNameChanged(object sender, string e)
        {
            SuspendLayout();
            taskCollection = new List<TeamTracker.Task>();
            foreach(var Iter in TaskCollection)
            {
                if (Iter.TaskName.Contains(e))
                {
                    taskCollection.Add(Iter);
                }
            }
            InitializeManualControl();
            ResumeLayout();
        }

        private void InitializeRequiredControl()
        {
            taskCollection = requiredTaskCollection;

            startIdx = 0; isBackEnable = false;
            endIdx = taskCollection.Count >= 5 ? 4 : taskCollection.Count - 1;
            isNextEnable = taskCollection.Count > 5 ? true : false;

            if (taskCollection.Count == 0)
            {
                ucNotFound1.Visible = true; boardBasePanel.Visible = false;
                return;
            }
            else
            {
                ucNotFound1.Visible = false;    boardBasePanel.Visible = true;
            }

            BoardBaseClearControl();

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

        private void BoardBaseClearControl()
        {
            for(int ctr = 0; ctr < boardBasePanel.Controls.Count; ctr++)
            {
                (boardBasePanel.Controls[ctr] as UCTaskBoard).TaskSelect -= OnTaskSelected;
                (boardBasePanel.Controls[ctr] as UCTaskBoard).Dispose();
                ctr--;
            }
        }

        private void InitializeManualControl()
        {
            startIdx = 0; isBackEnable = false;
            endIdx = taskCollection.Count >= 5 ? 4 : taskCollection.Count - 1;
            isNextEnable = taskCollection.Count > 5 ? true : false;

            if (taskCollection.Count == 0)
            {
                ucNotFound2.Visible = true; boardBaseManualPanel.Visible = false; panel1.Visible = false;
                return;
            }
            else
            {
                ucNotFound2.Visible = false; boardBaseManualPanel.Visible = true; panel1.Visible = true;
            }

            BoardBaseManualPanelControlClear();

            for (int ctr = 0; ctr <= endIdx; ctr++)
            {
                template = new UCTaskBoard()
                {
                    Dock = DockStyle.Left,
                    TaskData = taskCollection[ctr]
                };
                template.TaskSelect += OnTaskSelected;
                boardBaseManualPanel.Controls.Add(template);
            }

            foreach (Control Iter in boardBaseManualPanel.Controls)
            {
                Iter.BringToFront();
            }
        }

        private void BoardBaseManualPanelControlClear()
        {
            for (int ctr = 0; ctr < boardBaseManualPanel.Controls.Count; ctr++)
            {
                (boardBaseManualPanel.Controls[ctr] as UCTaskBoard).TaskSelect -= OnTaskSelected;
                (boardBaseManualPanel.Controls[ctr] as UCTaskBoard).Dispose();
                ctr--;
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
            MilestoneDropForm.IsEditModeOn = true;
            MilestoneDropForm.StartPosition = FormStartPosition.CenterScreen;
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
            PriortyDropForm.StartPosition = FormStartPosition.CenterScreen;
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
            TeamMembersDropForm.StartPosition = FormStartPosition.CenterScreen;
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

            if (!(VersionManager.FetchVersionFromVersionID(selectedTask.VersionID).StartDate <= startDate.Value.Date && endDate.Value.Date <= VersionManager.FetchVersionFromVersionID(selectedTask.VersionID).EndDate))
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

        private void OnTaskUpdate(object sender, EventArgs e)
        {
            BooleanMsg message = CheckConstraints();
            if (message)
            {
                WarningForm form = new WarningForm();
                form.Content = "Are you sure, you want to update the Task?";
                form.WarningStatus += OnUpdateStatus;

                transparentForm = new TransparentForm();
                transparentForm.Show();
                transparentForm.ShowForm(form);
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message.Message);
            }
        }

        private void OnUpdateStatus(object sender, bool e)
        {
            (sender as WarningForm).WarningStatus -= OnUpdateStatus;
            (sender as WarningForm).Dispose();
            (sender as WarningForm).Close();

            if (e)
            {
                TaskManager.UpdateTask(selectedTask.TaskID, textBoxTaskName.Text, textBoxDesc.Text, startDate.Value.Date, endDate.Value.Date, selectedTask.StatusOfTask, selectedMilestone.MileStoneID, selectedPriority, selectedTeamMember.EmployeeID, selectedAttachment);
                DataHandler.RemoveEdit(selectedTask.TaskID, EditMode.Task);
                foreach(var Iter in TaskCollection)
                {
                    if(Iter.TaskID == selectedTask.TaskID)
                    {
                        Iter.TaskName = textBoxTaskName.Text; Iter.TaskDesc = textBoxDesc.Text;
                        Iter.StartDate = startDate.Value.Date; Iter.EndDate = endDate.Value.Date;
                        Iter.TaskPriority = selectedPriority; Iter.AssignedTo = selectedTeamMember.EmployeeID;
                        Iter.StatusOfTask = selectedTask.StatusOfTask;
                        Iter.MilestoneID = selectedMilestone.MileStoneID;
                        Iter.IsDelayed = true;
                    }
                }
                InitializePage();
            }
        }

        private void OnTaskDelete(object sender, EventArgs e)
        {
            WarningForm form = new WarningForm();
            form.Content = "Are you sure, you want to update the Task?";
            form.WarningStatus += OnDeleteStatus;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnDeleteStatus(object sender, bool e)
        {
            (sender as WarningForm).WarningStatus -= OnDeleteStatus;
            (sender as WarningForm).Dispose();
            (sender as WarningForm).Close();

            if (e)
            {
                TaskManager.DeleteTask(selectedTask.TaskID);
                DataHandler.RemoveEdit(selectedTask.MilestoneID, EditMode.Task);
                foreach (var Iter in TaskCollection)
                {
                    if (Iter.TaskID == selectedTask.TaskID)
                    {
                        TaskCollection.Remove(Iter);
                        return;
                    }
                }
                InitializePage();
            }
        }

        private void OnNextClick(object sender, EventArgs e)
        {
            if(isNextEnable)
            {
                startIdx++; endIdx++;
                ReorderControl();
            }
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            if (isBackEnable)
            {
                startIdx--; endIdx--;
                ReorderControl();
            }
        }

        private void ReorderControl()
        {
            if(tabControl1.SelectedIndex == 0)
            {
                for (int ctr = startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
                {
                    (boardBasePanel.Controls[idx] as UCTaskBoard).TaskData = taskCollection[ctr];
                }
            }
            else
            {
                for (int ctr = startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
                {
                    (boardBaseManualPanel.Controls[idx] as UCTaskBoard).TaskData = taskCollection[ctr];
                }
            }
            isBackEnable = startIdx == 0 ? false : true;
            isNextEnable = endIdx == taskCollection.Count - 1 ? false : true;
            ResetButton();
        }

        private TransparentForm transparentForm;
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

        private void OnManualClick(object sender, EventArgs e)
        {
            requiredEdit.ForeColor = manualEdit.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            requiredEdit.BackColor = manualEdit.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            tabControl1.SelectedIndex = 1;
            InitializePage();
        }

        private void OnRequiredClick(object sender, EventArgs e)
        {
            requiredEdit.ForeColor = manualEdit.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            requiredEdit.BackColor = manualEdit.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            tabControl1.SelectedIndex = 0;
            InitializePage();
        }

        private void OnLineSeperatePaint(object sender, PaintEventArgs e)
        {
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(border, 0, (sender as Control).Height - 1, (sender as Control).Width, (sender as Control).Height - 1);
            border.Dispose();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "BackBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    BackBtn.Image = Properties.Resources.Cold_Left_Dark_Hover;
                }
                else
                {
                    BackBtn.Image = Properties.Resources.Heat_Left_Dark_Hover;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    NextBtn.Image = Properties.Resources.Cold_Right_Dark_Hover;
                }
                else
                {
                    NextBtn.Image = Properties.Resources.Heat_Right_Dark_Hover;
                }
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "BackBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    BackBtn.Image = isBackEnable ? Properties.Resources.Cold_Left_Dark : Properties.Resources.Cold_Left_Medium;
                }
                else
                {
                    BackBtn.Image = isBackEnable ? Properties.Resources.Heat_Left_Dark : Properties.Resources.Heat_Left_Medium;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    NextBtn.Image = isNextEnable ? Properties.Resources.Cold_Right_Dark : Properties.Resources.Cold_Right_Medium;
                }
                else
                {
                    NextBtn.Image = isNextEnable ? Properties.Resources.Heat_Right_Dark : Properties.Resources.Heat_Right_Medium;
                }
            }
        }

        private void ResetButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                BackBtn.Image = isBackEnable ? Properties.Resources.Cold_Left_Dark : Properties.Resources.Cold_Left_Medium;
                NextBtn.Image = isNextEnable ? Properties.Resources.Cold_Right_Dark : Properties.Resources.Cold_Right_Medium;
            }
            else
            {
                BackBtn.Image = isBackEnable ? Properties.Resources.Heat_Left_Dark : Properties.Resources.Heat_Left_Medium;
                NextBtn.Image = isNextEnable ? Properties.Resources.Heat_Right_Dark : Properties.Resources.Heat_Right_Medium;
            }
        }

        private int startIdx, endIdx;
    }
}
