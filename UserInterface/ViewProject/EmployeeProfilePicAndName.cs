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
                if (profilePictureBox1.Image != null) profilePictureBox1.Image.Dispose();
                try
                {
                    profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                }
                catch { }
                label1.Text = value.EmployeeFirstName;
            }
        }
        public Color NormalColor { get; set; }
        public Color HoverColor { get; set; }

        public override Color ForeColor
        {
            get { return label1.ForeColor; }
            set { label1.ForeColor = value; }
        }

        public new void Dispose()
        {
            if (profilePictureBox1.Image != null) profilePictureBox1.Image.Dispose();
            profilePictureBox1.Dispose();

            label1.Dispose();
            tableLayoutPanel1.Dispose();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            profilePictureBox1.ParentColor = BackColor = HoverColor;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            profilePictureBox1.ParentColor = BackColor = NormalColor;
        }

        private void OnClicked(object sender, EventArgs e)
        {
            EmployeeSelect?.Invoke(this, profile);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            profilePictureBox1.ParentColor = BackColor;
        }
    }
}
