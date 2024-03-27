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
    public partial class UcNotificationBase : UserControl
    {
        public UcNotificationBase()
        {
            InitializeComponent();
        }

        public List<Notify> NotifyList
        {
            get
            {
                return notifyList;
            }
            set
            {
                if (value != null)
                {
                    notifyList = value;
                    InitializeNotifications(0);
                }
            }

        }

        private List<Notify> notifyList = new List<Notify>();
        private List<UcNotification> UcNotiList = new List<UcNotification>();


        private int currentIndex = 0;
        private int MaxUserControls = 4;//alter this value for required usercontrols
        private int flag = 0;
        private int ind = 0;

        private int InitializeNotifications(int nav)
        {
            if (nav > 0)
            {
                currentIndex++;
            }
            else if(nav < 0)
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
                if(notifyList.Count < MaxUserControls)
                {
                    panelBase.Controls.Remove(UcNotiList[UcNotiList.Count - 1]);
                    UcNotiList.RemoveAt(UcNotiList.Count-1);
                }

                for (int i = currentIndex; i < Math.Min(currentIndex + MaxUserControls, notifyList.Count); i++)
                {
                    UcNotiList[ind++].NotficationData = notifyList[i];
                }
                ind = 0;
            }

  

            if(currentIndex <= 0)//if it reaches the first page
            {
                return 1;
            }
            else if(currentIndex + MaxUserControls >= notifyList.Count)//if it reaches the last page
            {
                return -1;
            }

            return 0;

        }

        private void OnClickCloseNotification(object sender, Notify e)
        {
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

        
    }
}
