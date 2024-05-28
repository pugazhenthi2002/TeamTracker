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
using TeamTracker;

namespace UserInterface
{
    public partial class UcNotFound : UserControl
    {

        private string headText = "No Result Found!!!";
        private string message;
        private int headTextSize = 10;

        public UcNotFound()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        public void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            labelHead.ForeColor = labelMessage.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Empty : Properties.Resources.Heat_Empty;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            pictureBox1.Image?.Dispose();
        }

        public string HeadText
        {
            get
            {
                return headText;
            }
            set
            {
                headText = value;
                SetHeadText();
            }

        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                SetMessageText();
            }
        }
        public int HeadTextSize
        {
            get
            {
                return headTextSize;
            }
            set
            {
                headTextSize = value;
                SetTextSize();
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
        }

        private void SetTextSize()
        {
            labelHead.Font = new Font(labelHead.Font.FontFamily, headTextSize,FontStyle.Bold);
        }

        private void SetHeadText()
        {
            labelHead.Text = headText;
        }
        private void SetMessageText()
        {
            labelMessage.Text = message;
        }
    }
}
