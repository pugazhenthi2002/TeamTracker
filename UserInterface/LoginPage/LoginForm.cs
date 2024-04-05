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

            if (!message.Result) { errorMessageLabel.Text = "* Unable to Connect Database"; return; }

            message = EmployeeManager.StoreEmployeeToCollection();
            if (!message.Result) { errorMessageLabel.Text = message; }
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void OnTeamUpClick(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
            message = EmployeeManager.LogInEmployee(username.TextBoxtext, password.TextBoxtext);

            if (!message.Result) { errorMessageLabel.Text = message; }

            if (message == true)
            {
                SelectPageBasedOnRole();
            }
        }

        private void SelectPageBasedOnRole()
        {
            if(EmployeeManager.CurrentEmployee.EmpRoleName == "Project Manager")
            {
                ProjectManagerMainForm managerForm = new ProjectManagerMainForm();
                managerForm.ManagerClose += OnManagerFormClosed;
                managerForm.Show();
            }
            else if(EmployeeManager.CurrentEmployee.EmpRoleName == "Team Lead")
            {

            }
            else
            {
                
            }
        }

        private void OnCloseEnter(object sender, EventArgs e)
        {
            if(closePictureBox.Image!=null) closePictureBox.Image.Dispose();

            closePictureBox.Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (closePictureBox.Image != null) closePictureBox.Image.Dispose();

            closePictureBox.Image = UserInterface.Properties.Resources.Close;
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
    }
}
