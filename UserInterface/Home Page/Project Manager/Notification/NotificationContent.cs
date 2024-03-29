using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class NotificationContent : UserControl
    {
        public NotificationContent()
        {
            InitializeComponent();
        }

        public List<Notification> NotifyList
        {
            set
            {
                if (value != null)
                {
                    notifyList = value;
                    InitializeNotifications(0);
                }
            }

        }

        private int currentIndex = 0;
        private int MaxUserControls = 4;//alter this value for required usercontrols
        private int flag = 0;
        private int ind = 0;
        private List<Notification> notifyList = new List<Notification>();
        private List<UcNotification> UcNotiList = new List<UcNotification>();

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        private Color borderColor = Color.Blue;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Point pt1 = new Point(9, 9);
            Point pt2 = new Point(Width - 11, 9);
            Point pt3 = new Point(Width - 11, Height - 11);
            Point pt4 = new Point(9, Height - 11);
            Pen border = new Pen(borderColor, 3);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private int InitializeNotifications(int nav)
        {
            if (nav > 0)
            {
                currentIndex++;
            }
            else if (nav < 0)
            {
                currentIndex--;
            }

            //initial usercontrols
            if (flag == 0)
            {
                for (int i = currentIndex; i < Math.Min(currentIndex + MaxUserControls, notifyList.Count); i++)
                {
                    flag = 1;
                    UcNotification tempNotification = new UcNotification();
                    tempNotification.NotficationData = notifyList[i];
                    tempNotification.Size = new Size(panelBase.Width, panelBase.Height / 4);

                    tempNotification.Dock = DockStyle.Top;
                    tempNotification.CloseClick += OnClickCloseNotification;

                    panelBase.Controls.Add(tempNotification);
                    UcNotiList.Add(tempNotification);
                }
            }
            //updating the usercontrols
            else
            {
                if (notifyList.Count < MaxUserControls)
                {
                    panelBase.Controls.Remove(UcNotiList[UcNotiList.Count - 1]);
                    UcNotiList.RemoveAt(UcNotiList.Count - 1);
                }

                for (int i = currentIndex; i < Math.Min(currentIndex + MaxUserControls, notifyList.Count); i++)
                {
                    UcNotiList[ind++].NotficationData = notifyList[i];
                }
                ind = 0;
            }



            if (currentIndex <= 0)//if it reaches the first page
            {
                return 1;
            }
            else if (currentIndex + MaxUserControls >= notifyList.Count)//if it reaches the last page
            {
                return -1;
            }

            return 0;

        }

        private void OnClickCloseNotification(object sender, Notification e)
        {
            //DataHandler.DeleteNotification(e.NotificationId);
            notifyList.Remove(e);
            if (currentIndex > 0)
            {
                InitializeNotifications(-1);
            }
            else
            {
                InitializeNotifications(0);
            }
        }

        private void OnBackClick(object sender, EventArgs e)
        {

        }

        private void OnNextClick(object sender, EventArgs e)
        {

        }
    }
}
