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
    public partial class SearchTask : UserControl
    {
        public event EventHandler<string> TaskNameChange;

        public SearchTask()
        {
            InitializeComponent();
            InitializePageColor();
            taskSearchTextBox.GotFocus += RemoveSearchPlaceHolders;
            taskSearchTextBox.LostFocus += AddSearchPlaceHolders;
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            taskSearchTextBox.GotFocus -= RemoveSearchPlaceHolders;
            taskSearchTextBox.LostFocus -= AddSearchPlaceHolders;
            taskSearchTextBox.TextChanged -= OnTextChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void AddSearchPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(taskSearchTextBox.Text))
                taskSearchTextBox.Text = "Search Task Name..";
        }

        private void RemoveSearchPlaceHolders(object sender, EventArgs e)
        {
            if (taskSearchTextBox.Text == "Search Task Name..")
            {
                taskSearchTextBox.Text = "";
            }
        }

        private void InitializePageColor()
        {
            BackColor = taskSearchTextBox.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            taskSearchTextBox.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (taskSearchTextBox.Text == "Search Task Name..")
                TaskNameChange?.Invoke(this, "");
            else
                TaskNameChange?.Invoke(this, taskSearchTextBox.Text);
        }
    }
}
