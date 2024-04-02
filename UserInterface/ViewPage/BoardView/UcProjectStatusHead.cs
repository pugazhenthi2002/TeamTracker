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
    public partial class UcProjectStatusHead : UserControl
    {
        public UcProjectStatusHead()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }
        

        public ProjectStatus Status
        {
            get { return status; }
            set
            {
                status = value;
                ColorChange();
            }
        }

        private ProjectStatus status;
        private Color TopPanelColor;
        private string StatusLabelText;


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
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));

        }
        private void OnLoad(object sender, EventArgs e)
        {
            ColorChange();
            InitializeRoundedEdge();
        }

        private void OnMouseEnterArrow(object sender, EventArgs e)
        {
            PictureBox curPicBox = (sender as PictureBox);
            if (curPicBox == pictureBoxUp)
            {
                curPicBox.Image = UserInterface.Properties.Resources.sort_up_hover;
            }
            else
            {
                curPicBox.Image = UserInterface.Properties.Resources.sort_down_hover;
            }
        }

        private void OnMouseLeaveArrow(object sender, EventArgs e)
        {
            PictureBox curPicBox = (sender as PictureBox);
            if (curPicBox == pictureBoxUp)
            {
                curPicBox.Image = UserInterface.Properties.Resources.sort_up;
            }
            else
            {
                curPicBox.Image = UserInterface.Properties.Resources.sort_down;
            }
        }

        private void ColorChange()
        {
            switch (status)
            {
                case ProjectStatus.Completed:
                    TopPanelColor = Color.Green;
                    StatusLabelText = ProjectStatus.Completed + "";
                    break;
                case ProjectStatus.Deployment:
                    TopPanelColor = Color.Blue;
                    StatusLabelText = ProjectStatus.Deployment + "";
                    break;
                case ProjectStatus.OnProcess:
                    TopPanelColor = Color.Yellow;
                    StatusLabelText = ProjectStatus.OnProcess + "";
                    break;
                case ProjectStatus.OnStage:
                    TopPanelColor = Color.Magenta;
                    StatusLabelText = ProjectStatus.OnStage + "";
                    break;
                case ProjectStatus.UpComing:
                    TopPanelColor = Color.Gray;
                    StatusLabelText = ProjectStatus.UpComing + "";
                    break;

            }

            panel1.BackColor = TopPanelColor;
            labelStatus.Text = StatusLabelText;
        }

        
    }
}
