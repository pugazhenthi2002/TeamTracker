using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Home_Page.Team_Lead.Report
{
    public partial class PriorityDropDownForm : Form
    {
        public event EventHandler<int> PrioritySelect;

        public int Priority
        {
            get
            {
                return priority;
            }
            set
            {
                if (value != -1)
                {
                    prevPriority = priority = value;
                    prevLabel = tableLayoutPanel1.GetControlFromPosition(0, value) as Label;
                    prevLabel.BackColor = Color.FromArgb(39, 55, 77);
                    prevLabel.ForeColor = Color.FromArgb(221, 230, 237);
                }
            }
        }

        public PriorityDropDownForm()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryI;
            label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        private void OnPriorityClick(object sender, EventArgs e)
        {
            
            if (prevLabel != null)
            {
                prevLabel.BackColor = BackColor;
                prevLabel.ForeColor = ThemeManager.GetTextColor(BackColor);
            }
            prevLabel = sender as Label;
            priority = tableLayoutPanel1.GetPositionFromControl(prevLabel).Row;
            prevLabel.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            prevLabel.ForeColor = ThemeManager.GetTextColor(prevLabel.BackColor);

            if (prevPriority == priority)
            {
                priority = -1;
                prevLabel.BackColor = BackColor;
                prevLabel.ForeColor = ThemeManager.GetTextColor(BackColor);
            }
            prevPriority = priority;
            PrioritySelect?.Invoke(this, priority);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

        private const int CSDropShadow = 0x00020000;
        private int priority, prevPriority;
        private Label prevLabel;
    }
}
