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
    public partial class ProjectInfoForm : Form
    {
        public ProjectInfoForm()
        {
            InitializeComponent();
            InitializeBorder();
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

        private void InitializeBorder()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            tableLayoutPanel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel5.Width, tableLayoutPanel5.Height, 20, 20));
            panelSourceCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelSourceCode.Width, panelSourceCode.Height, 20, 20));
            panelAttachment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelAttachment.Width, panelAttachment.Height, 20, 20));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorder();
        }

        private void OnMouseClickClose(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close;

        }

        private void OnMouseEnterDownloadPicBox(object sender, EventArgs e)
        {
            if(sender is Label)
            {
                if((sender as Label).Name == "labelAttachment")
                {
                    pictureBoxAttachment.SizeMode = PictureBoxSizeMode.Zoom;
                    
                }
                else
                {
                    pictureBoxSoureCode.SizeMode = PictureBoxSizeMode.Zoom;
                }
                (sender as Label).Font = new Font((sender as Label).Font.FontFamily, 10, FontStyle.Bold);
                return;
            }
            else
            {

                if ((sender as PictureBox).Name == "pictureBoxSoureCode")
                {
                    labelSourceCode.Font = new Font(labelSourceCode.Font.FontFamily, 10, FontStyle.Bold);
                }
                else
                {
                    labelAttachment.Font = new Font(labelAttachment.Font.FontFamily, 10, FontStyle.Bold);
                }


                (sender as PictureBox).SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void OnMouseLeaveDownloadPicBox(object sender, EventArgs e)
        {

            if (sender is Label)
            {
                if ((sender as Label).Name == "labelAttachment")
                {
                    pictureBoxAttachment.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    pictureBoxSoureCode.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                (sender as Label).Font = new Font((sender as Label).Font.FontFamily, 9, FontStyle.Bold);
                return;
            }
            else
            {
                
                if((sender as PictureBox).Name == "pictureBoxSoureCode")
                {
                    labelSourceCode.Font = new Font(labelSourceCode.Font.FontFamily, 9, FontStyle.Bold);
                }
                else
                {
                    labelAttachment.Font = new Font(labelAttachment.Font.FontFamily, 9, FontStyle.Bold);
                }


                (sender as PictureBox).SizeMode = PictureBoxSizeMode.CenterImage;
            }

        }

        private void OnClickDownloadPicBox(object sender, MouseEventArgs e)
        {

        }
    }
}
