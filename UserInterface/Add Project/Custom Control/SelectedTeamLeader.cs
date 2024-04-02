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
    public partial class SelectedTeamLeader : UserControl
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
                if(value!=null)
                {
                    label2.Text = value.EmployeeFirstName;
                    if(profilePictureBox1.Image != null)
                    {
                        profilePictureBox1.Image.Dispose();
                    }
                    profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                }
            }
        }

        public event EventHandler OnChangeTeamLeader;
        public SelectedTeamLeader()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            int value = (Width - profilePictureBox1.Width) / 2;
        }

        private void OnChangeTLClick(object sender, EventArgs e)
        {
            OnChangeTeamLeader?.Invoke(this, new EventArgs());
        }

        private Employee employee;

        private void OnResize(object sender, EventArgs e)
        {
            profilePictureBox1.Height = tableLayoutPanel1.Height / 2;
        }
    }
}
