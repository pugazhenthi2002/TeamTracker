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
        private Color borderColor;
        private ProjectStatus status;
        private bool isUpEnable = false, isDownEnable = true;
        private int startIdx = 0, endIdx = 0, viewCount = 0;
        private BoardViewTemplate control;
        private List<ProjectVersion> versions;
        private List<BoardViewTemplate> boardCollection;


        public StatusViewTemplate()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void InitializePageColor()
        {
            statusLabel.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            panel1.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;

            upPicBox.Image?.Dispose();
            downPicBox.Image?.Dispose();

            ResetButtons();
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            upPicBox.Image?.Dispose();
            downPicBox.Image?.Dispose();
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

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
                ResetButtons();
            }
        }

        

        private void OnPaginateUp(object sender, EventArgs e)
        {
            if (isUpEnable)
            {
                startIdx--;
                endIdx--;
                ReorderVersions();
            }
        }

        private void OnNavMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if((sender as PictureBox).Name == "upPicBox")
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Up_Dark_Hover : Properties.Resources.Heat_Up_Dark_Hover;
            }
            else
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Down_Dark_Hover : Properties.Resources.Heat_Down_Dark_Hover;
            }
        }

        private void OnNavMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as PictureBox).Name == "upPicBox")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    upPicBox.Image = isUpEnable ? Properties.Resources.Cold_Up_Dark : Properties.Resources.Cold_Up_Light;
                }
                else
                {
                    upPicBox.Image = isUpEnable ? Properties.Resources.Heat_Up_Dark : Properties.Resources.Heat_Up_Light;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    downPicBox.Image = isDownEnable ? Properties.Resources.Cold_Down_Dark : Properties.Resources.Cold_Down_Light;
                }
                else
                {
                    downPicBox.Image = isDownEnable ? Properties.Resources.Heat_Down_Dark : Properties.Resources.Heat_Down_Light;
                }
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

            ResetButtons();
        }

        private void ResetButtons()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                upPicBox.Image = isUpEnable ? Properties.Resources.Cold_Up_Dark : Properties.Resources.Cold_Up_Light;
                downPicBox.Image = isDownEnable ? Properties.Resources.Cold_Down_Dark : Properties.Resources.Cold_Down_Light;
            }
            else
            {
                upPicBox.Image = isUpEnable ? Properties.Resources.Heat_Up_Dark : Properties.Resources.Heat_Up_Light;
                downPicBox.Image = isDownEnable ? Properties.Resources.Heat_Down_Dark : Properties.Resources.Heat_Down_Light;
            }
        }
    }
}
