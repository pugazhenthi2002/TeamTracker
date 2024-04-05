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
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
                prevLabel = tableLayoutPanel1.GetControlFromPosition(0, value) as Label;
                prevLabel.BackColor = Color.FromArgb(39, 55, 77);
            }
        }

        private int month;
        private Label prevLabel;

        public MonthForm()
        {
            InitializeComponent();
        }

        private void OnMonthClick(object sender, EventArgs e)
        {
            if(prevLabel != null)
            {
                prevLabel.BackColor = BackColor;
            }
            prevLabel = sender as Label;
            month = tableLayoutPanel1.GetPositionFromControl(prevLabel).Row;
            prevLabel.BackColor = Color.FromArgb(39, 55, 77);
        }
    }
}
