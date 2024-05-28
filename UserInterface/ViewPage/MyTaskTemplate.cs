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

namespace UserInterface.ViewPage
{
    public partial class MyTaskTemplate : UserControl
    {
        public MyTaskTemplate()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        public void InitializePage()
        {
            if(VersionManager.CurrentVersion == null)
            {
                panel1.Visible = false;
                return;
            }
            else
            {
                panel1.Visible = true;
                if (tabControl1.SelectedIndex == 0)
                {
                    boardLabel.ForeColor = listLabel.BackColor = listPicBox.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
                    listLabel.ForeColor = boardLabel.BackColor = boardPicBox.BackColor = ThemeManager.CurrentTheme.PrimaryI;
                    boardPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Board_Light : Properties.Resources.Heat_Board_Light;
                    listPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_List_Dark : Properties.Resources.Heat_List_Dark;
                }
                else
                {
                    boardLabel.ForeColor = listLabel.BackColor = listPicBox.BackColor = ThemeManager.CurrentTheme.PrimaryI;
                    listLabel.ForeColor = boardLabel.BackColor = boardPicBox.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
                    boardPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Board_Dark : Properties.Resources.Heat_Board_Dark;
                    listPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_List_Light : Properties.Resources.Heat_List_Light;
                }
            }
            OnBoardClick(boardPicBox, EventArgs.Empty);
        }

        private void InitializePageColor()
        {
            ucTaskBoardBase1.BackColor = listViewTemplate1.BackColor = listPanel.BackColor = panel2.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            ucNotFound1.BackColor = BackColor = tabPage1.BackColor = tabPage2.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            boardPanel.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            listLabel.ForeColor = ThemeManager.GetTextColor(panel2.BackColor);
            boardLabel.ForeColor = ThemeManager.GetTextColor(boardPanel.BackColor);

            if (tabControl1.SelectedIndex == 0)
            {
                boardLabel.ForeColor = listLabel.BackColor = listPicBox.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
                listLabel.ForeColor = boardLabel.BackColor = boardPicBox.BackColor = ThemeManager.CurrentTheme.PrimaryI;
                boardPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Board_Light : Properties.Resources.Heat_Board_Light;
                listPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_List_Dark : Properties.Resources.Heat_List_Dark;
            }
            else
            {
                boardLabel.ForeColor = listLabel.BackColor = listPicBox.BackColor = ThemeManager.CurrentTheme.PrimaryI;
                listLabel.ForeColor = boardLabel.BackColor = boardPicBox.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
                boardPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Board_Dark : Properties.Resources.Heat_Board_Dark;
                listPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_List_Light : Properties.Resources.Heat_List_Light;
            }
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void OnBoardClick(object sender, EventArgs e)
        {
            ucTaskBoardBase1.CurrentProjVersion = VersionManager.CurrentVersion;
            tabControl1.SelectedIndex = 0;
            boardLabel.ForeColor = listLabel.BackColor = listPicBox.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            listLabel.ForeColor = boardLabel.BackColor = boardPicBox.BackColor = ThemeManager.CurrentTheme.PrimaryI;

            if (listPicBox.Image != null) { listPicBox.Image.Dispose(); }
            if (boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }

            listPicBox.Image = Properties.Resources.List_Normal;
            boardPicBox.Image = Properties.Resources.Board_Click;
        }

        private void OnListClick(object sender, EventArgs e)
        {
            listViewTemplate1.DoneTaskCollection = TaskManager.FetchTasks(VersionManager.CurrentVersion.VersionID, TeamTracker.TaskStatus.Done);
            listViewTemplate1.RemainingTaskCollection = TaskManager.FetchRemainingTasks(VersionManager.CurrentVersion.VersionID, TeamTracker.TaskStatus.Done);
            listViewTemplate1.InitializePage();
            tabControl1.SelectedIndex = 1;
            boardLabel.ForeColor = listLabel.BackColor = listPicBox.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            listLabel.ForeColor = boardLabel.BackColor = boardPicBox.BackColor = ThemeManager.CurrentTheme.SecondaryIII;

            if (listPicBox.Image != null) { listPicBox.Image.Dispose(); }
            if (boardPicBox.Image != null) { boardPicBox.Image.Dispose(); }

            listPicBox.Image = Properties.Resources.List_Hover;
            boardPicBox.Image = Properties.Resources.Board_Normal;
        }
    }
}
