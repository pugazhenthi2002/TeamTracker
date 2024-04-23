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
        static public NotificationManager notify;
        private bool isHomeSelected = false, isAddProjSelected = false, isViewProjSelected = false, isAddTaskSelected = false, isMyTaskSelected = false;
        public ProjectManagerMainForm()
        {
            InitializeComponent();
            InitializePage();
            //tabControl1.Visible = false;
            tabControl1.SuspendLayout();
        }

        private void InitializePage()
        {
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

            tabPage1.Visible = true;
            tabPage2.Visible = true;
            tabPage3.Visible = true;
            tabPage4.Visible = true;
            tabPage5.Visible = true;
            tabPage6.Visible = true;
            tabPage7.Visible = true;
        }

        public event EventHandler ManagerClose;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            

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
            //projectManagerHome1.SuspendLayout();
            //tabControl1.Visible = true;
            //projectManagerHome1.ResumeLayout();
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            profilePicAndName1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profilePicAndName1.Width, profilePicAndName1.Height, profilePicAndName1.Height, profilePicAndName1.Height));
            profilePicAndName1.BorderRadius = profilePicAndName1.Height / 2;
            //panel8.Invalidate();
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
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
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
                    homeLabel.ForeColor = Color.FromArgb(221, 230, 237);
                    picBox.Image = UserInterface.Properties.Resources.Home_Hover;
                }
                else if (picBox.Name == "addProjectPictureBox" && !isAddProjSelected)
                {
                    addProjectLabel.ForeColor = Color.FromArgb(221, 230, 237);
                    picBox.Image = UserInterface.Properties.Resources.Add_Project_Hover;
                }
                else if(picBox.Name == "viewProjectPictureBox" && !isViewProjSelected)
                {
                    viewProjectLabel.ForeColor = Color.FromArgb(221, 230, 237);
                    picBox.Image = UserInterface.Properties.Resources.View_Project_Hover;
                }
                else if(picBox.Name == "addTaskPicBox" && !isAddTaskSelected)
                {
                    addTaskLabel.ForeColor = Color.FromArgb(221, 230, 237);
                    picBox.Image = UserInterface.Properties.Resources.Add_Task_30_Hover;
                }
                else if (picBox.Name == "myTaskPicBox" && !isMyTaskSelected)
                {
                    myTaskLabel.ForeColor = Color.FromArgb(221, 230, 237);
                    picBox.Image = UserInterface.Properties.Resources.View_Task_30_Hover;
                }
            }
            else
            {
                Label label = (Label)sender;
                label.ForeColor = Color.FromArgb(221, 230, 237);

                if (label.Name == "homeLabel" && !isHomeSelected)
                {
                    if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
                    homePictureBox.Image = UserInterface.Properties.Resources.Home_Hover;
                }
                else if (label.Name == "addProjectLabel" && !isAddProjSelected)
                {
                    if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
                    addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project_Hover;
                }
                else if(label.Name == "viewProjectLabel" && !isViewProjSelected)
                {
                    if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
                    viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project_Hover;
                }
                else if(label.Name == "addTaskLabel" && !isAddTaskSelected)
                {
                    if (addTaskPicBox.Image != null) { addTaskPicBox.Image.Dispose(); }
                    addTaskPicBox.Image = UserInterface.Properties.Resources.Add_Task_30_Hover;
                }
                else if (label.Name == "myTaskLabel" && !isMyTaskSelected)
                {
                    if (myTaskPicBox.Image != null) { myTaskPicBox.Image.Dispose(); }
                    myTaskPicBox.Image = UserInterface.Properties.Resources.View_Task_30_Hover;
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
                    homeLabel.ForeColor = Color.FromArgb(157, 178, 191);
                    picBox.Image = UserInterface.Properties.Resources.Home_Normal;
                }
                else if (picBox.Name == "addProjectPictureBox" && !isAddProjSelected)
                {
                    addProjectLabel.ForeColor = Color.FromArgb(157, 178, 191);
                    picBox.Image = UserInterface.Properties.Resources.Add_Project;
                }
                else if (picBox.Name == "viewProjectPictureBox" && !isViewProjSelected)
                {
                    viewProjectLabel.ForeColor = Color.FromArgb(157, 178, 191);
                    picBox.Image = UserInterface.Properties.Resources.View_Project;
                }
                else if (picBox.Name == "addTaskPicBox" && !isAddTaskSelected)
                {
                    addTaskLabel.ForeColor = Color.FromArgb(157, 178, 191);
                    picBox.Image = UserInterface.Properties.Resources.Add_Task_30_Normal;
                }
                else if (picBox.Name == "myTaskPicBox" && !isMyTaskSelected)
                {
                    myTaskLabel.ForeColor = Color.FromArgb(157, 178, 191);
                    picBox.Image = UserInterface.Properties.Resources.View_Task_30_Normal;
                }
            }
            else
            {
                Label label = (Label)sender;

                if (label.Name == "homeLabel" && !isHomeSelected)
                {
                    if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
                    homePictureBox.Image = UserInterface.Properties.Resources.Home_Normal;
                    homeLabel.ForeColor = Color.FromArgb(157, 178, 191);
                }
                else if (label.Name == "addProjectLabel" && !isAddProjSelected)
                {
                    if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
                    addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project;
                    addProjectLabel.ForeColor = Color.FromArgb(157, 178, 191);
                }
                else if (label.Name == "viewProjectLabel" && !isViewProjSelected)
                {
                    if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
                    viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project;
                    viewProjectLabel.ForeColor = Color.FromArgb(157, 178, 191);
                }
                else if (label.Name == "addTaskLabel" && !isAddTaskSelected)
                {
                    if (addTaskPicBox.Image != null) { addTaskPicBox.Image.Dispose(); }
                    addTaskPicBox.Image = UserInterface.Properties.Resources.Add_Task_30_Normal;
                    addTaskLabel.ForeColor = Color.FromArgb(157, 178, 191);
                }
                else if (label.Name == "myTaskLabel" && !isMyTaskSelected)
                {
                    if (myTaskPicBox.Image != null) { myTaskPicBox.Image.Dispose(); }
                    myTaskPicBox.Image = UserInterface.Properties.Resources.View_Task_30_Normal;
                    myTaskLabel.ForeColor = Color.FromArgb(157, 178, 191);
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
                projectManagerHome1.InitializeProjectManagerHome();
                tabControl1.SelectedIndex = 0;
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
            isHomeSelected = isAddTaskSelected = isAddProjSelected = isViewProjSelected = isMyTaskSelected = false;

            if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
            if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
            if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
            if (addTaskPicBox.Image != null) { addTaskPicBox.Image.Dispose(); }
            if (myTaskPicBox.Image != null) { myTaskPicBox.Image.Dispose(); }

            homePictureBox.Image = UserInterface.Properties.Resources.Home_Normal;
            addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project;
            viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project;
            addTaskPicBox.Image = UserInterface.Properties.Resources.Add_Task_30_Normal;
            myTaskPicBox.Image = UserInterface.Properties.Resources.View_Task_30_Normal;

            homeLabel.ForeColor = addProjectLabel.ForeColor = viewProjectLabel.ForeColor = myTaskLabel.ForeColor = addTaskLabel.ForeColor = Color.FromArgb(157, 178, 191);
            string text = (sender as Control).Name;

            if (text == "homeLabel" || text == "homePictureBox")
            {
                isHomeSelected = true;
                if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
                homePictureBox.Image = UserInterface.Properties.Resources.Home_Hover;
                homeLabel.ForeColor = Color.FromArgb(221, 230, 237);
            }
            else if(text == "addProjectPictureBox" || text == "addProjectLabel")
            {
                isAddProjSelected = true;
                if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
                addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project_Hover;
                addProjectLabel.ForeColor = Color.FromArgb(221, 230, 237);
            }
            else if(text == "viewProjectLabel" || text == "viewProjectPictureBox")
            {
                isViewProjSelected = true;
                if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
                viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project_Hover;
                viewProjectLabel.ForeColor = Color.FromArgb(221, 230, 237);
            }
            else if(text == "addTaskLabel" || text == "addTaskPicBox")
            {
                isAddTaskSelected = true;
                if (addTaskPicBox.Image != null) { addTaskPicBox.Image.Dispose(); }
                addTaskPicBox.Image = UserInterface.Properties.Resources.Add_Task_30_Hover;
                addTaskLabel.ForeColor = Color.FromArgb(221, 230, 237);
            }
            else
            {
                isMyTaskSelected = true;
                if (myTaskPicBox.Image != null) { myTaskPicBox.Image.Dispose(); }
                myTaskPicBox.Image = UserInterface.Properties.Resources.View_Task_30_Hover;
                myTaskLabel.ForeColor = Color.FromArgb(221, 230, 237);
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
    }
}
