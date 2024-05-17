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
    public partial class SearchVersion : UserControl
    {
        public event EventHandler<string> ProjectNameChange;
        public SearchVersion()
        {
            InitializeComponent();
            InitializePageColor();
            versionSearchTextBox.GotFocus += RemoveSearchPlaceHolders;
            versionSearchTextBox.LostFocus += AddSearchPlaceHolders;
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void AddSearchPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(versionSearchTextBox.Text))
                versionSearchTextBox.Text = "Search Project Name..";
        }

        private void RemoveSearchPlaceHolders(object sender, EventArgs e)
        {
            if (versionSearchTextBox.Text == "Search Project Name..")
            {
                versionSearchTextBox.Text = "";
            }
        }

        private void InitializePageColor()
        {
            BackColor = versionSearchTextBox.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            versionSearchTextBox.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (versionSearchTextBox.Text == "Search Project Name..")
                ProjectNameChange?.Invoke(this, "");
            else
                ProjectNameChange?.Invoke(this, versionSearchTextBox.Text);
        }
    }
}
