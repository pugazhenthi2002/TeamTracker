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

        private void OnBoardClicked(object sender, EventArgs e)
        {
            boardPanel.BackColor = Color.FromArgb(39, 55, 77);
            timelinePanel.BackColor = Color.FromArgb(221, 230, 237);
            tabControl1.SelectedIndex = 0;
        }

        private void OnTimelineClicked(object sender, EventArgs e)
        {
            timelinePanel.BackColor = Color.FromArgb(39, 55, 77);
            boardPanel.BackColor = Color.FromArgb(221, 230, 237);
            timelineView1.ProjectCollection = VersionManager.ProjectCollection;
            tabControl1.SelectedIndex = 1;
        }
    }
}
