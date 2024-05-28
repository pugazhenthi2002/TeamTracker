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
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
           ThemeManager.ThemeChange -= OnThemeChanged;
            if (pictureBoxClose.Image != null)
                pictureBoxClose.Image.Dispose(); 
        }

        private void InitializePageColor()
        {
            tableLayoutPanel2.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            panelContent.BackColor = textBoxContent.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            labelHeader.ForeColor = labelDateTime.ForeColor = ThemeManager.GetTextColor(tableLayoutPanel2.BackColor);
            textBoxContent.ForeColor = ThemeManager.GetTextColor(textBoxContent.BackColor);

            pictureBoxClose.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Dark :UserInterface.Properties.Resources.Heat_Close_Dark;
        }
       
        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            pictureBoxClose.Image?.Dispose();
            pictureBoxClose.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Dark_Hover : UserInterface.Properties.Resources.Heat_Close_Dark_Hover;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pictureBoxClose.Image?.Dispose();
            pictureBoxClose.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Dark : UserInterface.Properties.Resources.Heat_Close_Dark;
        }

        private void OnClickClose(object sender, EventArgs e)
        {
            CloseClick?.Invoke(sender, NotficationData);
        }

        private void OnPanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.DrawRectangle(border, new Rectangle(0, 0, (sender as Panel).Width - 3, (sender as Panel).Height - 3));
            border.Dispose();
        }

        private void OnEdgePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(0, (sender as Control).Height - 1), new Point((sender as Control).Width, (sender as Control).Height - 1));
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
