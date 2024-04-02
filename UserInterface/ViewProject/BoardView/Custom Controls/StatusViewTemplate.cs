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
        public List<ProjectVersion> VersionCollection
        {
            set
            {
                versions = value;
                InitializeVersions();
            }
        }

        private List<ProjectVersion> versions;
        public StatusViewTemplate()
        {
            InitializeComponent();
        }

        private void InitializeVersions()
        {

        }
    }
}
