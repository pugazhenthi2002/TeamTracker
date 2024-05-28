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
using UserInterface.ViewProject;

namespace UserInterface.Issues.All_Issue_Page
{
    public partial class FilterPeople : UserControl
    {
        public event EventHandler<Employee> EmployeeSelect;
        private EmployeeProfilePicAndName profilePicAndNameTemplate;
        private List<Employee> filteredEmployeeCollection;
        private List<EmployeeProfilePicAndName> profileControlCollection;

        public FilterPeople()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;

            BasePanelControlClear();
        }

        private void InitializePageColor()
        {
            richTextBox1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            label3.ForeColor = richTextBox1.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            deleteFilterPicBox.BackColor = profilePicAndName1.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            profilePicAndName1.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.SecondaryI);

            upPicBox.Image?.Dispose();  downPicBox.Image?.Dispose();    deleteFilterPicBox?.Image?.Dispose();
            
            deleteFilterPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold? Properties.Resources.Cold_Close_Dark:Properties.Resources.Heat_Close_Dark;
            ResetButtons();
        }

        public void InitializeFilter()
        {
            OnEmployeeFilterTextChanged(richTextBox1, EventArgs.Empty);
            panel2.Visible = false;
        }

        private void OnEmployeeFilterTextChanged(object sender, EventArgs e)
        {
            basePanel.SuspendLayout();
            FilterEmployeeChanged(richTextBox1.Text.ToLower());
            InitializeFilterUI();
            basePanel.ResumeLayout(true);
        }

        private void FilterEmployeeChanged(string empName)
        {
            filteredEmployeeCollection = new List<Employee>();
            foreach(var Iter in EmployeeManager.EmployeeCollection)
            {
                if((Iter != EmployeeManager.CurrentEmployee) && (Iter.EmployeeFirstName.ToLower().Contains(empName) || Iter.EmployeeLastName.ToLower().Contains(empName)))
                {
                    filteredEmployeeCollection.Add(Iter);
                }
            }
        }

        private void InitializeFilterUI()
        {
            BasePanelControlClear();
            profileControlCollection = new List<EmployeeProfilePicAndName>();
            startIdx = 0;   endIdx = filteredEmployeeCollection.Count >= 5 ? 4 : filteredEmployeeCollection.Count - 1;
            isUpEnable = false;   isDownEnable = filteredEmployeeCollection.Count > 5 ? true : false;

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            ResetButtons();

            for(int ctr = 0; ctr <= endIdx; ctr++)
            {
                profilePicAndNameTemplate = new EmployeeProfilePicAndName()
                {
                    Profile = filteredEmployeeCollection[ctr],
                    Dock = DockStyle.Top,
                    NormalColor = ThemeManager.CurrentTheme.SecondaryII,
                    HoverColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryII),
                    Height = 50
                };
                profilePicAndNameTemplate.EmployeeSelect += OnEmployeeSelected;
                profileControlCollection.Add(profilePicAndNameTemplate);
                basePanel.Controls.Add(profilePicAndNameTemplate);
            }

            foreach(var Iter in profileControlCollection)
            {
                Iter.BringToFront();
            }
        }

        private void OnEmployeeSelected(object sender, Employee e)
        {
            profilePicAndName1.EmployeeProfile = e;
            panel2.Visible = true;
            EmployeeSelect?.Invoke(this, e);
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EmployeeSelect?.Invoke(this, null);
        }

        private bool isUpEnable = false, isDownEnable = false;

        private void OnUpClicked(object sender, EventArgs e)
        {
            if (isUpEnable)
            {
                startIdx--; endIdx--;
                ReorderFilterUI();
            }
        }

        private void OnDownClicked(object sender, EventArgs e)
        {
            if (isDownEnable)
            {
                startIdx++; endIdx++;
                ReorderFilterUI();
            }
        }

        private void ReorderFilterUI()
        {
            for (int ctr = startIdx, idx=0; ctr <= endIdx; ctr++, idx++)
            {
                profileControlCollection[idx].Profile = filteredEmployeeCollection[ctr];
            }

            isUpEnable = startIdx == 0 ? false : true;
            isDownEnable = endIdx == filteredEmployeeCollection.Count - 1 ? false : true;

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            ResetButtons();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as PictureBox).Name == "upPicBox")
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Up_Dark_Hover : Properties.Resources.Heat_Up_Dark_Hover;
            }
            else if ((sender as PictureBox).Name == "downPicBox")
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Down_Dark_Hover : Properties.Resources.Heat_Down_Dark_Hover;
            }
            else
            {
                (sender as PictureBox).Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Dark_Hover : Properties.Resources.Heat_Close_Dark_Hover;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
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
            else if((sender as PictureBox).Name == "downPicBox")
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
            else
            {
                deleteFilterPicBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Dark : Properties.Resources.Heat_Close_Dark;
            }
        }

        private void OnTextBoxBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            Rectangle rec = new Rectangle(richTextBox1.Location.X - 1, richTextBox1.Location.Y - 1, richTextBox1.Width + 1, richTextBox1.Height + 1);
            e.Graphics.DrawRectangle(border, rec);
            border.Dispose();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(0,(sender as Control).Height - 1), new Point((sender as Control).Width, (sender as Control).Height - 1));
            border.Dispose();
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

        private void BasePanelControlClear()
        {
            for(int ctr = 0; ctr < basePanel.Controls.Count; ctr++)
            {
                (basePanel.Controls[ctr] as EmployeeProfilePicAndName).EmployeeSelect -= OnEmployeeSelected;
                (basePanel.Controls[ctr] as EmployeeProfilePicAndName).Dispose();
                ctr--;
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private int startIdx = 0, endIdx = 0;
    }
}
