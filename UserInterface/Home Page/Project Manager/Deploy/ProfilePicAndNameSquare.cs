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
    public partial class ProfilePicAndNameSquare : UserControl
    {
        public Employee empProfile
        {
            set
            {
                if (value != null)
                {
                    profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                    labelName.Text = value.EmployeeFirstName;
                }
            }
        }
        public ProfilePicAndNameSquare()
        {
            InitializeComponent();
        }

        public void SetImage(Image image)
        {
            profilePictureBox1.Image = image;
        }
    }
}
