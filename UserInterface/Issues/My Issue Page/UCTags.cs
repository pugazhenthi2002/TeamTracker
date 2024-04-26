using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TeamTracker
{
    public partial class UCTags : UserControl
    {
        public UCTags()
        {
            InitializeComponent();

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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializeRoundedEdge();

        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            //ClosePicBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ClosePicBox.Width, ClosePicBox.Height, 20, 20));

        }


        public void SetText(string text)
        {
            LabelTag.Text = text;
        }

        private void OnClickCloseTag(object sender, EventArgs e)
        {

            this.Dispose();
        }


        private void OnMouseEnter(object sender, EventArgs e)
        {
            if(ClosePicBox.Image!=null)
            {
                ClosePicBox.Image.Dispose();
            }
            //ClosePicBox.Image = Properties.Resources.close_red;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (ClosePicBox.Image != null)
            {
                ClosePicBox.Image.Dispose();
            }

            //ClosePicBox.Image = Properties.Resources.Close;
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_Red;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_Black;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }
    }
}
