using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class ProjectVersionForm : Form
    {
        public ProjectVersionForm()
        {
            InitializeComponent();
            InitializeProject();
        }

        public List<ProjectVersion> PrjVersionList
        {
            get
            {
                return ProjectVersionList;
            }
            set
            {
                if (value != null)
                {
                    ProjectVersionList = value;
                }
            }

        }

        private List<ProjectVersion> ProjectVersionList = new List<ProjectVersion>();


        private void InitializeProject()
        {
            
        }
    }
}
