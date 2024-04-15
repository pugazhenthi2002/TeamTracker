using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Task.CreateTask
{
    public partial class MilestoneWarningForm : Form
    {
        public MilestoneWarningForm()
        {
            InitializeComponent();
        }
        public event EventHandler<bool> WarningStatus;

        private void OnYesClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, true);
            this.Close();
        }

        private void OnNoClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, false);
            this.Close();
        }
    }
}
