using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.ViewProject
{
    public partial class EmployeeProfilePicAndName : UserControl
    {

        private Employee profile;

        public EmployeeProfilePicAndName()
        {
            InitializeComponent();
        }

        public event EventHandler<Employee> EmployeeSelect;

        public Employee Profile
        {
            set
            {
                profile = value;
                profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                label1.Text = value.EmployeeFirstName;
            }
        }
        public Color NormalColor { get; set; }
        public Color HoverColor { get; set; }

        

        private void OnMouseEnter(object sender, EventArgs e)
        {
            BackColor = HoverColor;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            BackColor = NormalColor;
        }

        private void OnClicked(object sender, EventArgs e)
        {
            EmployeeSelect?.Invoke(this, profile);
        }
    }
}
