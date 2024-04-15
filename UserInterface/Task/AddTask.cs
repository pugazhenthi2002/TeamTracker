using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;
using UserInterface.Task.CreateTask;

namespace UserInterface.Task
{
    public partial class AddTask : UserControl
    {
        public AddTask()
        {
            InitializeComponent();
        }

        public void InitializePage()
        {
            currentTimelineContent1.Version = VersionManager.CurrentVersion;
        }

        private void AddTaskClick(object sender, EventArgs e)
        {
            CreateTaskForm form = new CreateTaskForm();
            form.Show();
        }
    }
}
