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
    public partial class ProfilePicAndName : UserControl
    {
        public Employee EmployeeProfile
        {
            get
            {
                return employeeProfile;
            }

            set
            {
                employeeProfile = value;
                if(value!=null)
                {
                    profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                    designationLabel.Text = value.EmpRoleName;
                    employeeNameLabel.Text = value.EmployeeFirstName;
                }
            }
        }
        public ProfilePicAndName()
        {
            InitializeComponent();
        }

        private Employee employeeProfile;
    }
}
