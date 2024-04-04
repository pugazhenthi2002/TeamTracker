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

namespace UserInterface.ViewProject
{
    public partial class ViewProjectTemplate : UserControl
    {
        public ViewProjectTemplate()
        {
            InitializeComponent();
        }

        public void InitializeViewProject()
        {
            tabControl1.SelectedIndex = 0;
        }

        private void OnBoardClicked(object sender, EventArgs e)
        {
            if(boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }
            if(timelinePicBox.Image != null) { timelinePicBox.Image.Dispose(); }

            boardPanel.BackColor = Color.FromArgb(39, 55, 77);
            timelinePanel.BackColor = Color.FromArgb(221, 230, 237);
            boardLabel.ForeColor = Color.FromArgb(221, 230, 237);
            timelineLabel.ForeColor = Color.FromArgb(39, 55, 77);

            boardPicBox.Image = UserInterface.Properties.Resources.Board_Click;
            timelinePicBox.Image = UserInterface.Properties.Resources.Timeline_Normal;

            boardViewContent1.VersionCollection = VersionManager.CurrentEmployeeInvolvedVersions();
            tabControl1.SelectedIndex = 0;
        }

        private void OnTimelineClicked(object sender, EventArgs e)
        {
            if (boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }
            if (timelinePicBox.Image != null) { timelinePicBox.Image.Dispose(); }

            timelinePanel.BackColor = Color.FromArgb(39, 55, 77);
            boardPanel.BackColor = Color.FromArgb(221, 230, 237);
            timelineLabel.ForeColor = Color.FromArgb(221, 230, 237);
            boardLabel.ForeColor = Color.FromArgb(39, 55, 77);

            boardPicBox.Image = UserInterface.Properties.Resources.Board_Normal;
            timelinePicBox.Image = UserInterface.Properties.Resources.Timeline_Click;

            timelineView1.ProjectCollection = VersionManager.ProjectCollection;
            tabControl1.SelectedIndex = 1;
        }

        private void OnFilterClicked(object sender, EventArgs e)
        {
            if(EmployeeManager.CurrentEmployee.EmpRoleName == "Project Manager")
            {

            }
            else if(EmployeeManager.CurrentEmployee.EmpRoleName == "Team Leader")
            {

            }
            else
            {

            }
        }
    }
}
