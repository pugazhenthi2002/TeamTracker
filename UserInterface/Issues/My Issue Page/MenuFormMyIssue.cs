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
    public partial class MenuFormMyIssue : Form
    {
        public MenuFormMyIssue()
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
            buttonEdit.ForeColor = label1.ForeColor = BackColor = ThemeManager.CurrentTheme.PrimaryI;
            buttonEdit.BackColor = label1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
        }

        public EventHandler EditClick;
        public EventHandler ViewSolutionClick;

        private void OnClickEdit(object sender, EventArgs e)
        {
            EditClick?.Invoke(sender, e);
            Close();
        }

        private void OnClickViewSolution(object sender, EventArgs e)
        {
            ViewSolutionClick?.Invoke(sender, e);
            Close();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Focus();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = ThemeManager.GetHoverColor((sender as Control).BackColor);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = ThemeManager.CurrentTheme.SecondaryIII; ;
        }
    }
}
