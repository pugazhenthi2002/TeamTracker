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
    public partial class ProjectManagerMainForm : Form
    {
        static public NotificationManager notify;

        public ProjectManagerMainForm()
        {
            InitializeComponent();
        }

        private void OnHeaderPanelPaint(object sender, PaintEventArgs e)
        {
            //Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            //e.Graphics.DrawLine(border, new Point(0, headerPanel.Height - 2), new Point(headerPanel.Width, headerPanel.Height - 2));
            //border.Dispose();
        }

        private void OnNavMouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox picBox = (PictureBox)sender;

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
                    if(homePictureBox.Image != null) { homePictureBox.Image.Dispose(); }
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
            if (sender is PictureBox)
            {
                PictureBox picBox = (PictureBox)sender;

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
            this.Close();
        }

        private void OnHomeClicked(object sender, EventArgs e)
        {

        }

        private void OnAddProjectClicked(object sender, EventArgs e)
        {

        }

        private void OnViewProjectClicked(object sender, EventArgs e)
        {

        }
    }
}
