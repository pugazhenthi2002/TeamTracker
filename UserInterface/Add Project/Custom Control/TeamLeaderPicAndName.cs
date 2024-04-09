using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class TeamLeaderPicAndName : UserControl
    {

        private Employee employee;

                public TeamLeaderPicAndName()
        {
            InitializeComponent();
        }

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
    }
}
