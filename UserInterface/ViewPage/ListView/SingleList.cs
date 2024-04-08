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
    public partial class SingleList : UserControl
    {
        private Task task;


        public Task ListTask
        {
            set
            {
                task = value;
                SetTaskUI();
            }
        }

        public SingleList()
        {
            InitializeComponent();
        }

        public void SetTaskUI()
        {
            taskName.Text = task.TaskName;
            assignedBy.Profile = EmployeeManager.FetchEmployeeFromID(task.AssignedBy);
            statusLabel.Text = task.StatusOfTask.ToString();
            priorityLabel.Text = task.TaskPriority.ToString();
            dueDateLabel.Text = task.EndDate.ToShortDateString();
        }
    }
}
