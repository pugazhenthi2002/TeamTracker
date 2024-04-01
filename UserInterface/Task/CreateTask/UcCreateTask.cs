using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Task.CreateTask
{
    public partial class UcCreateTask : UserControl
    {
        public UcCreateTask()
        {
            InitializeComponent();
        }

        private void OnMouseEnterSetPriority(object sender, EventArgs e)
        {
                labelSetPriority.BackColor = Color.FromArgb(157, 178, 191);
                pictureBoxFlag.BackColor = Color.FromArgb(157, 178, 191);
            
        }

        private void OnMouseLeaveSetPriority(object sender, EventArgs e)
        {
           
            labelSetPriority.BackColor = Color.Transparent;
            pictureBoxFlag.BackColor = Color.Transparent;
        }
    }
}
