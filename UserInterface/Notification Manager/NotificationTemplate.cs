using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class NotificationTemplate : Form
    {
        static public bool isFullContentDisplayed = false;
        public bool isContentOutOfHeight = false;
        public int TickCount = 0;
        private int borderRadius;
        private string header = "Header";
        private string message = "Message";
        private string contentMessage = "Message";
        private string time = "Time";
        private List<string> words = new List<string>();
        private Timer fadeOutTimer = new Timer();
        private Font headerFont, contentFont;
        private Pen linePen;
        private Brush textBrush;
        private Rectangle stringRectangle;
        private StringFormat SFormat;



        public NotificationTemplate()
        {
            DoubleBuffered = true;
            InitializeComponent();
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;

            pictureBox1.Image?.Dispose();

            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light : UserInterface.Properties.Resources.Heat_Close_Light;
        }

        public event EventHandler NotificationClosed;

        public string NotificationHeader
        {
            get
            {
                return header;
            }

            set
            {
                header = value;
                headerPanel.Invalidate();
            }
        }
        public string ContentMessage
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
                SplitContentToWords(message);
                contentPanel.Invalidate();
            }
        }

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                borderRadius = value;
                InitializeBorder();
            }
        }
        public DateTime NotificationTime
        {
            set
            {
                time = value.ToShortTimeString();
            }
        }
        

        public Size SetNotificationSize()
        {
            contentFont = new Font(new FontFamily("Microsoft PhagsPa"), 12);
            contentMessage = GenerateContent(contentPanel.CreateGraphics());
            var contentSize = contentPanel.CreateGraphics().MeasureString(contentMessage, contentFont);
            Size notificationSize;
            if (Width < contentSize.Width)
            {
                notificationSize = new Size(Width, (int)(contentSize.Height + 20 + timePanel.Height + headerPanel.Height + contentSize.Width*43/Width));
            }
            else
            {
                notificationSize = new Size(Width, (int)contentSize.Height + 20 + timePanel.Height + headerPanel.Height);
            }

            if (notificationSize.Height > Screen.PrimaryScreen.Bounds.Height)
            {
                isContentOutOfHeight = true;
                seeMorePanel.Visible = true;
                seeMorePanel.Invalidate();
            }

            return notificationSize;
        }


        private void OnNotificationClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationTemplate_FormClosed(object sender, FormClosedEventArgs e)
        {
            NotificationClosed?.Invoke(this, e);
        }

        private void FrmFadeClose_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Opacity > 0.01f)
            {
                e.Cancel = true;
                fadeOutTimer.Tick += Timer1_Tick;
                fadeOutTimer.Interval = 50;
                fadeOutTimer.Start();
            }
            else
            {
                fadeOutTimer.Enabled = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.01)
                this.Opacity = this.Opacity - 0.1f;
            else
                this.Close();
        }

        private void OnHeaderPanelPaint(object sender, PaintEventArgs e)
        {
            SFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            headerFont = new Font(new FontFamily("Ebrima"), 14, FontStyle.Bold);
            textBrush = new SolidBrush(ThemeManager.CurrentTheme.SecondaryIII);
            stringRectangle = new Rectangle(0, 0, headerPanel.Width, headerPanel.Height);

            e.Graphics.DrawString(header, headerFont, textBrush, stringRectangle, SFormat);
        }

        private void OnTimePanelPaint(object sender, PaintEventArgs e)
        {
            SFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            contentFont = new Font(new FontFamily("Ebrima"), 12, FontStyle.Italic);
            textBrush = new SolidBrush(ThemeManager.CurrentTheme.PrimaryIII);
            stringRectangle = new Rectangle(0, 0, timePanel.Width, timePanel.Height);

            e.Graphics.DrawString(time, contentFont, textBrush, stringRectangle, SFormat);
        }

        private void OnContentPanelPaint(object sender, PaintEventArgs e)
        {
            SFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            };

            contentFont = new Font(new FontFamily("Microsoft PhagsPa"), 12);
            textBrush = new SolidBrush(ThemeManager.CurrentTheme.PrimaryI);
            stringRectangle = new Rectangle(0, 0, contentPanel.Width, contentPanel.Height);

            contentMessage = GenerateContent(e.Graphics);

            SizeF contentSize = e.Graphics.MeasureString(contentMessage, contentFont);

            if (contentSize.Height>= Screen.PrimaryScreen.Bounds.Height)
            {
                seeMorePanel.Visible = true;
                isContentOutOfHeight = true;
            }
            else
            {
                seeMorePanel.Visible = false;
                isContentOutOfHeight = false;
            }
            e.Graphics.DrawString(contentMessage, contentFont, textBrush, stringRectangle, SFormat);
        }

        private void SplitContentToWords(string message)
        {
            string currentWord = "";
            for (int ctr = 0; ctr < message.Length; ctr++)
            {
                if(message[ctr]==' ' && currentWord!="")
                {
                    words.Add(currentWord);
                    currentWord = "";
                }
                else
                {
                    currentWord += message[ctr];
                }
            }

            if(currentWord!="")
            {
                words.Add(currentWord);
                currentWord = "";
            }
        }

        private string GenerateContent(Graphics g)
        {
            string actualContent = "", singleLineContent="" ;
            foreach(string Iter in words)
            {
                if(g.MeasureString(Iter, contentFont).Width >= contentPanel.Width)
                {
                    if(singleLineContent != "")
                    {
                        actualContent += singleLineContent + "\n";
                    }
                    float y = g.MeasureString(Iter, contentFont).Width;
                    int x = (int)(Iter.Length / (y / contentPanel.Width));
                    actualContent += Iter.Substring(0, x) + "\n";
                    singleLineContent = Iter.Substring(x) + " ";
                }
                else if(g.MeasureString(singleLineContent + Iter + " ", contentFont).Width>=contentPanel.Width)
                {
                    actualContent += singleLineContent+"\n";
                    singleLineContent = Iter + " ";
                }
                else
                {
                    singleLineContent += Iter + " ";
                }
            }
            if (singleLineContent != "")
                actualContent += singleLineContent;

            return actualContent;
        }

        private void SeeMorePanel_Paint(object sender, PaintEventArgs e)
        {
            if(isContentOutOfHeight)
            {
                StringFormat S = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                contentFont = new Font(new FontFamily("Microsoft PhagsPa"), 10, FontStyle.Bold);
                stringRectangle = new Rectangle(0, 0, seeMorePanel.Width, seeMorePanel.Height);
                string s = GenerateContent(e.Graphics);
                e.Graphics.DrawString("See More ^", contentFont, textBrush, stringRectangle, S);
            }
        }

        private void OnSeeMorePanelHover(object sender, EventArgs e)
        {
            if(isContentOutOfHeight)
            {
                textBrush = new SolidBrush(ThemeManager.CurrentTheme.PrimaryI);
            }
        }

        private void OnSeeMorePanelEnter(object sender, EventArgs e)
        {
            if (isContentOutOfHeight)
            {
                textBrush = new SolidBrush(ThemeManager.CurrentTheme.PrimaryI);
                seeMorePanel.Invalidate();
            }
        }

        private void OnSeeMorePanelLeave(object sender, EventArgs e)
        {
            if (isContentOutOfHeight)
            {
                textBrush = new SolidBrush(ThemeManager.CurrentTheme.PrimaryIII);
                seeMorePanel.Invalidate();
            }
        }

        private void OnFullContentViewed(object sender, EventArgs e)
        {
            isFullContentDisplayed = true;
            FullContentViewForm fullContentForm = new FullContentViewForm
            {
                TitleName = header,
                Content = message,
                //fullContentForm.WordArray = words;
                StartPosition = FormStartPosition.Manual,
                Size = new Size(600, 400),
                Location = new Point((Screen.PrimaryScreen.Bounds.Width - 600) / 2, (Screen.PrimaryScreen.Bounds.Height - 400) / 2)
            };
            fullContentForm.Show();
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

        

        private void OnNotifyResize(object sender, EventArgs e)
        {
            InitializeBorder();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 3);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, Width - 2, Height - 2), borderRadius/2));
            border.Dispose();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light_Hover : UserInterface.Properties.Resources.Heat_Close_Light_Hover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light : UserInterface.Properties.Resources.Heat_Close_Light;
        }

        private void InitializeBorder()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, borderRadius, borderRadius));
        }

        
    }
}
