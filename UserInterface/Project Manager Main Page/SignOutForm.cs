using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Project_Manager_Main_Page
{
    public partial class SignOutForm : Form
    {
        public event EventHandler SignOut;

        public SignOutForm()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label1.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }

        private void OnSignOutClick(object sender, EventArgs e)
        {
            SignOut?.Invoke(this, e);
            this.Close();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            BackColor = ThemeManager.GetHoverColor(BackColor);
            label1.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label1.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private const int CSDropShadow = 0x00020000;

        private void button1_Click(object sender, EventArgs e)
        {
            ThemeManager.OnThemeChanged();
        }
    }
}
