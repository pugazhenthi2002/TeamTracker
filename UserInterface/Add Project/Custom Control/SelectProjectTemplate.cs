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
using System.Runtime.InteropServices;

namespace UserInterface.Add_Project.Custom_Control
{
    public partial class SelectProjectTemplate : UserControl
    {

        public delegate void ProjectHandler(Projects project, SingleProjectSelectTemplate control);
        public event ProjectHandler ProjectSelect;

        public List<Projects> DuoProject
        {
            set
            {
                project1 = value.Count > 0 ? value[0] : null;
                project2 = value.Count > 1 ? value[1] : null;
                if (value.Count > 0)
                    InitializeTemplate();
            }
        }

        private Projects project1, project2;
        public SelectProjectTemplate()
        {
            InitializeComponent();
        }

        private void OnProjectSelected(object sender, Projects project)
        {
            ProjectSelect?.Invoke(project, sender as SingleProjectSelectTemplate);
        }

        private void InitializeTemplate()
        {
            singleProjectSelectTemplate1.Project = project1;
            if (project2 != null)
            {
                singleProjectSelectTemplate2.Visible = true;
                singleProjectSelectTemplate2.Project = project2;
            }
            else singleProjectSelectTemplate2.Visible = true;

            singleProjectSelectTemplate1.Region = singleProjectSelectTemplate2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, singleProjectSelectTemplate1.Width, singleProjectSelectTemplate1.Height, 20, 20));
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
