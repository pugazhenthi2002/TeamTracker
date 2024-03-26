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

        public delegate void EmployeeHandler(Employee employee);
        public event EmployeeHandler TeamLeaderClick;
        public TeamLeaderPicAndName()
        {
            InitializeComponent();
        }

        private Employee employee;

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
