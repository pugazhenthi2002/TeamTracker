using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.ViewPage.ListView
{
    public partial class StatusChangeWarningForm : Form
    {
        public delegate void WarningHandler(object sender, string status, bool value);
        public event WarningHandler WarningStatus;

        public StatusChangeWarningForm()
        {
            InitializeComponent();
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            noButton.BackColor = yesButton.BackColor = panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label2.ForeColor = ThemeManager.GetTextColor(BackColor);
            label1.ForeColor = noButton.ForeColor = yesButton.ForeColor = ThemeManager.GetTextColor(noButton.BackColor);
        }

        private void OnYesClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, PrevStatus, true);
        }

        private void OnNoClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, PrevStatus, false);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
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

        public string PrevStatus;
        private const int CSDropShadow = 0x00020000;
    }
}
