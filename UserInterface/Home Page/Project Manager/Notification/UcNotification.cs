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
    public partial class UcNotification : UserControl
    {
        public UcNotification()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        public EventHandler<Notification> CloseClick;

        public Notification NotficationData
        {
            get
            {
                return notify;
            }

            set
            {
                notify = value;
                labelHeader.Text = value.NotificationHeader;
                labelContent.Text = value.NotificationContent;
                labelDateTime.Text = value.NotificationDateTime.ToShortDateString();
            }
        }

        private Notification notify;

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
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
 
        }
        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_Red;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_Black;
        }

        private void OnResizeUserControl(object sender, EventArgs e)
        {
            InitializeRoundedEdge();
        }

        private void OnClickClose(object sender, EventArgs e)
        {
            CloseClick?.Invoke(sender, NotficationData);
        }
    }
}
