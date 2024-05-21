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
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            label1.ForeColor = label2.ForeColor = label3.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        public EventHandler PriorityClick;

        private void OnClickBtn(object sender, EventArgs e)
        {
            PriorityClick?.Invoke(sender, e);
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

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = ThemeManager.GetHoverColor(BackColor);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = BackColor;
        }
    }
}
