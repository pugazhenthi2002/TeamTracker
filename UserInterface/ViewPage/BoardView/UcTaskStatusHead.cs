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
using System.Reflection;

namespace TeamTracker
{
    public partial class UcTaskStatusHead : UserControl
    {
        private TaskStatus Tstatus = TaskStatus.Done;
        private Color TopPanelColor;
        private string StatusLabelText;

        public UcTaskStatusHead()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            InitializePageColor();
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, labelTaskCount, new object[] { true });
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        public EventHandler ClickBack;
        public EventHandler ClickNext;

        public TaskStatus Status
        {
            get { return Tstatus; }
            set
            {
                Tstatus = value;
                InitializePageColor();
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

        private void InitializePageColor()
        {
            labelStatus.ForeColor = labelTaskCount.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            labelTaskCount.ForeColor = ThemeManager.GetTextColor(labelTaskCount.BackColor);
            panel1.BackColor = ThemeManager.GetTaskStatusColor(Tstatus);
            labelStatus.Text = Tstatus.ToString();

            pictureBoxUp.Image?.Dispose();  pictureBoxDown.Image?.Dispose();
            pictureBoxDown.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Down_Dark : UserInterface.Properties.Resources.Heat_Down_Dark;
            pictureBoxUp.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Up_Dark : UserInterface.Properties.Resources.Heat_Up_Dark;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            labelTaskCount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelTaskCount.Width, labelTaskCount.Height, 8, 8));
        }

        private void OnLoad(object sender, EventArgs e)
        {
            InitializeRoundedEdge();
        }

        private void OnMouseEnterArrow(object sender, EventArgs e)
        {
            PictureBox curPicBox = (sender as PictureBox);
            if (curPicBox == pictureBoxUp)
            {
                pictureBoxUp.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Up_Dark_Hover : UserInterface.Properties.Resources.Heat_Up_Dark_Hover;
            }
            else
            {
                pictureBoxDown.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Down_Dark_Hover : UserInterface.Properties.Resources.Heat_Down_Dark_Hover;
            }
        }

        private void OnMouseLeaveArrow(object sender, EventArgs e)
        {
            PictureBox curPicBox = (sender as PictureBox);
            if (curPicBox == pictureBoxUp)
            {
                pictureBoxUp.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Up_Dark : UserInterface.Properties.Resources.Heat_Up_Dark;
            }
            else
            {
                pictureBoxDown.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Down_Dark : UserInterface.Properties.Resources.Heat_Down_Dark;
            }
        }

        private void OnClickBack(object sender, EventArgs e)
        {
            ClickBack?.Invoke(sender,e);
        }

        private void OnClickNext(object sender, EventArgs e)
        {
            ClickNext?.Invoke(sender, e);
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.SecondaryIII, 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, Width - 1, Height - 1), 10));
            border.Dispose();
        }

        private void OnCountLabelBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1), 4));
            border.Dispose();
        }
    }
}
