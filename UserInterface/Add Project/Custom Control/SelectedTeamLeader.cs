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
        public event EventHandler OnChangeTeamLeader;

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
                    label2.Text = value.EmployeeFirstName;
                    if (profilePictureBox1.Image != null)
                    {
                        profilePictureBox1.Image.Dispose();
                    }
                    profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                }
            }
        }

        public SelectedTeamLeader()
        {
            InitializeComponent();
        }

        public new void Dispose()
        {
            if (profilePictureBox1.Image != null) profilePictureBox1.Image.Dispose();

            profilePictureBox1.Dispose();
            label1.Dispose();   label2.Dispose();   panel3.Dispose();
            tableLayoutPanel1.Dispose(); button1.Dispose();
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

        private void OnResize(object sender, EventArgs e)
        {
            profilePictureBox1.Height = tableLayoutPanel1.Height / 2;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(221, 230, 237);
            button1.ForeColor = Color.FromArgb(39, 55, 77);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(39, 55, 77);
            button1.ForeColor = Color.FromArgb(221, 230, 237);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawRectangle(border, new Rectangle(0, 0, button1.Width - 1, button1.Height - 1));
            border.Dispose();
        }

        private Employee employee;
    }
}
