using GoLibrary;
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

namespace TeamTracker
{
    public partial class LoginForm : Form
    {
        BooleanMsg message;
        public LoginForm()
        {
            InitializeComponent();
            message = DataHandler.ConnectDatabase();

            if (!message.Result) { errorMessageLabel.Text = "* Unable to Connect Database"; }

            message = message.Result && EmployeeManager.StoreEmployeeToCollection();
            if (message.Message != "" && !message.Result) { errorMessageLabel.Text = message; }
        }

        private const int CSDropShadow = 0x00020000;
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            letsTeamUpButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, letsTeamUpButton.Width, letsTeamUpButton.Height, 10, 10));
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void OnTeamUpClick(object sender, EventArgs e)
        {
            message = message.Result && EmployeeManager.LogInEmployee(username.TextBoxtext, password.TextBoxtext);
            if(message.Message!="" && message!=true) { errorMessageLabel.Text = message; }

            if (message == true)
            {
                EmployeeManager.StoreEmployeeManagingCollection();
                VersionManager.StoreProjectCollection();
                VersionManager.StoreVersionCollection();
                SelectPageBasedOnRole();
            }
        }

        private void SelectPageBasedOnRole()
        {
            
        }

        private void OnCloseEnter(object sender, EventArgs e)
        {
            if(closePictureBox.Image!=null) closePictureBox.Image.Dispose();

            closePictureBox.Image = UserInterface.Properties.Resources.Close_Red;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (closePictureBox.Image != null) closePictureBox.Image.Dispose();

            closePictureBox.Image = UserInterface.Properties.Resources.Close_Black;
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
