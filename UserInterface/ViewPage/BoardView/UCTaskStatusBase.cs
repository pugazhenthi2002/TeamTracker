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
                Tstatus = value;
            }
        }

        private TaskStatus Tstatus = TaskStatus.Done;


        public List<Task> taskList = new List<Task>();
        public List<Task> TaskList
        {
            set
            {
                taskList = TaskManager.FetchTasks(VersionId, Tstatus);
            }
        }
        private List<UCTaskBoard> TaskBoardList = new List<UCTaskBoard>();


        private int StartIndex = 0;
        private int flag = 0;
        private int ind = 0;
        private int MaxUserControls = 4;
        private int VersionId;

        private void InitializeBoard()
        {
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

                        

                        TaskBoardList.Add(tBoard);
                        panelBase.Controls.Add(tBoard);
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            else
            {
                if (taskList.Count < MaxUserControls)
                {
                    panelBase.Controls.Remove(TaskBoardList[TaskBoardList.Count - 1]);
                    TaskBoardList.RemoveAt(TaskBoardList.Count - 1);
                }

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
                ind = 0;
            }

            
            
            
        }

        private void OnClickNextPage(object sender, EventArgs e)
        {
            
            if (StartIndex + MaxUserControls >= taskList.Count)//if it reaches the last page
            {
                return ;
            }
            StartIndex++;

            InitializeBoard();
        }

        private void OnClickBackPage(object sender, EventArgs e)
        {
            
            if (StartIndex <= 0)//if it reaches the first page
            {
                return ;
            }
            StartIndex--;

            InitializeBoard();
        }

        

        private void OnLoad(object sender, EventArgs e)
        {
            InitializeBoard();
        }
    }
}
