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
        private Color milestoneColor = Color.AliceBlue;
        public Color MilestoneColor
        {
            set
            {
                milestoneColor = value;
                panel1.Invalidate();
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

        private void OnPanelPaint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(milestoneColor);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, new Rectangle(1,1,panel1.Width-2, panel1.Height-2));
            brush.Dispose();
        }
    }
}
