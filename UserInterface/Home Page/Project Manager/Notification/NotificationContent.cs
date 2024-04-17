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

        private bool backEnable = false, nextEnable = true;
        private int currentIndex = 0, endIndex, notifyCount;
        private int MaxUserControls = 4;//alter this value for required usercontrols
        private List<Notification> notifyList = new List<Notification>();
        private List<UcNotification> UcNotiList = new List<UcNotification>();
        private Color borderColor = Color.Blue;


        public NotificationContent()
        {
            InitializeComponent();
        }


        public List<Notification> NotifyList
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    notifyList = value;
                    notifyList.Reverse();
                    currentIndex = 0;
                    notifyCount = value.Count;
                    MaxUserControls = (notifyCount >= 4) ? 4 : notifyCount;
                    endIndex = MaxUserControls - 1;
                    InitializeNotifications();
                }
                else
                {
                    nextBtn.Visible = backBtn.Visible = panelBase.Visible = clearAllButton.Visible = false;
                }
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }


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

        private void InitializeNotifications()
        {
            for (int i = 0; i < MaxUserControls; i++)
            {
                UcNotification tempNotification = new UcNotification();
                tempNotification.NotficationData = notifyList[i];
                tempNotification.Size = new Size(panelBase.Width, panelBase.Height / 4);
                tempNotification.Dock = DockStyle.Top;
                tempNotification.Height = 100;
                tempNotification.CloseClick += OnClickCloseNotification;
                panelBase.Controls.Add(tempNotification);
                tempNotification.SendToBack();
                UcNotiList.Add(tempNotification);
            }

            nextEnable = (endIndex == notifyList.Count - 1) ? false : true;
            backEnable = (currentIndex == 0) ? false : true;

            if (backBtn.Image != null)
            {
                backBtn.Image.Dispose();
            }

            if (nextBtn.Image != null)
            {
                nextBtn.Image.Dispose();
            }

            backBtn.Image = (backEnable) ? UserInterface.Properties.Resources.Back_LightBlue : UserInterface.Properties.Resources.Back_Hover;
            nextBtn.Image = (nextEnable) ? UserInterface.Properties.Resources.Next_LightBlue : UserInterface.Properties.Resources.Next_Hover;
        }

        private void NotificationPagination()
        {
            for(int ctr=currentIndex, idx = 0; ctr<=endIndex; ctr++, idx++)
            {
                UcNotiList[idx].NotficationData = notifyList[ctr];
            }


            nextEnable = (endIndex == notifyList.Count - 1) ? false : true;
            backEnable = (currentIndex == 0) ? false : true;

            if (backBtn.Image != null)
            {
                backBtn.Image.Dispose();
            }

            if (nextBtn.Image != null)
            {
                nextBtn.Image.Dispose();
            }

            backBtn.Image = (backEnable)?UserInterface.Properties.Resources.Back_LightBlue: UserInterface.Properties.Resources.Back_Hover;
            nextBtn.Image = (nextEnable)?UserInterface.Properties.Resources.Next_LightBlue: UserInterface.Properties.Resources.Next_Hover;
        }

        private void ClearAllButtonClicked(object sender, EventArgs e)
        {
            panelBase.Controls.Clear();
            UcNotiList.Clear();
            DataHandler.DeleteAllNotification();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            (sender as Control).BackColor = Color.FromArgb(59, 75, 97);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            (sender as Control).BackColor = Color.FromArgb(39, 55, 77);
        }

        private void OnClickCloseNotification(object sender, Notification e)
        {
            if (endIndex == notifyList.Count - 1)
            {
                if (currentIndex > 0) { currentIndex--; endIndex--; }
                else if (currentIndex == 0) { endIndex--; }
            }

            DataHandler.DeleteNotification(e.NotificationId);
            if (endIndex - currentIndex < UcNotiList.Count - 1)
            {
                UcNotification tempUCNotify = UcNotiList[UcNotiList.Count - 1];
                UcNotiList.Remove(tempUCNotify);
                panelBase.Controls.Remove(tempUCNotify);
            }
            notifyList.Remove(e);

            NotificationPagination();
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            if (backEnable)
            {
                currentIndex--;
                endIndex--;
                NotificationPagination();
            }
        }

        private void OnNextClick(object sender, EventArgs e)
        {
            if (nextEnable)
            {
                currentIndex++;
                endIndex++;
                NotificationPagination();
            }
        }
    }
}
