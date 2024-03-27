using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Home_Page.Project_Manager.Deploy
{
    public partial class ProfilePicAndNameSquare : UserControl
    {
        public ProfilePicAndNameSquare()
        {
            InitializeComponent();
        }

        public void SetImage(Image image)
        {
            profilePictureBox1.Image = image;
        }
    }
}
