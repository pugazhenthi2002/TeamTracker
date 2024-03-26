using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Project_Manager_Main_Page
{
    public partial class ProjectManagerMainForm : Form
    {
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
    }
}
