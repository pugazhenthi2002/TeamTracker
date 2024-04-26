using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.ViewPage
{
    public partial class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeComponent();
        }

        public string Content
        {
            set
            {
                label2.Text = value;
            }
        }

        public event EventHandler<bool> WarningStatus;

        public new void Dispose()
        {
            label1.Dispose(); label2.Dispose();
            yesButton.Dispose(); noButton.Dispose();
            panel1.Dispose(); panel2.Dispose(); panel3.Dispose(); panel4.Dispose();
            tableLayoutPanel1.Dispose();
        }

        private void OnYesClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, true);
        }

        private void OnNoClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, false);
        }
    }
}
