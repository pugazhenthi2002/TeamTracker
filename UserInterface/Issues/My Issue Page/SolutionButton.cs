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
                    BackColor = Color.FromArgb(39, 55, 77);
                    label1.ForeColor = Color.FromArgb(221, 230, 237);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(39, 55, 77);
                    BackColor = Color.FromArgb(221, 230, 237);
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
    }
}
