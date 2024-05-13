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
    public partial class MonthForm : Form
    {
        public event EventHandler<int> MonthSelect;

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value > 0)
                {
                    month = value;
                    prevLabel = tableLayoutPanel1.GetControlFromPosition(0, value - 1) as Label;
                    prevLabel.BackColor = Color.FromArgb(39, 55, 77);
                    prevLabel.ForeColor = Color.FromArgb(221, 230, 237);
                }
            }
        }
        public MonthForm()
        {
            InitializeComponent();
            InitializePageColor();
        }

        public new void Dispose()
        {
            label1.Dispose();   label2.Dispose();   label3.Dispose();   label4.Dispose();   label5.Dispose();   label6.Dispose();
            label7.Dispose();   label8.Dispose();   label9.Dispose();   label10.Dispose();   label11.Dispose();   label12.Dispose();
            tableLayoutPanel1.Dispose();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryI;
            label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = label6.ForeColor = ThemeManager.GetTextColor(BackColor);
            label7.ForeColor = label8.ForeColor = label9.ForeColor = label10.ForeColor = label11.ForeColor = label12.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        private void OnMonthClick(object sender, EventArgs e)
        {
            if(prevLabel != null)
            {
                prevLabel.BackColor = BackColor;
                prevLabel.ForeColor = ThemeManager.GetTextColor(BackColor);
            }

            prevLabel = sender as Label;
            month = tableLayoutPanel1.GetPositionFromControl(prevLabel).Row + 1;
            prevLabel.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            prevLabel.ForeColor = ThemeManager.GetTextColor(prevLabel.BackColor);
            MonthSelect?.Invoke(this, month);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Dispose();
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
        private int month;
        private Label prevLabel;
    }
}
