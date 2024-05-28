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
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            if (profilePictureBox1.Image != null) profilePictureBox1.Image.Dispose();

            button1.Click -= OnChangeTLClick;   button1.MouseEnter -= OnMouseEnter; button1.MouseLeave -= OnMouseLeave; button1.Paint -= OnPaint;
            tableLayoutPanel1.Resize -= OnResize;
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void InitializePageColor()
        {
            label2.ForeColor = button1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            profilePictureBox1.ParentColor = ThemeManager.CurrentTheme.SecondaryII;
            button1.ForeColor = ThemeManager.GetTextColor(button1.BackColor);
            label1.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.SecondaryII);
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
            button1.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            button1.ForeColor = ThemeManager.GetTextColor(button1.BackColor);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            button1.ForeColor = ThemeManager.GetTextColor(button1.BackColor);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawRectangle(border, new Rectangle(0, 0, button1.Width - 1, button1.Height - 1));
            border.Dispose();
        }

        private Employee employee;
    }
}
