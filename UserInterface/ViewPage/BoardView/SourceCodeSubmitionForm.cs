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
    public partial class SourceCodeSubmitionForm : Form
    {
        public SourceCodeSubmitionForm()
        {
            InitializeComponent();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close;
        }

        private void OnMouseEnterUpload(object sender, EventArgs e)
        {
            pictureBoxUpload.Image = UserInterface.Properties.Resources.CloudHover;
            //labelClickUpload.Font = new Font()
        }

        private void OnMouseLeaveUpload(object sender, EventArgs e)
        {
            pictureBoxUpload.Image = UserInterface.Properties.Resources.CloudBlack;

        }

        private void OnMouseClickUpload(object sender, MouseEventArgs e)
        {

        }
    }
}
