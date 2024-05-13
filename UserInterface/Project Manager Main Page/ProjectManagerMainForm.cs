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
        public ProjectManagerMainForm()
        {
            InitializeComponent();
            InitializePage();
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
                panel5.Visible = panel2.Visible = false;
                addProjectLabel.Visible = addProjectPictureBox.Visible = addTaskLabel.Visible = addTaskPicBox.Visible = false;
                tabControl1.SelectedIndex = 4;
            }
        }

        private void InitializePageColor()
        {
            panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            homeLabel.ForeColor = addProjectLabel.ForeColor = viewProjectLabel.ForeColor = addTaskLabel.ForeColor = myTaskLabel.ForeColor = myIssueLabel.ForeColor = allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            headerPanel.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            profilePicAndName1.BorderColor = profilePicAndName1.NormalColor = ThemeManager.CurrentTheme.SecondaryIII;
            profilePicAndName1.HoverColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryIII);
            profilePicAndName1.ProfileTextColor = ThemeManager.CurrentTheme.PrimaryI;
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

                if (picBox.Name == "homePictureBox" && !isHomeSelected)
                {
                    homeLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                    picBox.Image = UserInterface.Properties.Resources.Home_Hover;
                }
                else if (picBox.Name == "addProjectPictureBox" && !isAddProjSelected)
                {
                    addProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                    picBox.Image = UserInterface.Properties.Resources.Add_Project_Hover;
                }
                else if(picBox.Name == "viewProjectPictureBox" && !isViewProjSelected)
                {
                    viewProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                    picBox.Image = UserInterface.Properties.Resources.View_Project_Hover;
                }
                else if(picBox.Name == "addTaskPicBox" && !isAddTaskSelected)
                {
                    addTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                    picBox.Image = UserInterface.Properties.Resources.Add_Task_30_Hover;
                }
                else if (picBox.Name == "myTaskPicBox" && !isMyTaskSelected)
                {
                    myTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                    picBox.Image = UserInterface.Properties.Resources.View_Task_30_Hover;
                }
                else if (picBox.Name == "myIssuePicBox" && !isMyIssueSelected)
                {
                    myIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                    picBox.Image = UserInterface.Properties.Resources.My_Issue_Hover;
                }
                else if (picBox.Name == "allIssuePicBox" && !isAllIssueSelected)
                {
                    allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                    picBox.Image = UserInterface.Properties.Resources.All_Issue_Hover;
                }
            }
            else
            {
                Label label = (Label)sender;

                if (label.Name == "homeLabel" && !isHomeSelected)
                {
                    if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
                    homePictureBox.Image = UserInterface.Properties.Resources.Home_Hover;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                }
                else if (label.Name == "addProjectLabel" && !isAddProjSelected)
                {
                    if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
                    addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project_Hover;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                }
                else if(label.Name == "viewProjectLabel" && !isViewProjSelected)
                {
                    if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
                    viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project_Hover;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                }
                else if(label.Name == "addTaskLabel" && !isAddTaskSelected)
                {
                    if (addTaskPicBox.Image != null) { addTaskPicBox.Image.Dispose(); }
                    addTaskPicBox.Image = UserInterface.Properties.Resources.Add_Task_30_Hover;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                }
                else if (label.Name == "myTaskLabel" && !isMyTaskSelected)
                {
                    if (myTaskPicBox.Image != null) { myTaskPicBox.Image.Dispose(); }
                    myTaskPicBox.Image = UserInterface.Properties.Resources.View_Task_30_Hover;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                }
                else if(label.Name == "myIssueLabel" && !isMyIssueSelected)
                {
                    if (myIssuePicBox.Image != null) { myIssuePicBox.Image.Dispose(); }
                    myIssuePicBox.Image = UserInterface.Properties.Resources.My_Issue_Hover;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                }
                else if (label.Name == "allIssueLabel" && !isAllIssueSelected)
                {
                    if (allIssuePicBox.Image != null) { allIssuePicBox.Image.Dispose(); }
                    allIssuePicBox.Image = UserInterface.Properties.Resources.All_Issue_Hover;
                    label.ForeColor = ThemeManager.CurrentTheme.SecondaryII;
                }
            }
        }

        private void OnNavMouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox picBox)
            {
                if (picBox.Image != null) { picBox.Image.Dispose(); }

                if (picBox.Name == "homePictureBox" && !isHomeSelected)
                {
                    homeLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                    picBox.Image = UserInterface.Properties.Resources.Home_Normal;
                }
                else if (picBox.Name == "addProjectPictureBox" && !isAddProjSelected)
                {
                    addProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                    picBox.Image = UserInterface.Properties.Resources.Add_Project;
                }
                else if (picBox.Name == "viewProjectPictureBox" && !isViewProjSelected)
                {
                    viewProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                    picBox.Image = UserInterface.Properties.Resources.View_Project;
                }
                else if (picBox.Name == "addTaskPicBox" && !isAddTaskSelected)
                {
                    addTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                    picBox.Image = UserInterface.Properties.Resources.Add_Task_30_Normal;
                }
                else if (picBox.Name == "myTaskPicBox" && !isMyTaskSelected)
                {
                    myTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                    picBox.Image = UserInterface.Properties.Resources.View_Task_30_Normal;
                }
                else if (picBox.Name == "myIssuePicBox" && !isMyIssueSelected)
                {
                    myIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                    picBox.Image = UserInterface.Properties.Resources.My_Issue_Normal;
                }
                else if (picBox.Name == "allIssuePicBox" && !isAllIssueSelected)
                {
                    allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                    picBox.Image = UserInterface.Properties.Resources.All_Issue_Normal;
                }
            }
            else
            {
                Label label = (Label)sender;
                if (label.Name == "homeLabel" && !isHomeSelected)
                {
                    if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
                    homePictureBox.Image = UserInterface.Properties.Resources.Home_Normal;
                    homeLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                }
                else if (label.Name == "addProjectLabel" && !isAddProjSelected)
                {
                    if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
                    addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project;
                    addProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                }
                else if (label.Name == "viewProjectLabel" && !isViewProjSelected)
                {
                    if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
                    viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project;
                    viewProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                }
                else if (label.Name == "addTaskLabel" && !isAddTaskSelected)
                {
                    if (addTaskPicBox.Image != null) { addTaskPicBox.Image.Dispose(); }
                    addTaskPicBox.Image = UserInterface.Properties.Resources.Add_Task_30_Normal;
                    addTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                }
                else if (label.Name == "myTaskLabel" && !isMyTaskSelected)
                {
                    if (myTaskPicBox.Image != null) { myTaskPicBox.Image.Dispose(); }
                    myTaskPicBox.Image = UserInterface.Properties.Resources.View_Task_30_Normal;
                    myTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                }
                else if (label.Name == "myIssueLabel" && !isMyIssueSelected)
                {
                    if (myIssuePicBox.Image != null) { myIssuePicBox.Image.Dispose(); }
                    myIssuePicBox.Image = UserInterface.Properties.Resources.My_Issue_Normal;
                    myIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                }
                else if (label.Name == "allIssueLabel" && !isAllIssueSelected)
                {
                    if (allIssuePicBox.Image != null) { allIssuePicBox.Image.Dispose(); }
                    allIssuePicBox.Image = UserInterface.Properties.Resources.All_Issue_Normal;
                    allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
                }
            }
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            if (closePicBox.Image != null) {  closePicBox.Image.Dispose(); }
            closePicBox.Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (closePicBox.Image != null) { closePicBox.Image.Dispose(); }
            closePicBox.Image = UserInterface.Properties.Resources.Close;
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
            this.Close();
        }

        private void HighlightSelected(object sender, EventArgs e)
        {
            isHomeSelected = isAddTaskSelected = isAddProjSelected = isViewProjSelected = isMyTaskSelected = isAllIssueSelected = isMyIssueSelected = false;

            if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
            if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
            if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
            if (addTaskPicBox.Image != null) { addTaskPicBox.Image.Dispose(); }
            if (myTaskPicBox.Image != null) { myTaskPicBox.Image.Dispose(); }
            if (myIssuePicBox.Image != null) { myIssuePicBox.Image.Dispose(); }
            if (allIssuePicBox.Image != null) { allIssuePicBox.Image.Dispose(); }

            homePictureBox.Image = UserInterface.Properties.Resources.Home_Normal;
            addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project;
            viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project;
            addTaskPicBox.Image = UserInterface.Properties.Resources.Add_Task_30_Normal;
            myTaskPicBox.Image = UserInterface.Properties.Resources.View_Task_30_Normal;
            myIssuePicBox.Image = UserInterface.Properties.Resources.My_Issue_Normal;
            allIssuePicBox.Image = UserInterface.Properties.Resources.All_Issue_Normal;

            homeLabel.ForeColor = addProjectLabel.ForeColor = viewProjectLabel.ForeColor = myTaskLabel.ForeColor = addTaskLabel.ForeColor = myIssueLabel.ForeColor = allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryI;
            string text = (sender as Control).Name;

            if (text == "homeLabel" || text == "homePictureBox")
            {
                isHomeSelected = true;
                if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
                homePictureBox.Image = UserInterface.Properties.Resources.Home_Hover;
                homeLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else if(text == "addProjectPictureBox" || text == "addProjectLabel")
            {
                isAddProjSelected = true;
                if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
                addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project_Hover;
                addProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else if(text == "viewProjectLabel" || text == "viewProjectPictureBox")
            {
                isViewProjSelected = true;
                if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
                viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project_Hover;
                viewProjectLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else if(text == "addTaskLabel" || text == "addTaskPicBox")
            {
                isAddTaskSelected = true;
                if (addTaskPicBox.Image != null) { addTaskPicBox.Image.Dispose(); }
                addTaskPicBox.Image = UserInterface.Properties.Resources.Add_Task_30_Hover;
                addTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else if(text == "myTaskPicBox" || text == "myTaskLabel")
            {
                isMyTaskSelected = true;
                if (myTaskPicBox.Image != null) { myTaskPicBox.Image.Dispose(); }
                myTaskPicBox.Image = UserInterface.Properties.Resources.View_Task_30_Hover;
                myTaskLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else if(text == "myIssuePicBox" || text == "myIssueLabel")
            {
                isMyIssueSelected = true;
                if (myIssuePicBox.Image != null) { myIssuePicBox.Image.Dispose(); }
                myIssuePicBox.Image = UserInterface.Properties.Resources.My_Issue_Hover;
                myIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
            else if(text == "allIssuePicBox" || text == "allIssueLabel")
            {
                isAllIssueSelected = true;
                if (allIssuePicBox.Image != null) { allIssuePicBox.Image.Dispose(); }
                allIssuePicBox.Image = UserInterface.Properties.Resources.All_Issue_Hover;
                allIssueLabel.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
            }
        }

        private void OnMyTaskClick(object sender, EventArgs e)
        {
            myTaskTemplate1.InitializePage();
            tabControl1.SelectedIndex = 6;
        }

        private void OnAddTaskClick(object sender, EventArgs e)
        {
            addTask1.InitializePage();
            tabControl1.SelectedIndex = 5;
        }

        static public NotificationManager notify;
        private Timer deadlineChecker;
        private bool isHomeSelected = false, isAddProjSelected = false, isViewProjSelected = false, isAddTaskSelected = false, isMyTaskSelected = false, isMyIssueSelected = false, isAllIssueSelected = false;
    }
}
