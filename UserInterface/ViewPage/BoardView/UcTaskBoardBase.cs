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
    public partial class UcTaskBoardBase : UserControl
    {
        private ProjectVersion currentProjectVersion;
        private SourceCodeSubmitionForm SubmitionForm;
        private bool toAdd = false;
        private UCTaskBoard BoardToAdd;

        private Point TaskBoardStartPoint;
        private Point TaskBoardMouseUpPoint;
        private int startColumn;

        private Point OffsetPoint;
        private bool IsDragging = false;
        private Form DragForm;

        public UcTaskBoardBase()
        {
            InitializeComponent();

            ucTaskStatusBaseNotYetStarted.TaskBoardMouseDown += OnMouseDownTaskBoard;
            ucTaskStatusBaseNotYetStarted.TaskBoardMouseUp += OnMouseUpTaskBoard;
            ucTaskStatusBaseNotYetStarted.TaskBoardMouseMove += OnMouseMoveTaskBoard;

            ucTaskStatusBaseOnProcess.TaskBoardMouseDown += OnMouseDownTaskBoard;
            ucTaskStatusBaseOnProcess.TaskBoardMouseUp += OnMouseUpTaskBoard;
            ucTaskStatusBaseOnProcess.TaskBoardMouseMove += OnMouseMoveTaskBoard;

            ucTaskStatusBaseStuck.TaskBoardMouseDown += OnMouseDownTaskBoard;
            ucTaskStatusBaseStuck.TaskBoardMouseUp += OnMouseUpTaskBoard;
            ucTaskStatusBaseStuck.TaskBoardMouseMove += OnMouseMoveTaskBoard;

            ucTaskStatusBaseUnderReview.TaskBoardMouseDown += OnMouseDownTaskBoard;
            ucTaskStatusBaseUnderReview.TaskBoardMouseUp += OnMouseUpTaskBoard;
            ucTaskStatusBaseUnderReview.TaskBoardMouseMove += OnMouseMoveTaskBoard;

            ucTaskStatusBaseDone.TaskBoardMouseDown += OnMouseDownTaskBoard;
            ucTaskStatusBaseDone.TaskBoardMouseUp += OnMouseUpTaskBoard;
            ucTaskStatusBaseDone.TaskBoardMouseMove += OnMouseMoveTaskBoard;

        }

        public ProjectVersion CurrentProjVersion
        {
            get { return currentProjectVersion; }
            set
            {
                if (value != null)
                {
                    currentProjectVersion = value;
                    SetVersion();
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
            DragForm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, DragForm.Width, DragForm.Height, 20, 20));


        }

        private void SetVersion()
        {
            ucTaskStatusBaseNotYetStarted.TaskList = TaskManager.FetchTasks(currentProjectVersion.VersionID, TaskStatus.NotYetStarted);
            ucTaskStatusBaseOnProcess.TaskList = TaskManager.FetchTasks(currentProjectVersion.VersionID, TaskStatus.OnProcess);
            ucTaskStatusBaseStuck.TaskList = TaskManager.FetchTasks(currentProjectVersion.VersionID, TaskStatus.Stuck);
            ucTaskStatusBaseUnderReview.TaskList = TaskManager.FetchTasks(currentProjectVersion.VersionID, TaskStatus.UnderReview);
            ucTaskStatusBaseDone.TaskList = TaskManager.FetchTasks(currentProjectVersion.VersionID, TaskStatus.Done);

        }
        

        private void OnMouseDownTaskBoard(UCTaskBoard sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                OffsetPoint = new Point(e.X, e.Y);
                UCTaskStatusBase tStatusBase = FindParentUserControl(sender);
                tStatusBase.RemoveTaskBoard(sender);


                TaskBoardStartPoint = sender.PointToScreen(Point.Empty);
                startColumn = (tableLayoutPanel1.PointToClient(Control.MousePosition)).X / (tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount);
                IsDragging = true;

                DragForm = new Form();
                DragForm.Show();
                DragForm.FormBorderStyle = FormBorderStyle.None;
                DragForm.StartPosition = FormStartPosition.Manual;
                DragForm.Size = (sender).Size;
                DragForm.Controls.Add(sender);
                DragForm.Location = TaskBoardStartPoint;
                InitializeRoundedEdge();
            }

        }

        private void OnMouseMoveTaskBoard(UCTaskBoard sender, MouseEventArgs e)
        {
            if(IsDragging)
            {
                UCTaskStatusBase tBase = FindParentUserControl(sender as Control);


                DragForm.Location = new Point(DragForm.Location.X+(e.X-OffsetPoint.X), DragForm.Location.Y+(e.Y-OffsetPoint.Y));

                //DragForm.Location = this.PointToClient(sender.PointToScreen(e.Location));
                
                //switch (tBase.Status)
                //{
                //    case TaskStatus.Done:
                //        break;
                //    case TaskStatus.NotYetStarted:
                //        break;
                //    case TaskStatus.OnProcess:
                //        break;
                //    case TaskStatus.Stuck:
                //        break;
                //    case TaskStatus.UnderReview:
                //        break;
                //}
                //tBase.RemoveTaskBoard(sender);



            }
        }

        private void OnMouseUpTaskBoard(UCTaskBoard sender, MouseEventArgs e)
        {
            IsDragging = false;
            TaskBoardMouseUpPoint = tableLayoutPanel1.PointToClient(Control.MousePosition);

            int columnWidth = tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount;
            int columnNumber = TaskBoardMouseUpPoint.X / columnWidth;

            BoardToAdd = sender;

            AddBoardOnColumn(columnNumber);
            
            
        }

        private void AddBoardOnColumn(int columnNumber)
        {
            switch (columnNumber)
            {
                case 0:
                    ucTaskStatusBaseNotYetStarted.AddTask(BoardToAdd);
                    DragForm.Dispose();
                    break;
                case 1:
                    ucTaskStatusBaseOnProcess.AddTask(BoardToAdd);
                    DragForm.Dispose();
                    break;
                case 2:
                    ucTaskStatusBaseStuck.AddTask(BoardToAdd);
                    DragForm.Dispose();
                    break;
                case 3:

                    SubmitionForm = new SourceCodeSubmitionForm();
                    SubmitionForm.DoneClick += OnClickDoneSubmitionForm;
                    SubmitionForm.CloseClick += OnClickCloseSubmitionForm;
                    SubmitionForm.Show();

                    break;
                case 4:
                    ucTaskStatusBaseDone.AddTask(BoardToAdd);
                    DragForm.Dispose();
                    break;
            }
        }

        private void AddBoard(UCTaskBoard sender)
        {
            if (toAdd)
            {
                ucTaskStatusBaseUnderReview.AddTask(sender);
                DragForm.Dispose();
            }
            else
            {
                AddBoardOnColumn(startColumn);
            }
        }

        private void OnClickDoneSubmitionForm(object sender, EventArgs e)
        {
            toAdd = true;
            AddBoard(BoardToAdd);

        }
        private void OnClickCloseSubmitionForm(object sender, EventArgs e)
        {
            toAdd = false;
            AddBoard(BoardToAdd);
        }

        private UCTaskStatusBase FindParentUserControl(Control control)
        {
            if (control == null || control.Parent == null)
            {
                return null;
            }

            if (control.Parent is UCTaskStatusBase)
            {
                return (UCTaskStatusBase)control.Parent;
            }

            return FindParentUserControl(control.Parent);
        }



    }
}
