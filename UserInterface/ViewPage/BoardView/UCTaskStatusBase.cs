using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class UCTaskStatusBase : UserControl
    {
        public UCTaskStatusBase()
        {
            InitializeComponent();
            ucTaskStatusHead1.Status = Tstatus;
            ucTaskStatusHead1.ClickBack += OnClickBackPage;
            ucTaskStatusHead1.ClickNext += OnClickNextPage;
            InitializeBoard();
        }

        


        public TaskStatus Status
        {
            get { return Tstatus; }
            set
            {
                ucTaskStatusHead1.Status = value;
                Tstatus = value;
            }
        }

        

        
        public List<Task> TaskList
        {
            set
            {
                RemoveControls();
                StartIndex = 0;
                flag = 0;
                ind = 0;
                taskList = value;
                taskList.Sort((t1, t2) => t2.EndDate.CompareTo(t1.EndDate));
                InitializeBoard();
            }
        }

        //public ProjectVersion CurrentProjVersion
        //{
        //    get { return currentProjectVersion; }
        //    set
        //    {
        //        currentProjectVersion = value;
        //    }
        //}



        public delegate void TaskBoardMouseEventHandler(UCTaskBoard sender, MouseEventArgs e);
        

        public TaskBoardMouseEventHandler TaskBoardMouseDown;
        public TaskBoardMouseEventHandler TaskBoardMouseUp;
        public TaskBoardMouseEventHandler TaskBoardMouseMove;


        public List<Task> taskList = new List<Task>();
        private List<UCTaskBoard> TaskBoardList = new List<UCTaskBoard>();
        private int StartIndex = 0;
        private int flag = 0;
        private int ind = 0;
        private int MaxUserControls = 4;
        private int VersionId ;
        private ProjectVersion currentProjectVersion;
        private TaskStatus Tstatus = TaskStatus.Done;

        private Point TaskBoardStartPoint;
        private Point TaskBoardMouseUpPoint;
        private bool IsDragging = false;

        private void InitializeBoard()
        {
            ucTaskStatusHead1.labelTaskCount.Text = taskList.Count+"";
            if (flag == 0)
            {

                for (int i = StartIndex; i < Math.Min(StartIndex + MaxUserControls, taskList.Count); i++)
                {
                    flag = 1;
                    if (i < taskList.Count)
                    {
                        UCTaskBoard tBoard = new UCTaskBoard();
                        tBoard.TaskData = taskList[i];
                        tBoard.Dock = DockStyle.Top;

                        tBoard.MouseDownTaskBoard += OnMouseDownTaskBoard;
                        tBoard.MouseMoveTaskBoard += OnMouseMoveTaskBoard;
                        tBoard.MouseUpTaskBoard += OnMouseUpTaskBoard;
                        

                        TaskBoardList.Add(tBoard);
                        panelBase.Controls.Add(tBoard);
                    }
                    else
                    {
                        break;
                    }
                }
                foreach(var Iter in TaskBoardList)
                {
                    Iter.BringToFront();
                }
                
            }
            

          




        }

        private void ReOrderBoard()
        {
            ucTaskStatusHead1.labelTaskCount.Text = taskList.Count + "";

            ind = 0;
            for (int i = StartIndex; i < Math.Min(StartIndex + MaxUserControls, taskList.Count); i++)
            {
                if (i < taskList.Count)
                {
                    TaskBoardList[ind++].TaskData = taskList[i];
                }
                else
                {
                    break;
                }

            }
        }

        private void OnClickNextPage(object sender, EventArgs e)
        {
            
            if (StartIndex + MaxUserControls >= taskList.Count)//if it reaches the last page
            {
                ucTaskStatusHead1.pictureBoxDown.Hide();
                return ;
            }
            else
            {
                //need to check
                ucTaskStatusHead1.pictureBoxUp.Show();
                ucTaskStatusHead1.pictureBoxDown.Show();

            }
            StartIndex++;

            ReOrderBoard();
        }

        private void OnClickBackPage(object sender, EventArgs e)
        {
            
            if (StartIndex <= 0)//if it reaches the first page
            {
                ucTaskStatusHead1.pictureBoxUp.Hide();
                return;
            }
            else
            {
                //need to check
                ucTaskStatusHead1.pictureBoxUp.Show();
                ucTaskStatusHead1.pictureBoxDown.Show();

            }

            StartIndex--;

            ReOrderBoard();
        }

        

        private void OnLoad(object sender, EventArgs e)
        {
            InitializeBoard();
        }

        private void RemoveControls()
        {
            TaskBoardList.Clear();
            panelBase.Controls.Clear();
            
        }


        private void OnMouseDownTaskBoard(object sender, MouseEventArgs e)
        {
            
            UCTaskBoard parentUserControl = FindParentUserControl(sender as Control);
            IsDragging = true;

            TaskBoardMouseDown?.Invoke(parentUserControl, e);
        }

        private void OnMouseUpTaskBoard(object sender, MouseEventArgs e)
        {
            IsDragging = false;
            UCTaskBoard parentUserControl = FindParentUserControl(sender as Control);
            TaskBoardMouseUp?.Invoke(parentUserControl, e);
        }

        private void OnMouseMoveTaskBoard(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                UCTaskBoard parentUserControl = FindParentUserControl(sender as Control);
                TaskBoardMouseMove?.Invoke(parentUserControl, e);
            }
        }

        private UCTaskBoard FindParentUserControl(Control control)
        {
            if (control == null || control.Parent == null)
            {
                return null;
            }

            if (control.Parent is UCTaskBoard)
            {
                return (UCTaskBoard)control.Parent;
            }

            return FindParentUserControl(control.Parent);
        }

        public void RemoveTaskBoard(UCTaskBoard tBoard)
        {
            TaskBoardList.Remove(tBoard);
            panelBase.SuspendLayout();
            if (taskList.Count > MaxUserControls)
            {
                UCTaskBoard taskBoard = new UCTaskBoard();
                taskBoard.Dock = DockStyle.Top;

                taskBoard.MouseDownTaskBoard += OnMouseDownTaskBoard;
                taskBoard.MouseMoveTaskBoard += OnMouseMoveTaskBoard;
                taskBoard.MouseUpTaskBoard += OnMouseUpTaskBoard;

                TaskBoardList.Add(taskBoard);
                panelBase.Controls.Add(taskBoard);

                foreach (var Iter in TaskBoardList)
                {
                    Iter.BringToFront();
                }
            }
            
            taskList.Remove(tBoard.TaskData);
            if (taskList.Count > 1) taskList.Sort((r1, r2) => r2.EndDate.CompareTo(r1.EndDate));
            panelBase.ResumeLayout();

            ReOrderBoard();
        }

        public void AddTask(UCTaskBoard taskBoard)
        {

            var x = StartIndex;
            Task tData = taskBoard.TaskData;
            //taskBoard.TaskData.StatusOfTask = this.Status;


            //TaskManager.UpdateTask(tData.TaskID, tData.TaskName, tData.TaskDesc, tData.StartDate, tData.EndDate, tData.TaskPriority, tData.AssignedTo, null);

            taskList.Add(taskBoard.TaskData);
            if(taskList.Count <= MaxUserControls)
            {
                panelBase.Controls.Add(taskBoard);
                TaskBoardList.Add(taskBoard);
            }
            if(taskList.Count>1)
                taskList.Sort((r1, r2) => r2.EndDate.CompareTo(r1.EndDate));
            


            ReOrderBoard();
        }
    }


   
}
