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
    public partial class UcTaskStatusHead : UserControl
    {
        private TaskStatus Tstatus;
        private Color TopPanelColor;
        private string StatusLabelText;

        public UcTaskStatusHead()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }

        public EventHandler ClickBack;
        public EventHandler ClickNext;

        public TaskStatus Status
        {
            get { return Tstatus; }
            set
            {
                Tstatus = value;
                ColorChange();
            }
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
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

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            labelTaskCount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelTaskCount.Width, labelTaskCount.Height, labelTaskCount.Width, labelTaskCount.Height));

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
            switch (Tstatus)
            {
                case TaskStatus.Done:
                    TopPanelColor = Color.FromArgb(0, 180, 216);
                    StatusLabelText = TaskStatus.Done + "";
                    break;
                case TaskStatus.UnderReview:
                    TopPanelColor = Color.FromArgb(0, 150, 199);
                    StatusLabelText = TaskStatus.UnderReview + "";
                    break;
                case TaskStatus.OnProcess:
                    TopPanelColor = Color.FromArgb(2, 62, 138);
                    StatusLabelText = TaskStatus.OnProcess + "";
                    break;
                case TaskStatus.Stuck:
                    TopPanelColor = Color.FromArgb(0, 119, 182);
                    StatusLabelText = TaskStatus.Stuck + "";
                    break;
                case TaskStatus.NotYetStarted:
                    TopPanelColor = Color.FromArgb(3, 4, 94);
                    StatusLabelText = TaskStatus.NotYetStarted + "";
                    break;
            }

            panel1.BackColor = TopPanelColor;
            labelStatus.Text = StatusLabelText;
        }

        private void OnClickBack(object sender, EventArgs e)
        {
            ClickBack?.Invoke(sender,e);
        }

        private void OnClickNext(object sender, EventArgs e)
        {
            ClickNext?.Invoke(sender, e);
        }
    }
}
