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

namespace UserInterface.Home_Page.Project_Manager.Deploy
{
    public partial class DeployContent : UserControl
    {

        private Dictionary<string, ProjectVersion> deployVersions;
        private Color borderColor = Color.Blue;

        public DeployContent()
        {
            InitializeComponent();
        }


        public Dictionary<string, ProjectVersion> DeployVersions
        {
            set
            {
                deployVersions = value;
                if (value != null && value.Count > 0)
                {
                    label1.Text = value.First().Key;
                    ucDeploy1.Version = value.First().Value;
                }
                else
                {
                    label1.Text = "Deploy";
                    ucDeploy1.Visible = false;
                }
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
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

        private void OnVersionLabelClicked(object sender, EventArgs e)
        {
            if(deployVersions != null && deployVersions.Count > 1)
            {
                OverviewDropDownForm form = new OverviewDropDownForm()
                {
                    Location = Cursor.Position,
                    CurrentVersionCollection = deployVersions
                };
                form.OverviewSelected += Form_OverviewSelected;
                form.Show();
            }
        }

        private void Form_OverviewSelected(string name, ProjectVersion version)
        {
            label1.Text = name;
            ucDeploy1.Version = version;
        }

        private void OnDeployment(string name, ProjectVersion e)
        {
            deployVersions.Remove(name);
            if (deployVersions.Count > 0)
            {
                label1.Text = deployVersions.First().Key;
                ucDeploy1.Version = deployVersions.First().Value;
            }
            else
            {
                label1.Text = "Deploy";
                ucDeploy1.Visible = false;
            }
        }
    }
}
