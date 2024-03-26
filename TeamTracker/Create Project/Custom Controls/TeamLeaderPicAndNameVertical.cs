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
    public partial class TeamLeaderPicAndNameVertical : UserControl
    {
        public Employee TeamLeader
        {
            set
            {
                if (value != null)
                {
                    profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                    label1.Text = value.EmployeeFirstName;
                    label2.Text = value.EmpRoleName;
                }
            }
        }

        public TeamLeaderPicAndNameVertical()
        {
            InitializeComponent();
        }
    }
}
