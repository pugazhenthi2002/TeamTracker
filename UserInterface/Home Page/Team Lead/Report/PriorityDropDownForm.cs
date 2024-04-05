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
    public partial class PriorityDropDownForm : Form
    {
        public int Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
                prevLabel = tableLayoutPanel1.GetControlFromPosition(0, value) as Label;
                prevLabel.BackColor = Color.FromArgb(39, 55, 77);
            }
        }

        private int priority;
        private Label prevLabel;

        public PriorityDropDownForm()
        {
            InitializeComponent();
        }

        private void OnPriorityClick(object sender, EventArgs e)
        {
            if (prevLabel != null)
            {
                prevLabel.BackColor = BackColor;
            }
            prevLabel = sender as Label;
            priority = tableLayoutPanel1.GetPositionFromControl(prevLabel).Row;
            prevLabel.BackColor = Color.FromArgb(39, 55, 77);
        }
    }
}
