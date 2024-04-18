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
        private const int CSDropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

        private int priority, prevPriority;
        private Label prevLabel;

        public PriorityDropDownForm()
        {
            InitializeComponent();
        }

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

        

        private void OnPriorityClick(object sender, EventArgs e)
        {
            
            if (prevLabel != null)
            {
                prevLabel.ForeColor = Color.FromArgb(39, 55, 77);
                prevLabel.BackColor = BackColor;
            }
            prevLabel = sender as Label;
            priority = tableLayoutPanel1.GetPositionFromControl(prevLabel).Row;
            prevLabel.BackColor = Color.FromArgb(39, 55, 77);
            prevLabel.ForeColor = Color.FromArgb(221, 230, 237);

            if (prevPriority == priority)
            {
                priority = -1;
                prevLabel.ForeColor = Color.FromArgb(39, 55, 77);
                prevLabel.BackColor = BackColor;
            }
            prevPriority = priority;
            PrioritySelect?.Invoke(this, priority);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }
    }
}
