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
    public partial class IssueTypeDropDownForm : Form
    {
        public IssueTypeDropDownForm()
        {
            InitializeComponent();
        }

        public EventHandler TypeClick;

        private void OnClickBtn(object sender, EventArgs e)
        {
            TypeClick?.Invoke(sender, e);
            Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Focus();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Close();
        }
    }
}
