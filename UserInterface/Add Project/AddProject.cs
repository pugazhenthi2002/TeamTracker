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
    public partial class AddProject : UserControl
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void OnInitializeClick(object sender, EventArgs e)
        {
            initializeButton.BackColor = versionUpgradeButton.ForeColor = Color.FromArgb(221, 230, 237);
            versionUpgradeButton.BackColor = initializeButton.ForeColor = Color.FromArgb(39, 55, 77);
        }

        private void OnVersionUpgradeClick(object sender, EventArgs e)
        {
            initializeButton.BackColor = versionUpgradeButton.ForeColor = Color.FromArgb(39, 55, 77);
            versionUpgradeButton.BackColor = initializeButton.ForeColor = Color.FromArgb(221, 230, 237);
        }
    }
}
