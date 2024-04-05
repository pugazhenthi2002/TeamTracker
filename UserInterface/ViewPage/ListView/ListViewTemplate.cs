using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class ListViewTemplate : UserControl
    {
        public List<Task> TaskCollection
        {
            set
            {
                taskCollection = value;
                SetTaskAllignment();
            }
        }

        private List<Task> taskCollection;
        public ListViewTemplate()
        {
            InitializeComponent();
        }

        private void SetTaskAllignment()
        {

        }
    }
}
