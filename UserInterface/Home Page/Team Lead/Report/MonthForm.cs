using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public new void Dispose()
        {
            label1.Dispose();   label2.Dispose();   label3.Dispose();   label4.Dispose();   label5.Dispose();   label6.Dispose();
            label7.Dispose();   label8.Dispose();   label9.Dispose();   label10.Dispose();   label11.Dispose();   label12.Dispose();
            tableLayoutPanel1.Dispose();
        }
        private void OnMonthClick(object sender, EventArgs e)
        {
            if(prevLabel != null)
            {
                prevLabel.ForeColor = Color.FromArgb(39, 55, 77);
                prevLabel.BackColor = BackColor;
            }

            prevLabel = sender as Label;
            month = tableLayoutPanel1.GetPositionFromControl(prevLabel).Row + 1;
            prevLabel.BackColor = Color.FromArgb(39, 55, 77);
            prevLabel.ForeColor = Color.FromArgb(221, 230, 237);
            MonthSelect?.Invoke(this, month);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Dispose();
            this.Close();
        }

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
