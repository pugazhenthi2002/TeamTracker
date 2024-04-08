using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TeamTracker
{
    public partial class LatestUpgradedVersion : UserControl
    {


        public LatestUpgradedVersion()
        {
            InitializeComponent();
            InitializeBorders();
        }


        public ProjectVersion LatestVersion
        {
            set
            {
                if (value != null)
                {
                    tableLayoutPanel1.Visible = true;
                    versionName.Text = value.VersionName;
                    startDateLabel.Text = value.StartDate.ToShortDateString();
                    endDateLabel.Text = value.EndDate.ToShortDateString();
                    clientEmailLabel.Text = value.ClientEmail;
                    taskCountLabel.Text = TaskManager.FetchTaskCount(value.VersionID).ToString();
                    descriptionLabel.Text = value.VersionDescription;
                }
                else
                {
                    tableLayoutPanel1.Visible = false;
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorders();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        
        private void InitializeBorders()
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
        }
    }
}
