using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class MilestoneLabel : UserControl
    {
        public MilestoneLabel()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void donePanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, donePanel.Width - 1, donePanel.Height - 1);
            Brush brush = new SolidBrush(Color.FromArgb(3, 4, 94));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, rec);
            brush.Dispose();
        }

        private void currentPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, currentPanel.Width - 1, currentPanel.Height - 1);
            Brush brush = new SolidBrush(Color.FromArgb(0, 180, 216));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, rec);
            brush.Dispose();
        }

        private void notStartedPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, notStartedPanel.Width - 1, notStartedPanel.Height - 1);
            Brush brush = new SolidBrush(Color.FromArgb(72, 202, 228));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, rec);
            brush.Dispose();
        }

        private void delayPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, delayPanel.Width - 1, delayPanel.Height - 1);
            Brush brush = new SolidBrush(Color.FromArgb(0, 119, 182));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, rec);
            brush.Dispose();
        }
    }
}
