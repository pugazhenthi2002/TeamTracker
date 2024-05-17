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
using System.Reflection;

namespace UserInterface.Issues.My_Issue_Page
{
    public partial class SolutionTemplate : UserControl
    {
        private int remainingHeight = 0;
        private Rectangle rec = new Rectangle();
        private IssueSolution selectedSolution;
        public IssueSolution SelectedSolution
        {
            set
            {
                if (value != null)
                {
                    selectedSolution = value;
                    InitializePage();
                }
            }
        }

        public SolutionTemplate()
        {
            DoubleBuffered = true;
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            solutionAttachmentTemplate1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            solvedByLabel.BackColor = richTextBox1.BackColor = employeeProfilePicAndName1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            solvedByLabel.ForeColor = richTextBox1.ForeColor = employeeProfilePicAndName1.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
        }

        private void SolutionTemplate_MouseWheel(object sender, MouseEventArgs e)
        {
            rec = DisplayRectangle;
            rec.Width -= 5;
            rec.Height = rec.Height - 5 - remainingHeight;
            this.Invalidate();
        }

        public new void Dispose()
        {
            for (int ctr = 0; ctr < Controls.Count; ctr++)
            {
                if (Controls[ctr] is PictureBox)
                {
                    if ((Controls[ctr] as PictureBox).Image != null) (Controls[ctr] as PictureBox).Image.Dispose();
                }
                (Controls[ctr] as Control).Dispose();
                ctr--;
            }
        }

        private void InitializePage()
        {
            richTextBox1.Text = selectedSolution.Solution;
            remainingHeight = 0;

            IssueSolutionAttachment attachment = DataHandler.FetchIssueSolutionAttachment(selectedSolution.IssueSolutionID);
            string extension = "";

            if (attachment == null)
            {
                solutionAttachmentTemplate1.Visible = false;
            }
            else
            {
                solutionAttachmentTemplate1.SelectedAttachment = attachment;
            }

            employeeProfilePicAndName1.Profile = EmployeeManager.FetchEmployeeFromID(selectedSolution.SolvedByID);
        }
    }
}