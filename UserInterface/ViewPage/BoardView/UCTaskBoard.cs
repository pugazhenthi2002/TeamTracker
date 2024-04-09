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

namespace TeamTracker
{
    public partial class UCTaskBoard : UserControl
    {
        private Task TaskBoardData;
        private bool isDragging = false;


        public UCTaskBoard()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            
        }
        
        public MouseEventHandler MouseDownTaskBoard;
        public MouseEventHandler MouseMoveTaskBoard;
        public MouseEventHandler MouseUpTaskBoard;

        public Task TaskData
        {
            get { return TaskBoardData; }
            set
            {
                if (value != null)
                {
                    TaskBoardData = value;
                    FlagChange();
                    InitializeBoardData();
                }

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
            if(TaskBoardData!=null) toolTip1.SetToolTip(pictureBoxFlag, TaskBoardData.TaskPriority + "");
            toolTip1.SetToolTip(pictureBoxInfo, "Info");
            toolTip1.SetToolTip(profilePictureBoxAssignedBy, "Assigned By");
        }

        private void OnMouseEnterInfo(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.info_hover;
        }

        private void OnMouseLeaveInfo(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.info_black;
        }

        private void FlagChange()
        {
            Image fImage = UserInterface.Properties.Resources.flag_UnderReview;
            switch (TaskBoardData.TaskPriority)
            {
                case Priority.Easy:
                    fImage = UserInterface.Properties.Resources.flag_UnderReview;
                    break;
                case Priority.Medium:
                    fImage = UserInterface.Properties.Resources.flag_NotStarted;
                    break;
                case Priority.Hard:
                    fImage = UserInterface.Properties.Resources.flag_stuck ;
                    break;
                case Priority.Critical:
                    fImage = UserInterface.Properties.Resources.flag_OnProcess;
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
            this.Cursor = Cursors.Hand;
        }

        private void OnMouseLeaveTaskBoard(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        private void OnMouseDownTaskBoard(object sender, MouseEventArgs e)
        {
            Point pt = (sender as Control).PointToScreen(e.Location);
            pt = this.PointToClient(pt);
            MouseDownTaskBoard?.Invoke(sender, new MouseEventArgs(MouseButtons.Left, 1, pt.X, pt.Y, 0));
            isDragging = true;
        }

        private void OnMouseUpTaskBoard(object sender, MouseEventArgs e)
        {
            Point pt = (sender as Control).PointToScreen(e.Location);
            pt = this.PointToClient(pt);
            MouseUpTaskBoard?.Invoke(sender, new MouseEventArgs(MouseButtons.Left, 1, pt.X, pt.Y, 0));
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
