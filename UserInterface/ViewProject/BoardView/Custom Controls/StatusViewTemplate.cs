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
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                panel2.BackColor = value;
            }
        }
        public ProjectStatus Status
        {
            get { return status; }
            set
            {
                status = value;
                statusLabel.Text = value.ToString();
            }
        }
        public List<ProjectVersion> VersionCollection
        {
            set
            {
                if(boardBasePanel.Controls != null)
                {
                    boardBasePanel.Controls.Clear();
                }

                if (upPicBox.Image != null) upPicBox.Image.Dispose();
                if (downPicBox.Image != null) downPicBox.Image.Dispose();

                isUpEnable = false; isDownEnable = true;
                if (value != null && value.Count > 0)
                {
                    viewCount = value.Count <= 5 ? value.Count : 5;
                    endIdx = viewCount - 1;
                    isDownEnable = endIdx <= value.Count - 1 ? false : true;
                    versions = value;
                    InitializeVersions();
                }
                else
                {
                    isDownEnable = false;
                }
                upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
                downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
            }
        }

        private Color borderColor;
        private ProjectStatus status;
        private bool isUpEnable = false, isDownEnable = true;
        private int startIdx = 0, endIdx = 0, viewCount = 0;
        private BoardViewTemplate control;
        private List<ProjectVersion> versions;
        private List<BoardViewTemplate> boardCollection;

        private void OnPaginateUp(object sender, EventArgs e)
        {
            if (isUpEnable)
            {
                startIdx--;
                endIdx--;
                ReorderVersions();
            }
        }

        private void OnPaginateDown(object sender, EventArgs e)
        {
            if (isDownEnable)
            {
                startIdx++;
                endIdx++;
                ReorderVersions();
            }
        }

        public StatusViewTemplate()
        {
            InitializeComponent();
        }

        private void InitializeVersions()
        {
            boardCollection = new List<BoardViewTemplate>();
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
            for(int ctr=startIdx, idx = 0; ctr<=endIdx; ctr++, idx++)
            {
                boardCollection[idx].BoardVersion = versions[ctr];
            }

            isUpEnable = startIdx == 0 ? false : true;
            isUpEnable = endIdx == versions.Count - 1 ? false : true;

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
            downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
        }
    }
}
