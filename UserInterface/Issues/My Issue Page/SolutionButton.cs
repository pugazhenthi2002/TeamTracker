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

namespace UserInterface.Issues.My_Issue_Page
{
    public partial class SolutionButton : UserControl
    {
        public event EventHandler<IssueSolution> SolutionSelect;

        public string LabelText
        {
            set
            {
                label1.Text = value;
            }
        }

        public bool IsClicked
        {
            set
            {
                if (value)
                {
                    BackColor = ThemeManager.CurrentTheme.PrimaryI;
                    textColor = label1.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
                else
                {
                    textColor = label1.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
                    BackColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
            }
        }

        public IssueSolution SelectedSolution
        {
            get; set;
        }

        public new void Dispose()
        {
            label1.Dispose();
        }

        public SolutionButton()
        {
            InitializeComponent();
        }

        private void OnSolutionClick(object sender, EventArgs e)
        {
            SolutionSelect?.Invoke(this, SelectedSolution);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = ThemeManager.GetHoverColor(label1.ForeColor);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = textColor;
        }

        private Color textColor;
    }
}
