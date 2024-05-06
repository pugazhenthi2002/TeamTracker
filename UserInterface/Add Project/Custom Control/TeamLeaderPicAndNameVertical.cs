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
            get
            {
                return teamLeader;
            }
            set
            {
                if (value != null)
                {
                    teamLeader = value;
                    tableLayoutPanel1.Visible = profilePictureBox1.Visible = true;
                    try
                    {
                        profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                    }
                    catch
                    {
                        ProjectManagerMainForm.notify.AddNotification("Error", "Couldn't able to load the Profile Image");
                    }
                    label1.Text = value.EmployeeFirstName;
                    label2.Text = value.EmpRoleName;
                }
                else
                {
                    tableLayoutPanel1.Visible = profilePictureBox1.Visible = false;
                }
            }
        }

        public TeamLeaderPicAndNameVertical()
        {
            InitializeComponent();
        }

        public new void Dispose()
        {
            if (profilePictureBox1.Image != null)
                profilePictureBox1.Image.Dispose();

            label1.Dispose();
            label2.Dispose();
            tableLayoutPanel1.Dispose();
            profilePictureBox1.Dispose();
        }

        private Employee teamLeader;
    }
}
