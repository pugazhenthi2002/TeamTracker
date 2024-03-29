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
    public partial class ProjectManagerMainForm : Form
    {
        static public NotificationManager notify;

        public ProjectManagerMainForm()
        {
            InitializeComponent();
        }

        private void OnHeaderPanelPaint(object sender, PaintEventArgs e)
        {
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawLine(border, new Point(0, headerPanel.Height - 2), new Point(headerPanel.Width, headerPanel.Height - 2));
            border.Dispose();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            ;
        }
    }
}
