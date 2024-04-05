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
        public event EventHandler SignOut;
        public bool isOperable { get; set; }
        public Color HoverColor { get; set; }
        public Color NormalColor { get; set; }
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

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (isOperable)
            {
                BackColor = HoverColor;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (isOperable)
            {
                BackColor = NormalColor;
            }
        }

        private void OnCLicked(object sender, EventArgs e)
        {
            if (isOperable)
            {
                SignOut.Invoke(this, e);
            }
        }
    }
}
