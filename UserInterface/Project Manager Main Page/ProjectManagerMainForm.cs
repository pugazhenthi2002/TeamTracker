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
using UserInterface.Project_Manager_Main_Page;

namespace TeamTracker
{
    public partial class ProjectManagerMainForm : Form
    {
        static public NotificationManager notify;
        public event EventHandler ManagerClose;

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
            profilePicAndName1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profilePicAndName1.Width, profilePicAndName1.Height, profilePicAndName1.Height, profilePicAndName1.Height));
        }

        public ProjectManagerMainForm()
        {
            InitializeComponent();
            notify = new NotificationManager();
            notify.BorderRadius = 20;
            notify.NotificationScreenTime = 10;
            notify.NotificationAlignment = FromNotificationAlignment.RightDown;
            profilePicAndName1.EmployeeProfile = EmployeeManager.CurrentEmployee;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            projectManagerHome1.InitializeHome();
        }

        private void OnHeaderPanelPaint(object sender, PaintEventArgs e)
        {
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawLine(border, new Point(0, headerPanel.Height), new Point(headerPanel.Width, headerPanel.Height));
            border.Dispose();
        }

        private void OnNavMouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox picBox)
            {
                if (picBox.Image != null) { picBox.Image.Dispose(); }

                if (picBox.Name == "homePictureBox")
                {
                    homeLabel.ForeColor = Color.FromArgb(221, 230, 237);
                    picBox.Image = UserInterface.Properties.Resources.Home_Hover;
                }
                else if (picBox.Name == "addProjectPictureBox")
                {
                    addProjectLabel.ForeColor = Color.FromArgb(221, 230, 237);
                    picBox.Image = UserInterface.Properties.Resources.Add_Project_Hover;
                }
                else
                {
                    viewProjectLabel.ForeColor = Color.FromArgb(221, 230, 237);
                    picBox.Image = UserInterface.Properties.Resources.View_Project_Hover;
                }
            }
            else
            {
                Label label = (Label)sender;
                label.ForeColor = Color.FromArgb(221, 230, 237);

                if (label.Name == "homeLabel")
                {
                    if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
                    homePictureBox.Image = UserInterface.Properties.Resources.Home_Hover;
                }
                else if (label.Name == "addProjectLabel")
                {
                    if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
                    addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project_Hover;
                }
                else
                {
                    if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
                    viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project_Hover;
                }
            }
        }

        private void OnNavMouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox picBox)
            {
                if (picBox.Image != null) { picBox.Image.Dispose(); }

                if (picBox.Name == "homePictureBox")
                {
                    homeLabel.ForeColor = Color.FromArgb(157, 178, 191);
                    picBox.Image = UserInterface.Properties.Resources.Home_Normal;
                }
                else if (picBox.Name == "addProjectPictureBox")
                {
                    addProjectLabel.ForeColor = Color.FromArgb(157, 178, 191);
                    picBox.Image = UserInterface.Properties.Resources.Add_Project;
                }
                else
                {
                    viewProjectLabel.ForeColor = Color.FromArgb(157, 178, 191);
                    picBox.Image = UserInterface.Properties.Resources.View_Project;
                }
            }
            else
            {
                Label label = (Label)sender;
                label.ForeColor = Color.FromArgb(157, 178, 191);

                if (label.Name == "homeLabel")
                {
                    if (homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
                    homePictureBox.Image = UserInterface.Properties.Resources.Home_Normal;
                }
                else if (label.Name == "addProjectLabel")
                {
                    if (addProjectPictureBox.Image != null) { addProjectPictureBox.Image.Dispose(); }
                    addProjectPictureBox.Image = UserInterface.Properties.Resources.Add_Project;
                }
                else
                {
                    if (viewProjectPictureBox.Image != null) { viewProjectPictureBox.Image.Dispose(); }
                    viewProjectPictureBox.Image = UserInterface.Properties.Resources.View_Project;
                }
            }
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            if (closePicBox.Image != null) {  closePicBox.Image.Dispose(); }
            closePicBox.Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            if (closePicBox.Image != null) { closePicBox.Image.Dispose(); }
            closePicBox.Image = UserInterface.Properties.Resources.Close;
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            ManagerClose?.Invoke(this, e);
        }

        private void OnHomeClicked(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            projectManagerHome1.InitializeHome();
        }

        private void OnAddProjectClicked(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void OnViewProjectClicked(object sender, EventArgs e)
        {
            viewProjectTemplate1.InitializeViewProject();
            tabControl1.SelectedIndex = 2;
        }

        private void OnSignOut(object sender, EventArgs e)
        {
            SignOutForm form = new SignOutForm();
            form.Width = profilePicAndName1.Width;
            form.Location = profilePicAndName1.PointToScreen(new Point(0, profilePicAndName1.Height + 1));
            form.SignOut += OnFormSignOut;
            form.Show();
        }

        private void OnFormSignOut(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
