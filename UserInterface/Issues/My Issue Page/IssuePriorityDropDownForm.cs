using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class IssuePriorityDropDownForm : Form
    {
        public IssuePriorityDropDownForm()
        {
            InitializeComponent();
        }

        public EventHandler PriorityClick;

        private void OnClickBtn(object sender, EventArgs e)
        {
            PriorityClick?.Invoke(sender, e);
        }
    }
}
