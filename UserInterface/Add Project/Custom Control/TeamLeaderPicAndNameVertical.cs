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
        public TeamLeaderPicAndNameVertical()
        {
            InitializeComponent();
        }

        public Employee TeamLeader
        {
            set
            {
                if (value != null)
                {
                    tableLayoutPanel1.Visible = profilePictureBox1.Visible = true;
                    profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                    label1.Text = value.EmployeeFirstName;
                    label2.Text = value.EmpRoleName;
                }
                else
                {
                    tableLayoutPanel1.Visible = profilePictureBox1.Visible = false;
                }
            }
        }

        
    }
}
