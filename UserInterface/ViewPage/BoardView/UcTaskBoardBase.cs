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
using UserInterface.ViewPage.ListView;
using UserInterface;

namespace TeamTracker
{
    public partial class UcTaskBoardBase : UserControl
    {
        private TransparentForm transparentForm;
        private ProjectVersion currentProjectVersion;
        private SourceCodeSubmitionForm SubmitionForm;
        private bool toAdd = false, underReviewFlag = false;
        private UCTaskBoard BoardToAdd;

        private Point TaskBoardStartPoint;
        private Point TaskBoardMouseUpPoint;
        private int startColumn, selectedColumnNumber;

        private Point OffsetPoint;
        private bool IsDragging = false;
        private Form DragForm;

        public UcTaskBoardBase()
        {
            InitializeComponent();
            InitializePageColor();

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

            ThemeManager.ThemeChange += OnThemeChanged;
        }

        public ProjectVersion CurrentProjVersion
        {
            get { return currentProjectVersion; }
            set
            {
                this.SuspendLayout();
                if (value != null)
                {
                    currentProjectVersion = value;
                    SetVersion();
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
            DragForm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, DragForm.Width, DragForm.Height, 20, 20));
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void SetVersion()
        {
            ucTaskStatusBaseNotYetStarted.TaskList = TaskManager.FetchTasks(currentProjectVersion.VersionID, TaskStatus.NotYetStarted);
            ucTaskStatusBaseOnProcess.TaskList = TaskManager.FetchTasks(currentProjectVersion.VersionID, TaskStatus.OnProcess);
            ucTaskStatusBaseStuck.TaskList = TaskManager.FetchTasks(currentProjectVersion.VersionID, TaskStatus.Stuck);
            ucTaskStatusBaseUnderReview.TaskList = TaskManager.FetchTasks(currentProjectVersion.VersionID, TaskStatus.UnderReview);
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
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
                DragForm.SuspendLayout();
                DragForm.FormBorderStyle = FormBorderStyle.None;
                DragForm.StartPosition = FormStartPosition.Manual;
                DragForm.Size = (sender).Size;
                DragForm.Controls.Add(sender);
                DragForm.Location = TaskBoardStartPoint;
                DragForm.ResumeLayout(true);
                DragForm.Show();
                InitializeRoundedEdge();
            }

        }

        private void OnMouseMoveTaskBoard(UCTaskBoard sender, MouseEventArgs e)
        {
            if(IsDragging)
            {
                UCTaskStatusBase tBase = FindParentUserControl(sender as Control);


                DragForm.Location = new Point(DragForm.Location.X+(e.X-OffsetPoint.X), DragForm.Location.Y+(e.Y-OffsetPoint.Y));

                //if(DragForm.Location.X<=0 && DragForm.Location.Y<=0)
                //{
                //    DragForm.Location = new Point(0,0);
                //    return;
                //}
                //else if (DragForm.Location.X <= 0)
                //{
                //    DragForm.Location = new Point(0, DragForm.Location.Y);
                //    return;
                //}
                //else if(DragForm.Location.Y<=0)
                //{
                //    DragForm.Location = new Point(DragForm.Location.X,0);
                //    return;
                //}

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
            TaskBoardMouseUpPoint = tableLayoutPanel1.PointToClient(Control.MousePosition);
            int columnWidth = tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount;
            int columnNumber = TaskBoardMouseUpPoint.X / columnWidth;
            BoardToAdd = sender;
            if (sender.TaskData.StatusOfTask == TaskStatus.UnderReview)
            {
                StatusChangeWarningForm form = new StatusChangeWarningForm();
                selectedColumnNumber = columnNumber;
                switch (columnNumber)
                {
                    case 0:
                        form.PrevStatus = "NotYetStarted";
                        break;
                    case 1:
                        form.PrevStatus = "OnProcess";
                        break;
                    case 2:
                        form.PrevStatus = "Stuck";
                        break;
                    default:
                        form.PrevStatus = "UnderReview";
                        break;
                }

                if (form.PrevStatus == "UnderReview")
                {
                    toAdd = true;
                    AddBoard(BoardToAdd);
                }
                else
                {
                    underReviewFlag = true;
                    form.WarningStatus += OnWarningStatusClicked;

                    transparentForm = new TransparentForm();
                    transparentForm.Show();
                    transparentForm.ShowForm(form);
                }
            }
            else
            {
                AddBoardOnColumn(columnNumber);
            }

            IsDragging = false;
            
        }

        private void OnWarningStatusClicked(object sender, string e, bool result)
        {
            (sender as StatusChangeWarningForm).Dispose();
            (sender as StatusChangeWarningForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (result)
            {
                DataHandler.DeleteSourceCode(BoardToAdd.TaskData.TaskID);
                AddBoardOnColumn(selectedColumnNumber);
            }
            else
            {
                toAdd = true;
                AddBoard(BoardToAdd);
            }
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
                default:

                    SubmitionForm = new SourceCodeSubmitionForm();
                    SubmitionForm.SourceCodeTask = BoardToAdd.TaskData;
                    SubmitionForm.Owner = this.ParentForm;
                    SubmitionForm.DoneClick += OnClickDoneSubmitionForm;

                    transparentForm = new TransparentForm();
                    transparentForm.Show();
                    transparentForm.ShowForm(SubmitionForm);
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

        private void OnClickDoneSubmitionForm(object sender, SourceCode e)
        {
            (sender as SourceCodeSubmitionForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            toAdd = e == null ? false : true;
            if (toAdd)
                DataHandler.SubmitSourceCode(e);
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
