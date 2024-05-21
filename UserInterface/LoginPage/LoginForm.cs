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
        private BooleanMsg message;

        public LoginForm()
        {
            InitializeComponent();
            ThemeManager.CurrentThemeMode = ThemeMode.Heat;
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;

            message = DataHandler.ConnectDatabase();
            if (!message.Result) { errorMessageLabel.Text = "* Unable to Connect Database"; return; }
            message = EmployeeManager.StoreEmployeeToCollection();
            if (!message.Result) { errorMessageLabel.Text = message; }
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            letsTeamUpButton.BackColor  = pictureBox1.BackColor = label1.ForeColor = logo1.LogoColor = ThemeManager.CurrentTheme.PrimaryI;
            letsTeamUpButton.ForeColor = username.BackColor = username.TextBoxColor = password.BackColor = password.TextBoxColor = ThemeManager.CurrentTheme.SecondaryIII;
            username.ForeColor = username.TextForeColor = username.PlaceholderLabelAtCenterColor = username.PlaceholderLabelAtTopColor = ThemeManager.CurrentTheme.PrimaryI;
            password.ForeColor = password.TextForeColor = password.PlaceholderLabelAtCenterColor = password.PlaceholderLabelAtTopColor = ThemeManager.CurrentTheme.PrimaryI;

            closePictureBox.Image?.Dispose();

            closePictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Dark : UserInterface.Properties.Resources.Heat_Close_Dark;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void OnTeamUpClick(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
            message = EmployeeManager.LogInEmployee(username.TextBoxtext, password.TextBoxtext);

            if (!message.Result) { errorMessageLabel.Text = message; }

            if (message == true)
            {
                username.TextBoxtext = "";
                password.TextBoxtext = "";
                username.Focus();
                Hide();
                SelectPageBasedOnRole();
            }
        }

        private void SelectPageBasedOnRole()
        {
            ProjectManagerMainForm managerForm = new ProjectManagerMainForm();
            managerForm.ManagerClose += OnManagerFormClosed;
            managerForm.SignOut += OnSignOut;
            managerForm.Show();
        }

        private void OnSignOut(object sender, EventArgs e)
        {
            (sender as ProjectManagerMainForm).Close();
            Show();
        }

        private void OnCloseEnter(object sender, EventArgs e)
        {
            if(closePictureBox.Image!=null) closePictureBox.Image.Dispose();

            closePictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Dark_Hover : UserInterface.Properties.Resources.Heat_Close_Dark_Hover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (closePictureBox.Image != null) closePictureBox.Image.Dispose();

            closePictureBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Dark : UserInterface.Properties.Resources.Heat_Close_Dark;
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnManagerFormClosed(object sender, EventArgs e)
        {
            (sender as ProjectManagerMainForm).Close();
            this.Close();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DataHandler.StoreIssueDetails();
            IssueManager.StoreIssueCollection();
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }
    }
}
