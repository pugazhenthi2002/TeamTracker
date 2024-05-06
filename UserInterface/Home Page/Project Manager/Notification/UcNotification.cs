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
                textBoxContent.Text = value.NotificationContent;
                labelDateTime.Text = value.NotificationDateTime.ToShortDateString();
            }
        }

        public UcNotification()
        {
            InitializeComponent();
        }

        public new void Dispose()
        {
            labelDateTime.Dispose();
            labelHeader.Dispose();
            panelContent.Dispose();
            tableLayoutPanel1.Dispose();
            tableLayoutPanel2.Dispose();
            if (pictureBoxClose.Image != null)
                pictureBoxClose.Image.Dispose(); 
            pictureBoxClose.Dispose();
            textBoxContent.Dispose();
        }


       

        private void InitializeRoundedEdge()
        {
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
 
        }
        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_30;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_Dark_Blue;
        }

        private void OnClickClose(object sender, EventArgs e)
        {
            CloseClick?.Invoke(sender, NotficationData);
        }

        private void OnPanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(187, 208, 211), 2);
            e.Graphics.DrawRectangle(border, new Rectangle(0, 0, (sender as Panel).Width - 3, (sender as Panel).Height - 3));
            border.Dispose();
        }

        private void OnEdgePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawLine(border, new Point(0, (sender as Control).Height), new Point((sender as Control).Width, (sender as Control).Height));
            border.Dispose();
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

        private Notification notify;
    }
}
