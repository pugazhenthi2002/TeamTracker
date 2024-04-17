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

        private Employee employee;

        public TeamLeaderPicAndName()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }

        public delegate void EmployeeHandler(Employee employee);
        public event EmployeeHandler TeamLeaderClick;


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
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



        private void InitializeRoundedEdge()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, panel1.Height, panel1.Height));

        }
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
                    profilePictureBox2.Image = Image.FromFile(value.EmpProfileLocation);
                }
            }
        }

        private void OnProfileClicked(object sender, EventArgs e)
        {
            TeamLeaderClick?.Invoke(employee);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            teamLeaderName.ForeColor = Color.FromArgb(39, 55, 77);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            teamLeaderName.ForeColor = Color.FromArgb(82, 109, 130);
        }

        public new void Dispose()
        {
            teamLeaderName.Dispose();
            profilePictureBox2.Image.Dispose();
            profilePictureBox2.Dispose();
            panel1.Dispose();
            tableLayoutPanel1.Dispose();
        }
    }
}
