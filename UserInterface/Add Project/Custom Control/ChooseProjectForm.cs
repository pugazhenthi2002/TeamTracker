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
        private bool isUpEnable = false, isDownEnable = false;
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
        }

        public new void Dispose()
        {
            if(controlPanel.Controls != null)
            {
                for(int ctr=0; ctr < controlPanel.Controls.Count; ctr++)
                {
                    (controlPanel.Controls[ctr] as SelectProjectTemplate).Dispose();
                    ctr--;
                    controlPanel.Controls.Remove((controlPanel.Controls[ctr] as SelectProjectTemplate));
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
                    controlPanel.Visible = selectButton.Visible = upPicBox.Visible = downPicBox.Visible = false;
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
                prevControl.BackColor = Color.FromArgb(82, 109, 130);
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
                prevControl.BackColor = Color.FromArgb(82, 109, 130);
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
            Dispose();
            this.Close();
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
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
                prevControl.BackColor = Color.FromArgb(82, 109, 130);
            }
            prevControl = control;
            prevControl.BackColor = Color.FromArgb(221, 230, 237);
        }

        private void OnPaginateMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(102, 129, 150);
        }

        private void OnPaginateMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(82, 109, 130);
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

            upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
            downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
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
