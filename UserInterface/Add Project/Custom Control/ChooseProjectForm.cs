﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Add_Project.Custom_Control
{
    public partial class ChooseProjectForm : Form
    {
        public event EventHandler<Projects> ProjectSelect;

        public List<Projects> AvailableProjects
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    ucNotFound1.Visible = false;
                    availableProjects = value;
                    totalCount = value.Count % 2 == 0 ? value.Count / 2 : (value.Count / 2) + 1;
                    viewCount = totalCount > 3 ? 3 : totalCount;
                    endIdx = viewCount - 1;
                    isDownEnable = totalCount > 3;
                    InitializeTemplates();
                    ReorderProjects();
                }
                else
                {
                    ucNotFound1.Visible = true;
                    controlPanel.Visible = upPicBox.Visible = downPicBox.Visible = false;
                    selectButton.BackColor = selectButton.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
                }
            }
        }

        public ChooseProjectForm()
        {
            InitializeComponent();
            InitializePageColor();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            cancelButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancelButton.Width, cancelButton.Height, 10, 10));
            selectButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, selectButton.Width, selectButton.Height, 10, 10));
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            if (controlPanel.Controls != null)
            {
                for (int ctr = 0; ctr < controlPanel.Controls.Count; ctr++)
                {
                    (controlPanel.Controls[ctr] as SelectProjectTemplate).ProjectSelect -= OnProjectSelected;
                    (controlPanel.Controls[ctr] as SelectProjectTemplate).Dispose();
                    ctr--;
                }
            }

            if (downPicBox.Image != null)
                downPicBox.Image.Dispose();

            if (upPicBox.Image != null)
                upPicBox.Image.Dispose();

            ThemeManager.ThemeChange -= OnThemeChanged;
            upPicBox.Click -= OnPaginateUpClick; upPicBox.MouseEnter -= OnPaginateMouseEnter; upPicBox.MouseLeave -= OnPaginateMouseLeave;
            downPicBox.Click -= OnPaginateDownClick; upPicBox.MouseEnter -= OnPaginateMouseEnter; upPicBox.MouseLeave -= OnPaginateMouseLeave;
            cancelButton.Click -= OnCancelClick; cancelButton.MouseEnter -= OnButtonMouseEnter; cancelButton.MouseLeave -= OnButtonMouseLeave; cancelButton.Paint -= OnPaint;
            selectButton.Click -= OnSelectClick; selectButton.MouseEnter -= OnButtonMouseEnter; selectButton.MouseLeave -= OnButtonMouseLeave; selectButton.Paint -= OnPaint;
            tableLayoutPanel1.Paint -= OnBorderPaint;
        }

        private void InitializePageColor()
        {
            panel2.BackColor = cancelButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            ucNotFound1.BackColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            selectButton.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label1.ForeColor = cancelButton.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.PrimaryI);
            selectButton.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.SecondaryIII);

            upPicBox.Image?.Dispose();
            downPicBox.Image?.Dispose();

            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                upPicBox.Image = Properties.Resources.Cold_Up_Light;
            else
                downPicBox.Image = Properties.Resources.Heat_Down_Light;
        }

        private void OnPaginateUpClick(object sender, EventArgs e)
        {
            if (prevControl != null)
            {
                prevControl.IsClicked = false;
            }
            prevControl = null;

            if (isUpEnable)
            {
                startIdx--;
                endIdx--;
                ReorderProjects();
            }
        }

        private void OnPaginateDownClick(object sender, EventArgs e)
        {
            if (prevControl != null)
            {
                prevControl.IsClicked = false;
            }
            prevControl = null;

            if (isDownEnable)
            {
                startIdx++;
                endIdx++;
                ReorderProjects();
            }
        }

        private void OnSelectClick(object sender, EventArgs e)
        {
            if (prevControl == null)
            {
                ProjectManagerMainForm.notify.AddNotification("Warning", "No Projects Selected");
                return;
            }
            ProjectSelect?.Invoke(this, prevControl.Project);
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            ProjectSelect?.Invoke(this, null);
        }

        private void InitializeTemplates()
        {
            int projectCounter = 0;
            for (int ctr = 0; ctr <= endIdx; ctr++)
            {
                duoProjects = new List<Projects>() { availableProjects[projectCounter++] };
                if (projectCounter < availableProjects.Count) duoProjects.Add(availableProjects[projectCounter++]);

                SelectProjectTemplate control = new SelectProjectTemplate()
                {
                    Dock = DockStyle.Top,
                    DuoProject = duoProjects,
                };
                control.ProjectSelect += OnProjectSelected;
                controlPanel.Controls.Add(control);
                controlCollection.Add(control);
            }
            foreach(SelectProjectTemplate Iter in controlCollection)
            {
                Iter.BringToFront();
            }
        }

        private void OnProjectSelected(Projects project, SingleProjectSelectTemplate control)
        {
            if (prevControl != null)
            {
                prevControl.IsClicked = false;
            }
            prevControl = control;
            prevControl.IsClicked = true;
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(0,0), new Point(Width, 0));
            border.Dispose();
        }

        private void OnButtonMouseEnter(object sender, EventArgs e)
        {
            if (ucNotFound1.Visible && (sender as Label).Name == "selectButton")
            {
                return;
            }

            Cursor = Cursors.Hand;
            isEntered = true;
            if ((sender as Label).Name == "selectButton")
            {
                (sender as Label).BackColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryIII);
                (sender as Label).ForeColor = ThemeManager.GetTextColor((sender as Label).BackColor);
            }
            else
            {
                (sender as Label).BackColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.PrimaryI);
                (sender as Label).ForeColor = ThemeManager.GetTextColor((sender as Label).BackColor);
            }
            (sender as Label).Invalidate();
        }

        private void OnButtonMouseLeave(object sender, EventArgs e)
        {
            if (ucNotFound1.Visible && (sender as Label).Name == "selectButton")
            {
                return;
            }

            Cursor = Cursors.Default;
            isEntered = false;
            if ((sender as Label).Name == "selectButton")
            {
                (sender as Label).BackColor = ThemeManager.CurrentTheme.SecondaryII;
                (sender as Label).ForeColor = ThemeManager.GetTextColor((sender as Label).BackColor);
            }
            else
            {
                (sender as Label).BackColor = ThemeManager.CurrentTheme.PrimaryI;
                (sender as Label).ForeColor = ThemeManager.GetTextColor((sender as Label).BackColor);
            }
            (sender as Label).Invalidate();
        }

        private void OnPaginateMouseEnter(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            if(picBox.Name == "upPicBox")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    upPicBox.Image = Properties.Resources.Cold_Up_Light_Hover;
                }
                else
                {
                    upPicBox.Image = Properties.Resources.Heat_Up_Light_Hover;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    downPicBox.Image = Properties.Resources.Cold_Down_Light_Hover;
                }
                else
                {
                    downPicBox.Image = Properties.Resources.Heat_Down_Light_Hover;
                }
            }
        }

        private void OnPaginateMouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            if (picBox.Name == "upPicBox")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    upPicBox.Image = isUpEnable ? Properties.Resources.Cold_Up_Light : Properties.Resources.Cold_Up_Medium;
                }
                else
                {
                    upPicBox.Image = isUpEnable ? Properties.Resources.Heat_Up_Light : Properties.Resources.Heat_Up_Medium;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    downPicBox.Image = isDownEnable ? Properties.Resources.Cold_Down_Light : Properties.Resources.Cold_Down_Medium;
                }
                else
                {
                    downPicBox.Image = isDownEnable ? Properties.Resources.Heat_Down_Light : Properties.Resources.Heat_Down_Medium;
                }
            }
        }

        private void ReorderProjects()
        {
            int projectCounter = startIdx * 2;
            for (int ctr = startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
            {
                duoProjects = new List<Projects>() { availableProjects[projectCounter++] };
                if (projectCounter < availableProjects.Count) duoProjects.Add(availableProjects[projectCounter++]);

                controlCollection[idx].DuoProject = duoProjects;
            }

            isUpEnable = startIdx == 0 ? false : true;
            isDownEnable = endIdx == totalCount-1? false : true;

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                upPicBox.Image = isUpEnable ? Properties.Resources.Cold_Up_Light : Properties.Resources.Cold_Up_Medium;
                downPicBox.Image = isDownEnable ? Properties.Resources.Cold_Down_Light : Properties.Resources.Cold_Down_Medium;
            }
            else
            {
                upPicBox.Image = isUpEnable ? Properties.Resources.Heat_Up_Light  : Properties.Resources.Heat_Up_Medium;
                downPicBox.Image = isDownEnable ? Properties.Resources.Heat_Down_Light : Properties.Resources.Heat_Down_Medium;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        private bool isUpEnable = false, isDownEnable = false, isEntered;
        private int viewCount = 0, totalCount = 0, startIdx = 0, endIdx = 0;

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.SecondaryIII, 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1), 5));
                
        }

        private List<Projects> availableProjects;
        private List<Projects> duoProjects;
        private SingleProjectSelectTemplate prevControl;
        private List<SelectProjectTemplate> controlCollection = new List<SelectProjectTemplate>();
        private const int CSDropShadow = 0x00020000;
    }
}
