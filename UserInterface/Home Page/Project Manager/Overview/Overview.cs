using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using TeamTracker;

namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class Overview : UserControl
    {
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        private Color borderColor = Color.Blue;

        public Overview()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Point pt1 = new Point(9, 9);
            Point pt2 = new Point(Width - 11, 9);
            Point pt3 = new Point(Width - 11, Height - 11);
            Point pt4 = new Point(9, Height - 11);
            Pen border = new Pen(borderColor, 3);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void OnOverviewClick(object sender, EventArgs e)
        {
            Dictionary <string, ProjectVersion> collection = new Dictionary<string, ProjectVersion>();
            collection.Add("Pedestrian Detection", new ProjectVersion() { VersionName = "v 1.0" });
            collection.Add("Chat Application", new ProjectVersion() { VersionName = "v 2.0" });
            collection.Add("Expense Tracker", new ProjectVersion() { VersionName = "v 1.3" });
            OverviewDropDownForm form = new OverviewDropDownForm();
            form.BackColor = Color.FromArgb(221, 230, 237);
            form.currentVersionCollection = collection;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = Cursor.Position;
            form.Show();

        }
    }
}
