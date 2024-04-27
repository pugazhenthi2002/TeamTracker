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
        }

        public new void Dispose()
        {
            for(int ctr=0; ctr < basePanel.Controls.Count; ctr++)
            {
                (basePanel.Controls[ctr] as EmployeeProfilePicAndName).EmployeeSelect -= OnEmployeeSelected;
                (basePanel.Controls[ctr] as EmployeeProfilePicAndName).Dispose();
                basePanel.Controls.RemoveAt(ctr);
                ctr--;
            }
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
            Dispose();
            profileControlCollection = new List<EmployeeProfilePicAndName>();
            startIdx = 0;   endIdx = filteredEmployeeCollection.Count >= 5 ? 4 : filteredEmployeeCollection.Count - 1;
            isBackEnable = false;   isNextEnabled = filteredEmployeeCollection.Count > 5 ? true : false;

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            upPicBox.Image = isBackEnable ? Properties.Resources.Up_Dark_Blue : Properties.Resources.Up_Medium_Blue;
            downPicBox.Image = isNextEnabled ? Properties.Resources.Down_Dark_Blue : Properties.Resources.Down_Medium_Blue;

            for(int ctr = 0; ctr <= endIdx; ctr++)
            {
                profilePicAndNameTemplate = new EmployeeProfilePicAndName()
                {
                    Profile = filteredEmployeeCollection[ctr],
                    Dock = DockStyle.Top,
                    NormalColor = Color.FromArgb(201, 210, 217),
                    HoverColor = Color.FromArgb(221, 230, 237),
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

        private bool isBackEnable = false, isNextEnabled = false;

        private void OnUpClicked(object sender, EventArgs e)
        {
            if (isBackEnable)
            {
                startIdx--; endIdx--;
                ReorderFilterUI();
            }
        }

        private void OnDownClicked(object sender, EventArgs e)
        {
            if (isNextEnabled)
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

            isBackEnable = startIdx == 0 ? false : true;
            isNextEnabled = endIdx == filteredEmployeeCollection.Count - 1 ? false : true;

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            upPicBox.Image = isBackEnable ? Properties.Resources.Up_Dark_Blue : Properties.Resources.Up_Medium_Blue;
            downPicBox.Image = isNextEnabled ? Properties.Resources.Down_Dark_Blue : Properties.Resources.Down_Medium_Blue;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Image != null) (sender as PictureBox).Image.Dispose();

            if((sender as PictureBox).Name == "upPicBox")
            {
                upPicBox.Image = Properties.Resources.Up_Dark_Blue_Hover;
            }
            else if ((sender as PictureBox).Name == "downPicBox")
            {
                downPicBox.Image = Properties.Resources.Down_Dark_Blue_Hover;
            }
            else
            {
                deleteFilterPicBox.Image = Properties.Resources.Close_Light_Blue_Hover;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Image != null) (sender as PictureBox).Image.Dispose();

            if ((sender as PictureBox).Name == "upPicBox")
            {
                upPicBox.Image = isBackEnable ? Properties.Resources.Up_Dark_Blue : Properties.Resources.Up_Medium_Blue;
            }
            else if((sender as PictureBox).Name == "downPicBox")
            {
                downPicBox.Image = isNextEnabled ? Properties.Resources.Down_Dark_Blue : Properties.Resources.Down_Medium_Blue;
            }
            else
            {
                deleteFilterPicBox.Image = Properties.Resources.Close_Dark_Blue;
            }
        }

        private void OnTextBoxBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            Rectangle rec = new Rectangle(richTextBox1.Location.X - 1, richTextBox1.Location.Y - 1, richTextBox1.Width + 1, richTextBox1.Height + 1);
            e.Graphics.DrawRectangle(border, rec);
            border.Dispose();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawLine(border, new Point(0,(sender as Control).Height - 1), new Point((sender as Control).Width, (sender as Control).Height - 1));
            border.Dispose();
        }

        private int startIdx = 0, endIdx = 0;
    }
}
