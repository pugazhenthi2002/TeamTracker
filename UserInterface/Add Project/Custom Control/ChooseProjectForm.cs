using System;
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
        private bool isUpEnable = false, isDownEnable = false, isEntered;
        private int viewCount = 0, totalCount = 0, startIdx = 0, endIdx = 0;
        private List<Projects> availableProjects;
        private List<Projects> duoProjects;
        private SingleProjectSelectTemplate prevControl;
        private List<SelectProjectTemplate> controlCollection = new List<SelectProjectTemplate>();
        private const int CSDropShadow = 0x00020000;

        public ChooseProjectForm()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            cancelButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancelButton.Width, cancelButton.Height, 10, 10));
            selectButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, selectButton.Width, selectButton.Height, 10, 10));
        }

        public new void Dispose()
        {
            if(controlPanel.Controls != null)
            {
                for(int ctr=0; ctr < controlPanel.Controls.Count; ctr++)
                {
                    (controlPanel.Controls[ctr] as SelectProjectTemplate).Dispose();
                    controlPanel.Controls.Remove((controlPanel.Controls[ctr] as SelectProjectTemplate));
                    ctr--;
                }
            }
            downPicBox.Image.Dispose(); downPicBox.Dispose();
            upPicBox.Image.Dispose();   upPicBox.Dispose();
            label1.Dispose();
            cancelButton.Dispose(); selectButton.Dispose();
            tableLayoutPanel1.Dispose();
            tableLayoutPanel2.Dispose();
            panel1.Dispose();
            panel2.Dispose();
            controlPanel.Dispose();
            ucNotFound1.Dispose();
        }

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
                    selectButton.BackColor = selectButton.ForeColor = Color.FromArgb(157, 178, 191);
                }
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
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawLine(border, new Point(0,0), new Point(Width, 0));
            border.Dispose();
        }

        private void OnButtonMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            isEntered = true;
            if ((sender as Button).Name == "selectButton")
            {
                if (!ucNotFound1.Visible)
                {
                    (sender as Button).BackColor = Color.FromArgb(40, 50, 80);
                    (sender as Button).ForeColor = Color.FromArgb(221, 230, 237);
                }
            }
            else
            {
                (sender as Button).ForeColor = Color.FromArgb(40, 50, 80);
                (sender as Button).BackColor = Color.FromArgb(221, 230, 237);
            }
            (sender as Button).Invalidate();
        }

        private void OnButtonMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            isEntered = false;
            if ((sender as Button).Name == "selectButton")
            {
                if (!ucNotFound1.Visible)
                {
                    (sender as Button).ForeColor = Color.FromArgb(40, 50, 80);
                    (sender as Button).BackColor = Color.FromArgb(221, 230, 237);
                }
            }
            else
            {
                (sender as Button).BackColor = Color.FromArgb(40, 50, 80);
                (sender as Button).ForeColor = Color.FromArgb(221, 230, 237);
            }
            (sender as Button).Invalidate();
        }


        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border;
            Rectangle rec = new Rectangle(2,2,(sender as Button).Width -6, (sender as Button).Height-6);
            border = isEntered ? new Pen((sender as Button).ForeColor, 2) : new Pen((sender as Button).BackColor, 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(rec, 2));
            border.Dispose();
            rec = new Rectangle(0, 0, (sender as Button).Width - 2, (sender as Button).Height - 2);
            border = new Pen(Color.FromArgb(157, 178, 191), 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(rec, 5));
            border.Dispose();
        }

        private void OnPaginateMouseEnter(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Hand;
            if(picBox.Name == "upPicBox")
            {
                picBox.Image = Properties.Resources.Up_Light_Blue_Hover;
            }
            else
            {
                picBox.Image = Properties.Resources.Down_Light_Blue_Hover;
            }
        }

        private void OnPaginateMouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Default;
            if (picBox.Name == "upPicBox")
            {
                picBox.Image = isUpEnable ? Properties.Resources.Up_Light_Blue : Properties.Resources.Up_Medium_Blue;
            }
            else
            {
                picBox.Image = isDownEnable ? Properties.Resources.Down_Light_Blue : Properties.Resources.Down_Medium_Blue;
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

            upPicBox.Image = isUpEnable ? Properties.Resources.Up_Light_Blue_Hover : Properties.Resources.Up_Medium_Blue;
            downPicBox.Image = isDownEnable ? Properties.Resources.Down_Light_Blue : Properties.Resources.Down_Medium_Blue;
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


        
    }
}
