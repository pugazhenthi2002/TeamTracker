using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Project_Manager_Main_Page;

namespace TeamTracker
{
    public partial class ProjectManagerMainForm : Form
    {
        public event EventHandler SignOut;

        public ProjectManagerMainForm()
        {
            InitializeComponent();
            InitializePage();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
            Icon = UserInterface.Properties.Resources.T;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void InitializePage()
        {
            myIssueLabel.Click += HighlightSelected;
            myIssuePicBox.Click += HighlightSelected;
            allIssueLabel.Click += HighlightSelected;
            allIssuePicBox.Click += HighlightSelected;
            myTaskPicBox.Click += HighlightSelected;
            myTaskLabel.Click += HighlightSelected;
            addTaskLabel.Click += HighlightSelected;
            addTaskPicBox.Click += HighlightSelected;
            addProjectLabel.Click += HighlightSelected;
            addProjectPictureBox.Click += HighlightSelected;
            viewProjectLabel.Click += HighlightSelected;
            viewProjectPictureBox.Click += HighlightSelected;
            homePictureBox.Click += HighlightSelected;
            homeLabel.Click += HighlightSelected;
            editLabel.Click += HighlightSelected;
            editPicBox.Click += HighlightSelected;

            notify = new NotificationManager();
            notify.BorderRadius = 30;
            notify.NotificationScreenTime = 10;
            notify.NotificationAlignment = FromNotificationAlignment.RightDown;
            profilePicAndName1.EmployeeProfile = EmployeeManager.CurrentEmployee;

            deadlineChecker = new Timer();
            deadlineChecker.Interval = 1000;
            deadlineChecker.Tick += OnDeadlineTicked;

            tabPage1.Visible = true;
            tabPage2.Visible = true;
            tabPage3.Visible = true;
            tabPage4.Visible = true;
            tabPage5.Visible = true;
            tabPage6.Visible = true;
            tabPage7.Visible = true;

            if (EmployeeManager.CurrentEmployee.EmpRoleName == "Project Manager")
            {
                panel2.Visible = panel7.Visible = false;
                tabControl1.SelectedIndex = 0;
                projectManagerHome1.InitializeProjectManagerHome();
            }
            else if (EmployeeManager.CurrentEmployee.EmpRoleName == "Team Lead")
            {
                panel5.Visible = false;
                teamLeadHome1.InitializeHomePage();
                tabControl1.SelectedIndex = 3;
            }
            else
            {
                teamMemberHome1.InitializePage();
                panel11.Visible = panel5.Visible = panel2.Visible = false;
                addProjectLabel.Visible = addProjectPictureBox.Visible = addTaskLabel.Visible = addTaskPicBox.Visible = false;
                tabControl1.SelectedIndex = 4;
            }

            IsEligibleToSwitchTab();
        }

        private void InitializePageColor()
        {
            panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            homeLabel.ForeColor = addProjectLabel.ForeColor = viewProjectLabel.ForeColor = addTaskLabel.ForeColor = myTaskLabel.ForeColor = myIssueLabel.ForeColor = allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            teamLeadHome1.BackColor = projectManagerHome1.BackColor = teamMemberHome1.BackColor = addProject1.BackColor = viewProjectTemplate1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            myTaskTemplate1.BackColor = addTask1.BackColor = ucMyIssue1.BackColor = ucViewAllIssue1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            headerPanel.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            profilePicAndName1.HoverColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryIII);
            profilePicAndName1.ProfileTextColor = ThemeManager.CurrentTheme.PrimaryI;
            logo1.LogoColor = profilePicAndName1.BorderColor = profilePicAndName1.NormalColor = ThemeManager.CurrentTheme.SecondaryIII;
            profilePicAndName1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;

            closePicBox.Image?.Dispose();
            closePicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Dark : UserInterface.Properties.Resources.Heat_Close_Dark;

            ResetTabSwitchLogo();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void OnDeadlineTicked(object sender, EventArgs e)
        {
            TaskManager.CheckTaskDeadline();
            MilestoneManager.CheckMilestoneDeadline();
            VersionManager.CheckVersionDeadline();
        }

        public event EventHandler ManagerClose;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            profilePicAndName1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profilePicAndName1.Width, profilePicAndName1.Height, profilePicAndName1.Height, profilePicAndName1.Height));
            profilePicAndName1.BorderRadius = profilePicAndName1.Height / 2;
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
        private void OnHeaderPanelPaint(object sender, PaintEventArgs e)
        {
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(0, headerPanel.Height), new Point(headerPanel.Width, headerPanel.Height));
            border.Dispose();
        }

        private void OnNavMouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox picBox)
            {
                if (picBox.Image != null) { picBox.Image.Dispose(); }

                if (picBox.Name == "homePictureBox")
                {
                    homeLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                    picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold? UserInterface.Properties.Resources.Cold_Home_Light : UserInterface.Properties.Resources.Heat_Home_Light;
                }
                else if (picBox.Name == "addProjectPictureBox")
                {
                    addProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                    picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Add_Project_Light : UserInterface.Properties.Resources.Heat_Add_Project_Light;
                }
                else if(picBox.Name == "viewProjectPictureBox")
                {
                    viewProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                    picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_View_Project_Light : UserInterface.Properties.Resources.Heat_View_Project_Light;
                }
                else if(picBox.Name == "addTaskPicBox")
                {
                    addTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                    picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Add_Task_Light : UserInterface.Properties.Resources.Heat_Add_Task_Light;
                }
                else if (picBox.Name == "myTaskPicBox")
                {
                    myTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                    picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_My_Task_Light : UserInterface.Properties.Resources.Heat_My_Task_Light;
                }
                else if (picBox.Name == "myIssuePicBox")
                {
                    myIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                    picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_My_Issue_Light : UserInterface.Properties.Resources.Heat_My_Issue_Light;
                }
                else if (picBox.Name == "allIssuePicBox")
                {
                    allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                    picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_All_Issue_Light : UserInterface.Properties.Resources.Heat_All_Issue_Light;
                }
                else if (picBox.Name == "editPicBox")
                {
                    editLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                    picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Edit_Light : UserInterface.Properties.Resources.Heat_Edit_Light;
                }
            }
            else
            {
                Label label = (Label)sender;

                if (label.Name == "homeLabel" && !isHomeSelected)
                {
                    if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
                    homePictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Home_Light : UserInterface.Properties.Resources.Heat_Home_Light;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
                else if (label.Name == "addProjectLabel" && !isAddProjSelected)
                {
                    if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
                    addProjectPictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Add_Project_Light : UserInterface.Properties.Resources.Heat_Add_Project_Light;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
                else if(label.Name == "viewProjectLabel" && !isViewProjSelected)
                {
                    if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
                    viewProjectPictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_View_Project_Light : UserInterface.Properties.Resources.Heat_View_Project_Light;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
                else if(label.Name == "addTaskLabel" && !isAddTaskSelected)
                {
                    if (addTaskPicBox.Image != null) { addTaskPicBox.Image.Dispose(); }
                    addTaskPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Add_Task_Light : UserInterface.Properties.Resources.Heat_Add_Task_Light;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
                else if (label.Name == "myTaskLabel" && !isMyTaskSelected)
                {
                    if (myTaskPicBox.Image != null) { myTaskPicBox.Image.Dispose(); }
                    myTaskPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_My_Task_Light : UserInterface.Properties.Resources.Heat_My_Task_Light;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
                else if(label.Name == "myIssueLabel" && !isMyIssueSelected)
                {
                    if (myIssuePicBox.Image != null) { myIssuePicBox.Image.Dispose(); }
                    myIssuePicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_My_Issue_Light : UserInterface.Properties.Resources.Heat_My_Issue_Light;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
                else if (label.Name == "allIssueLabel" && !isAllIssueSelected)
                {
                    if (allIssuePicBox.Image != null) { allIssuePicBox.Image.Dispose(); }
                    allIssuePicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_All_Issue_Light : UserInterface.Properties.Resources.Heat_All_Issue_Light;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
                else if(label.Name == "editLabel" && !isEditSelected)
                {
                    if (editPicBox.Image != null) { editPicBox.Image.Dispose(); }
                    editPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Edit_Light : UserInterface.Properties.Resources.Heat_Edit_Light;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
            }
        }

        private void OnNavMouseLeave(object sender, EventArgs e)
        {
            ResetTabSwitchLogo();
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            if (closePicBox.Image != null) {  closePicBox.Image.Dispose(); }
            closePicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Dark_Hover : UserInterface.Properties.Resources.Heat_Close_Dark_Hover;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (closePicBox.Image != null) { closePicBox.Image.Dispose(); }
            closePicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Dark : UserInterface.Properties.Resources.Heat_Close_Dark;
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            ManagerClose?.Invoke(this, e);
        }

        private void OnHomeClicked(object sender, EventArgs e)
        {
            if (EmployeeManager.CurrentEmployee.EmpRoleName == "Project Manager")
            {
                tabControl1.SelectedIndex = 0;
                projectManagerHome1.InitializeProjectManagerHome();
            }
            else if (EmployeeManager.CurrentEmployee.EmpRoleName == "Team Lead")
            {
                teamLeadHome1.InitializeHomePage();
                tabControl1.SelectedIndex = 3;
            }
            else
            {
                teamMemberHome1.InitializePage();
                tabControl1.SelectedIndex = 4;
            }
        }

        private void OnAddProjectClicked(object sender, EventArgs e)
        {
            addProject1.InitializePage();
            tabControl1.SelectedIndex = 1;
        }

        private void OnMyIssueClicked(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;
        }

        private void OnAllIssueClicked(object sender, EventArgs e)
        {
            ucViewAllIssue1.InitializePage();
            tabControl1.SelectedIndex = 8;
        }
        private void OnViewProjectClicked(object sender, EventArgs e)
        {
            viewProjectTemplate1.InitializeViewProject();
            tabControl1.SelectedIndex = 2;
        }

        private void OnSignOut(object sender, EventArgs e)
        {
            SignOutForm form = new SignOutForm();
            form.Width = profilePicAndName1.Width;
            form.Location = profilePicAndName1.PointToScreen(new Point(0, profilePicAndName1.Height + 1));
            form.SignOut += OnFormSignOut;
            form.Show();
        }

        private void OnFormSignOut(object sender, EventArgs e)
        {
            SignOut?.Invoke(this, EventArgs.Empty);
        }

        private void HighlightSelected(object sender, EventArgs e)
        {
            IsEligibleToSwitchTab();

            isHomeSelected = isAddTaskSelected = isAddProjSelected = isViewProjSelected = isMyTaskSelected = isAllIssueSelected = isMyIssueSelected = isEditSelected = false;
            string text = (sender as Control).Name;

            if (text == "homeLabel" || text == "homePictureBox")
            {
                isHomeSelected = true;
            }
            else if(text == "addProjectPictureBox" || text == "addProjectLabel")
            {
                isAddProjSelected = true;
            }
            else if(text == "viewProjectLabel" || text == "viewProjectPictureBox")
            {
                isViewProjSelected = true;
            }
            else if((text == "addTaskLabel" || text == "addTaskPicBox") && isEligibleToSwitch)
            {
                isAddTaskSelected = true;
            }
            else if((text == "myTaskPicBox" || text == "myTaskLabel") &&  isEligibleToSwitch)
            {
                isMyTaskSelected = true;
            }
            else if(text == "myIssuePicBox" || text == "myIssueLabel")
            {
                isMyIssueSelected = true;
            }
            else if(text == "allIssuePicBox" || text == "allIssueLabel")
            {
                isAllIssueSelected = true;
            }
            else
            {
                isEditSelected = true;
            }
            ResetTabSwitchLogo();
        }

        private void OnMyTaskClick(object sender, EventArgs e)
        {
            if (isEligibleToSwitch)
            {
                myTaskTemplate1.InitializePage();
                tabControl1.SelectedIndex = 6;
            }
            else
            {
                notify.AddNotification("Warning", "Your Project Manager has been modified the Project Version.\nSo Kindly edit the Milestones and All the tasks related to it");
            }
        }

        private void OnAddTaskClick(object sender, EventArgs e)
        {
            if (isEligibleToSwitch)
            {
                addTask1.InitializePage();
                tabControl1.SelectedIndex = 5;
            }
            else
            {
                notify.AddNotification("Warning", "Your Project Manager has been modified the Project Version.\nSo Kindly edit the Milestones and All the tasks related to it");
            }
        }

        private void OnEditPageClicked(object sender, EventArgs e)
        {
            edit1.InitializePage();
            tabControl1.SelectedIndex = 9;
        }

        private void ResetTabSwitchLogo()
        {
            homePictureBox.Image?.Dispose();    addProjectPictureBox.Image?.Dispose();    viewProjectPictureBox.Image?.Dispose();    addTaskPicBox.Image?.Dispose();    
            myTaskPicBox.Image?.Dispose();    allIssuePicBox.Image?.Dispose();    myIssuePicBox.Image?.Dispose();    editPicBox.Image?.Dispose();    

            if (isHomeSelected)
            {
                homePictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Home_Light : UserInterface.Properties.Resources.Heat_Home_Light;
                homeLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else
            {
                homePictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Home_Medium : UserInterface.Properties.Resources.Heat_Home_Medium;
                homeLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            }

            if (isAddProjSelected)
            {
                addProjectPictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Add_Project_Light : UserInterface.Properties.Resources.Heat_Add_Project_Light;
                addProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else
            {
                addProjectPictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Add_Project_Medium : UserInterface.Properties.Resources.Heat_Add_Project_Medium;
                addProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            }

            if (isViewProjSelected)
            {
                viewProjectPictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_View_Project_Light : UserInterface.Properties.Resources.Heat_View_Project_Light;
                viewProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else
            {
                viewProjectPictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_View_Project_Medium : UserInterface.Properties.Resources.Heat_View_Project_Medum;
                viewProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            }

            if (isAddTaskSelected)
            {
                addTaskPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Add_Task_Light : UserInterface.Properties.Resources.Heat_Add_Task_Light;
                addTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else
            {
                addTaskPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Add_Task_Medium : UserInterface.Properties.Resources.Heat_Add_Task_Medium;
                addTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            }

            if (isMyTaskSelected)
            {
                myTaskPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_My_Task_Light : UserInterface.Properties.Resources.Heat_My_Task_Light;
                myTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else
            {
                myTaskPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_My_Task_Medium : UserInterface.Properties.Resources.Heat_My_Task_Medium;
                myTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            }

            if (isAllIssueSelected)
            {
                allIssuePicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_All_Issue_Light : UserInterface.Properties.Resources.Heat_All_Issue_Light;
                allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else
            {
                allIssuePicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_All_Issue_Medium : UserInterface.Properties.Resources.Heat_All_Issue_Medium;
                allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            }

            if (isMyIssueSelected)
            {
                myIssuePicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_My_Issue_Light : UserInterface.Properties.Resources.Heat_My_Issue_Light;
                myIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else
            {
                myIssuePicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_My_Issue_Medium : UserInterface.Properties.Resources.Heat_My_Issue_Medium;
                myIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            }

            if (isEditSelected)
            {
                editPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Edit_Light : UserInterface.Properties.Resources.Heat_Edit_Light;
                editLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else
            {
                editPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Edit_Medium : UserInterface.Properties.Resources.Heat_Edit_Medium;
                editLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            }
        }

        private void IsEligibleToSwitchTab()
        {
            if(VersionManager.CurrentVersion == null)
            {
                isEligibleToSwitch = true;
                return;
            }

            List<ProjectVersion> result1 = VersionManager.FetchEditVersions();
            foreach(var Iter in result1)
            {
                if(Iter.VersionID == VersionManager.CurrentVersion.VersionID)
                {
                    isEligibleToSwitch = false;
                    return;
                }
            }

            var result2 = TaskManager.FetchEditTask();
            foreach (var Iter in result2)
            {
                if (Iter.VersionID == VersionManager.CurrentVersion.VersionID)
                {
                    isEligibleToSwitch = false;
                    return;
                }
            }

            isEligibleToSwitch = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            SuspendLayout();
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            ResumeLayout();
        }

        static public NotificationManager notify;
        private Timer deadlineChecker;
        private bool isHomeSelected = false, isAddProjSelected = false, isViewProjSelected = false, isAddTaskSelected = false, isMyTaskSelected = false, isMyIssueSelected = false, isAllIssueSelected = false, isEditSelected = false;
        private bool isEligibleToSwitch = false;
    }
}
