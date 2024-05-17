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
        public List<Notification> NotifyList
        {
            set
            {
                SuspendLayout();
                
                if (value != null && value.Count > 0)
                {
                    ClearNotify();
                    ucNotFound1.Visible = false;
                    nextBtn.Visible = backBtn.Visible = panelBase.Visible = clearAllButton.Visible = true;
                    notifyList = value;
                    notifyList.Reverse();
                    currentIndex = 0;
                    notifyCount = value.Count;
                    MaxUserControls = (notifyCount >= 2) ? 2 : notifyCount;
                    endIndex = MaxUserControls - 1;
                    InitializeNotifications();
                }
                else
                {
                    ucNotFound1.Visible = true;
                    nextBtn.Visible = backBtn.Visible = panelBase.Visible = clearAllButton.Visible = false;
                }
                ResumeLayout();
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
        public NotificationContent()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        public new void Dispose()
        {
            if(panelBase.Controls.Count > 0)
            {
                for(int ctr=0; ctr < panelBase.Controls.Count; ctr++)
                {
                    (panelBase.Controls[ctr] as UcNotification).Dispose();
                    panelBase.Controls.RemoveAt(ctr);
                    ctr--;
                }
            }
        }

        private void ClearNotify()
        {
            for (int ctr = 0; ctr < panelBase.Controls.Count; ctr++)
            {
                (panelBase.Controls[ctr] as UcNotification).Dispose();
                panelBase.Controls.RemoveAt(ctr);
                ctr--;
            }
        }

        private void InitializePageColor()
        {
            backBtn.BackColor = nextBtn.BackColor = label1.BackColor = clearAllButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            ucNotFound1.BackColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            clearAllButton.ForeColor = label1.ForeColor = ThemeManager.GetTextColor(backBtn.BackColor);
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
                tempNotification.SuspendLayout();
                tempNotification.NotficationData = notifyList[i];
                tempNotification.Size = new Size(panelBase.Width, panelBase.Height / 4);
                tempNotification.Dock = DockStyle.Top;
                tempNotification.Height = 200;
                tempNotification.CloseClick += OnClickCloseNotification;
                panelBase.Controls.Add(tempNotification);
                tempNotification.SendToBack();
                UcNotiList.Add(tempNotification);
                tempNotification.ResumeLayout();
            }

            IsNextEnable = (endIndex == notifyList.Count - 1) ? false : true;
            IsBackEnable = (currentIndex == 0) ? false : true;

            if (backBtn.Image != null)
            {
                backBtn.Image.Dispose();
            }

            if (nextBtn.Image != null)
            {
                nextBtn.Image.Dispose();
            }

            backBtn.Image = (IsBackEnable) ? UserInterface.Properties.Resources.Left_Light_Blue : UserInterface.Properties.Resources.Left_Medium_Blue;
            nextBtn.Image = (IsNextEnable) ? UserInterface.Properties.Resources.Right_Light_Blue : UserInterface.Properties.Resources.Right_Medium_Blue;
            ResumeLayout();
        }

        private void NotificationPagination()
        {
            for(int ctr=currentIndex, idx = 0; ctr<=endIndex; ctr++, idx++)
            {
                UcNotiList[idx].NotficationData = notifyList[ctr];
            }

            IsNextEnable = (endIndex == notifyList.Count - 1) ? false : true;
            IsBackEnable = (currentIndex == 0) ? false : true;

            if (backBtn.Image != null)
            {
                backBtn.Image.Dispose();
            }

            if (nextBtn.Image != null)
            {
                nextBtn.Image.Dispose();
            }

            backBtn.Image = (IsBackEnable) ? UserInterface.Properties.Resources.Left_Light_Blue : UserInterface.Properties.Resources.Left_Medium_Blue;
            nextBtn.Image = (IsNextEnable) ? UserInterface.Properties.Resources.Right_Light_Blue : UserInterface.Properties.Resources.Right_Medium_Blue;

            if (endIndex == 0)
            {
                nextBtn.Visible = backBtn.Visible = clearAllButton.Visible = false;
            }

            if (UcNotiList.Count == 0)
            {
                ucNotFound1.Visible = true;
                nextBtn.Visible = backBtn.Visible = panelBase.Visible = clearAllButton.Visible = false;
            }
        }

        private void ClearAllButtonClicked(object sender, EventArgs e)
        {
            panelBase.Controls.Clear();
            UcNotiList.Clear();
            DataHandler.DeleteAllNotification();
            ucNotFound1.Visible = true;
            nextBtn.Visible = backBtn.Visible = panelBase.Visible = clearAllButton.Visible = false;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Hand;
            if (picBox.Name == "backBtn")
            {
                picBox.Image = UserInterface.Properties.Resources.Left_Light_Blue_Hover;
            }
            else
            {
                picBox.Image = UserInterface.Properties.Resources.Right_Light_Blue_Hover;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Default;
            if (picBox.Name == "backBtn")
            {
                picBox.Image = IsBackEnable ? UserInterface.Properties.Resources.Left_Light_Blue : UserInterface.Properties.Resources.Left_Medium_Blue;
            }
            else
            {
                picBox.Image = IsNextEnable ? UserInterface.Properties.Resources.Right_Light_Blue : UserInterface.Properties.Resources.Right_Medium_Blue;
            }
        }

        private void OnClearAllMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            IsClearAllEntered = true;
            clearAllButton.BackColor = ThemeManager.GetHoverColor(clearAllButton.BackColor);
            clearAllButton.ForeColor = ThemeManager.GetTextColor(clearAllButton.BackColor);
            (sender as Control).Invalidate();
        }

        private void OnClearAllPaint(object sender, PaintEventArgs e)
        {
            if (IsClearAllEntered)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen border = new Pen(Color.FromArgb(39, 55, 77));
                e.Graphics.DrawRectangle(border, new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1));
                border.Dispose();
            }
        }

        private void OnClearAllMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            clearAllButton.BackColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.PrimaryI);
            clearAllButton.ForeColor = ThemeManager.GetTextColor(clearAllButton.BackColor);
            IsClearAllEntered = false;
            (sender as Control).Invalidate();
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
            var x = notifyList.Remove(e);
            NotificationPagination();
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            if (IsBackEnable)
            {
                currentIndex--;
                endIndex--;
                NotificationPagination();
            }
        }

        private void OnNextClick(object sender, EventArgs e)
        {
            if (IsNextEnable)
            {
                currentIndex++;
                endIndex++;
                NotificationPagination();
            }
        }

        private bool IsBackEnable = false, IsNextEnable = true, IsClearAllEntered = false;
        private int currentIndex = 0, endIndex, notifyCount;
        private int MaxUserControls = 4;//alter this value for required usercontrols
        private List<Notification> notifyList = new List<Notification>();
        private List<UcNotification> UcNotiList = new List<UcNotification>();
        private Color borderColor = Color.Blue;
    }
}
