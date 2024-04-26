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
        }

        public EventHandler EditClick;
        public EventHandler ViewSolutionClick;

        private void OnClickEdit(object sender, EventArgs e)
        {
            EditClick?.Invoke(sender, e);
        }

        private void OnClickViewSolution(object sender, EventArgs e)
        {
            ViewSolutionClick?.Invoke(sender, e);
        }
    }
}
