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
    public partial class TeamLeaderPicAndName : UserControl
    {
        public delegate void EmployeeHandler(Employee employee);
        public event EmployeeHandler TeamLeaderClick;

        public Employee EmployeeProfile
        {
            get
            {
                return employee;
            }

            set
            {
                employee = value;
                if (value != null)
                {
                    teamLeaderName.Text = value.EmployeeFirstName;
                    try
                    {
                        profilePictureBox2.Image = Image.FromFile(value.EmpProfileLocation);
                    }
                    catch
                    {
                        ProjectManagerMainForm.notify.AddNotification("Error", "Couldn't able to load the Profile Image");
                    }
                }
            }
        }

        public TeamLeaderPicAndName()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }

        public new void Dispose()
        {
            teamLeaderName.Dispose();

            if (profilePictureBox2.Image != null)
                profilePictureBox2.Image.Dispose();

            profilePictureBox2.Dispose();
            panel1.Dispose();
            tableLayoutPanel1.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, panel1.Height, panel1.Height));

        }

        private void OnProfileClicked(object sender, EventArgs e)
        {
            TeamLeaderClick?.Invoke(employee);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            IsEntered = true;
            teamLeaderName.ForeColor = Color.FromArgb(39, 55, 77);
            panel1.Invalidate();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            IsEntered = false;
            teamLeaderName.ForeColor = Color.FromArgb(82, 109, 130);
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

        private bool IsEntered;
        private Employee employee;
    }
}
