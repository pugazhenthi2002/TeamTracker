using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Drawing.Drawing2D;

namespace TeamTracker
{
    public partial class UCTaskBoard : UserControl
    {
        private Task TaskBoardData;
        private bool isDragging = false;
        private TaskInfoForm taskInfoForm;

        public UCTaskBoard()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            DoubleBuffered = true;
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, tableLayoutPanel1, new object[] { true });
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, tableLayoutPanel2, new object[] { true });
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, tableLayoutPanel3, new object[] { true });
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, tableLayoutPanel4, new object[] { true });
            typeof(ProfilePictureBox).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, profilePictureBoxAssignedBy, new object[] { true });
            typeof(PictureBox).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, pictureBoxFlag, new object[] { true });
            typeof(PictureBox).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, pictureBoxInfo, new object[] { true });
            typeof(UcDueDate).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, ucDueDate1, new object[] { true });
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, labelProjectName, new object[] { true });
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, LabelTask, new object[] { true });
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, labelVersion, new object[] { true });
        }
        
        public MouseEventHandler MouseDownTaskBoard;
        public MouseEventHandler MouseMoveTaskBoard;
        public MouseEventHandler MouseUpTaskBoard;

        public Task TaskData
        {
            get { return TaskBoardData; }
            set
            {
                this.SuspendLayout();
                if (value != null)
                {
                    TaskBoardData = value;
                    FlagChange();
                    InitializeBoardData();
                }
                this.ResumeLayout();
            }
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
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));

        }
        private void OnLoad(object sender, EventArgs e)
        {
            InitializeRoundedEdge();
            if(TaskBoardData!=null) toolTip1.SetToolTip(pictureBoxFlag,"Task priority: "+ TaskBoardData.TaskPriority );
            toolTip1.SetToolTip(pictureBoxInfo, "Info");
            toolTip1.SetToolTip(profilePictureBoxAssignedBy, "Assigned By");
        }

        private void OnMouseEnterInfo(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.info_hover;
            this.BackColor = Color.FromArgb(39, 55, 77);
            this.Cursor = Cursors.Hand;
        }

        private void OnMouseLeaveInfo(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.info_black;
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
        }

        private void FlagChange()
        {
            Image fImage = UserInterface.Properties.Resources.flag_UnderReview;
            switch (TaskBoardData.TaskPriority)
            {
                case Priority.Easy:
                    fImage = UserInterface.Properties.Resources.Easy;
                    break;
                case Priority.Medium:
                    fImage = UserInterface.Properties.Resources.Medium;
                    break;
                case Priority.Hard:
                    fImage = UserInterface.Properties.Resources.Hard ;
                    break;
                case Priority.Critical:
                    fImage = UserInterface.Properties.Resources.Critical;
                    break;
            }
            pictureBoxFlag.Image = fImage;
          
        }

        private void InitializeBoardData()
        {
            labelProjectName.Text = VersionManager.FetchProjectName(TaskData.VersionID);
            labelVersion.Text = VersionManager.CurrentVersion.VersionName;
            LabelTask.Text = TaskData.TaskName;
            ucDueDate1.DueDate = TaskData.EndDate;
            profilePictureBoxAssignedBy.ImageLocation = (EmployeeManager.FetchEmployeeFromID(TaskData.AssignedBy)).EmpProfileLocation;
            //profilePictureBoxAssignedBy.Image = Image.FromFile(EmployeeManager.FetchEmployeeFromID(TaskData.AssignedBy).EmpProfileLocation);
            
        }

        private void OnClickInfo(object sender, EventArgs e)
        {
            taskInfoForm = new TaskInfoForm();
            taskInfoForm.SelectedTask = TaskBoardData;
            taskInfoForm.ShowDialog();
        }

        private void OnResize(object sender, EventArgs e)
        {
            InitializeRoundedEdge();
        }

        private void OnClickTaskBoard(object sender, EventArgs e)
        {

        }

        private void OnMouseEnterTaskBoard(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(39, 55, 77);
            this.Cursor = Cursors.Hand;
        }

        private void OnMouseLeaveTaskBoard(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
        }


        private void OnMouseDownTaskBoard(object sender, MouseEventArgs e)
        {
            Point pt = (sender as Control).PointToScreen(e.Location);
            pt = this.PointToClient(pt);
            MouseDownTaskBoard?.Invoke(this, new MouseEventArgs(MouseButtons.Left, 1, pt.X, pt.Y, 0));
            isDragging = true;
        }

        private void OnMouseUpTaskBoard(object sender, MouseEventArgs e)
        {
            Point pt = (sender as Control).PointToScreen(e.Location);
            pt = this.PointToClient(pt);
            MouseUpTaskBoard?.Invoke(this, new MouseEventArgs(MouseButtons.Left, 1, pt.X, pt.Y, 0));
            isDragging = false;
        }

        private void OnMouseMoveTaskBoard(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point pt = (sender as Control).PointToScreen(e.Location);
                pt = this.PointToClient(pt);
                MouseMoveTaskBoard?.Invoke(sender, new MouseEventArgs(MouseButtons.Left, 1, pt.X, pt.Y, 0));
            }
        }

        
    }
}
