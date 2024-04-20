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

        public void InitializePage()
        {
            tabControl1.SuspendLayout();
            projectInitializationPage1.SuspendLayout();
            initializeButton.BackColor = versionUpgradeButton.ForeColor = Color.FromArgb(221, 230, 237);
            versionUpgradeButton.BackColor = initializeButton.ForeColor = Color.FromArgb(39, 55, 77);
            tabControl1.SelectedIndex = 0;
            projectInitializationPage1.InitializePage();
            tabControl1.ResumeLayout();
            projectInitializationPage1.ResumeLayout();
        }

        private void OnInitializeClick(object sender, EventArgs e)
        {
            tabPage1.SuspendLayout();
            projectInitializationPage1.SuspendLayout();
            initializeButton.BackColor = versionUpgradeButton.ForeColor = Color.FromArgb(221, 230, 237);
            versionUpgradeButton.BackColor = initializeButton.ForeColor = Color.FromArgb(39, 55, 77);
            tabControl1.SelectedIndex = 0;
            projectInitializationPage1.InitializePage();
            tabPage1.ResumeLayout();
            projectInitializationPage1.SuspendLayout();
        }

        private void OnVersionUpgradeClick(object sender, EventArgs e)
        {
            tabPage2.SuspendLayout();
            versionUpgrade1.SuspendLayout();
            initializeButton.BackColor = versionUpgradeButton.ForeColor = Color.FromArgb(39, 55, 77);
            versionUpgradeButton.BackColor = initializeButton.ForeColor = Color.FromArgb(221, 230, 237);
            tabControl1.SelectedIndex = 1;
            versionUpgrade1.InitializePage();
            tabPage1.ResumeLayout();
            versionUpgrade1.ResumeLayout();
        }
    }
}
