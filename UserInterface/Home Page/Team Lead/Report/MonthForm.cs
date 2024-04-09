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


        private int month;
        private Label prevLabel;

        public MonthForm()
        {
            InitializeComponent();
        }

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
    }
}
