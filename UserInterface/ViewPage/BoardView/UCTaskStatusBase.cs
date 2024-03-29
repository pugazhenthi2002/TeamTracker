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
            TaskList = TaskManager.FetchTasks(VersionId, Tstatus);
        }
        public TaskStatus Status
        {
            get { return Tstatus; }
            set
            {
                Tstatus = value;
            }
        }

        private TaskStatus Tstatus;
        private int VersionId;

        private List<Task> TaskList;


        private void InitializeBoard()
        {
            foreach(Task task in TaskList)
            {

            }
        }

    }
}
