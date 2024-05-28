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
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            initializeButton.Click -= OnInitializeClick;    versionUpgradeButton.Click -= OnVersionUpgradeClick;
        }

        private void InitializePageColor()
        {
            tabPage1.BackColor = tabPage2.BackColor = initializeButton.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            versionUpgradeButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            initializeButton.ForeColor = ThemeManager.GetTextColor(initializeButton.BackColor);
            versionUpgradeButton.ForeColor = ThemeManager.GetTextColor(versionUpgradeButton.BackColor);
        }

        public void InitializePage()
        {
            tabControl1.SuspendLayout();
            projectInitializationPage1.SuspendLayout();
            InitializePageColor();
            tabControl1.SelectedIndex = 0;
            projectInitializationPage1.InitializePage();
            tabControl1.ResumeLayout();
            projectInitializationPage1.ResumeLayout();
        }

        private void OnInitializeClick(object sender, EventArgs e)
        {
            tabPage1.SuspendLayout();
            projectInitializationPage1.SuspendLayout();
            initializeButton.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            initializeButton.ForeColor = ThemeManager.GetTextColor(initializeButton.BackColor);
            versionUpgradeButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            versionUpgradeButton.ForeColor = ThemeManager.GetTextColor(versionUpgradeButton.BackColor);
            tabControl1.SelectedIndex = 0;
            projectInitializationPage1.InitializePage();
            tabPage1.ResumeLayout();
            projectInitializationPage1.SuspendLayout();
        }

        private void OnVersionUpgradeClick(object sender, EventArgs e)
        {
            tabPage2.SuspendLayout();
            versionUpgrade1.SuspendLayout();
            versionUpgradeButton.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            versionUpgradeButton.ForeColor = ThemeManager.GetTextColor(versionUpgradeButton.BackColor);
            initializeButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            initializeButton.ForeColor = ThemeManager.GetTextColor(initializeButton.BackColor);
            tabControl1.SelectedIndex = 1;
            versionUpgrade1.InitializePage();
            tabPage1.ResumeLayout();
            versionUpgrade1.ResumeLayout();
        }
    }
}
