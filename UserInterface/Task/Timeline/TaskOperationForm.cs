using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Task.Timeline
{
    public enum OperateType
    {
        Update,
        Delete
    }

    public partial class TaskOperationForm : Form
    {
        public event EventHandler<OperateType> Operate;
        public TaskOperationForm()
        {
            InitializeComponent();
        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            Operate?.Invoke(this, OperateType.Update);
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            Operate?.Invoke(this, OperateType.Delete);
        }
    }
}
