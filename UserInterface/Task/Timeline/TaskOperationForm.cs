using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Task.Timeline
{
    public enum OperateType
    {
        View,
        Update,
        Delete
    }

    public partial class TaskOperationForm : Form
    {
        public event EventHandler<OperateType> Operate;
        public TaskOperationForm()
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
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label1.BackColor = label2.BackColor = label3.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            label1.ForeColor = label2.ForeColor = label3.ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.SecondaryI);
        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            Operate?.Invoke(this, OperateType.Update);
            this.Close();
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            Operate?.Invoke(this, OperateType.Delete);
            this.Close();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }

        private void OnViewClick(object sender, EventArgs e)
        {
            Operate?.Invoke(this, OperateType.View);
            this.Close();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Label).BackColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryI);
            (sender as Label).ForeColor = ThemeManager.GetTextColor((sender as Label).BackColor);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Label).BackColor = ThemeManager.CurrentTheme.SecondaryI;
            (sender as Label).ForeColor = ThemeManager.GetTextColor(ThemeManager.CurrentTheme.SecondaryI);
        }
    }
}
