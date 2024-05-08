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

        public SelectProjectTemplate()
        {
            InitializeComponent();
            InitializePageColor();
        }

        public new void Dispose()
        {
            singleProjectSelectTemplate1.Dispose();
            singleProjectSelectTemplate2.Dispose();
            tableLayoutPanel1.Dispose();
        }

        private void InitializePageColor()
        {
            singleProjectSelectTemplate1.BackColor = singleProjectSelectTemplate2.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
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
            else singleProjectSelectTemplate2.Visible = false;
        }

        private Projects project1, project2;
    }
}
