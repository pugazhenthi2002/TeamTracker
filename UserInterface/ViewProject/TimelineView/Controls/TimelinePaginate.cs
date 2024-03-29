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

namespace UserInterface.ViewProject.TimelineView.Controls
{
    public partial class TimelinePaginate : UserControl
    {
        public TimelinePaginate()
        {
            InitializeComponent();
        }

        public ProjectVersion Version
        {
            set
            {
                version = value;
                InitializeTimeline();
            }
        }

        private ProjectVersion version;

        private void InitializeTimeline()
        {

        }
    }
}
