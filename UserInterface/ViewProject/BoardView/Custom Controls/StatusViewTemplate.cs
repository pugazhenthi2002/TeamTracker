using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.ViewProject.BoardView.Custom_Controls
{
    public partial class StatusViewTemplate : UserControl
    {
        public List<ProjectVersion> VersionCollection
        {
            set
            {
                isUpEnable = false; isDownEnable = true;
                if (value != null && value.Count > 0)
                {
                    viewCount = value.Count <= 5 ? value.Count : 5;
                    endIdx = viewCount - 1;
                    versions = value;
                    InitializeVersions();
                }
            }
        }

        private bool isUpEnable = false, isDownEnable = true;
        private int startIdx = 0, endIdx = 0, viewCount = 0;
        private BoardViewTemplate control;
        private List<ProjectVersion> versions;
        private List<BoardViewTemplate> boardCollection;

        private void OnPaginateUp(object sender, EventArgs e)
        {

        }

        private void OnPaginateDown(object sender, EventArgs e)
        {

        }

        public StatusViewTemplate()
        {
            InitializeComponent();
        }

        private void InitializeVersions()
        {
            for(int ctr=0; ctr<=endIdx; ctr++)
            {
                control = new BoardViewTemplate()
                {
                    Dock = DockStyle.Top,
                    BoardVersion = versions[ctr],
                };
                boardBasePanel.Controls.Add(control);
                boardCollection.Add(control);
            }
        }

        private void ReorderVersions()
        {

        }
    }
}
