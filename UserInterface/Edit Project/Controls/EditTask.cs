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

namespace UserInterface.Edit_Project.Controls
{
    public partial class EditTask : UserControl
    {
        public EditTask()
        {
            InitializeComponent();
        }

        public void InitializePage()
        {
            requiredTaskCollection = TaskManager.FetchEditTask();
            InitializeRequiredControl();
        }

        private void OnTaskNameChanged(object sender, string e)
        {

        }

        private void InitializeRequiredControl()
        {
        }

        private List<TeamTracker.Task> requiredTaskCollection;
        private bool isBackEnable, isNextEnable;
        private int startIdx, endIdx;
    }
}
