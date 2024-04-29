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
        public int BorderRadius { get { return borderRadius; }
            set
            {
                borderRadius = value;
            }
        }
        private int borderRadius;
        public bool IsOperable { get; set; }
        public bool IsBorderNeeded { get; set; }
        public Color HoverColor { get; set; }
        public Color NormalColor { get; set; }
        public Color BorderColor { get; set; }
        private Employee employeeProfile;
        private Color foreColor;

        public Color ProfileTextColor
        {
            get
            {
                return foreColor;
            }
            set
            {
                foreColor = designationLabel.ForeColor = employeeNameLabel.ForeColor = value;
            }
        }

        public ProfilePicAndName()
        {
            InitializeComponent();
        }

        public Employee EmployeeProfile
        {
            get
            {
                return employeeProfile;
            }

            set
            {
                employeeProfile = value;
                if (value != null)
                {
                    try
                    {
                        profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                    }
                    catch { }
                    designationLabel.Text = value.EmpRoleName;
                    employeeNameLabel.Text = value.EmployeeFirstName;
                }
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (IsOperable)
            {
                Cursor = Cursors.Hand;
                profilePictureBox1.ParentColor = BackColor = HoverColor;
                this.Invalidate();
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (IsOperable)
            {
                Cursor = Cursors.Default;
                profilePictureBox1.ParentColor = BackColor = NormalColor;
                this.Invalidate();
            }
        }

        private void OnCLicked(object sender, EventArgs e)
        {
            if (IsOperable)
            {
                SignOut.Invoke(this, e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (IsBorderNeeded)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen border = new Pen(BorderColor, 2);
                e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0,0,Width-1, Height-1), borderRadius));
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            profilePictureBox1.ParentColor = Parent.BackColor;
        }
    }
}
