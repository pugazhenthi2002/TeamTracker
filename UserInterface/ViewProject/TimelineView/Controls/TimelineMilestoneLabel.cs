using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.ViewProject.TimelineView.Controls
{
    public partial class TimelineMilestoneLabel : UserControl
    {
        public Color MilestoneColor
        {
            set
            {
                panel1.BackColor = value;
            }
        }

        public string MilestoneName
        {
            set
            {
                label1.Text = value;
            }
        }

        public TimelineMilestoneLabel()
        {
            InitializeComponent();
        }
    }
}
