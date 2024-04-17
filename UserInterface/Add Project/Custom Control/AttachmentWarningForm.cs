using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Add_Project.Custom_Control
{
    public partial class AttachmentWarningForm : Form
    {
        public event EventHandler<bool> WarningStatus;
        public AttachmentWarningForm()
        {
            InitializeComponent();
        }

        public new void Dispose()
        {
            label1.Dispose();   label2.Dispose();
            yesButton.Dispose();    noButton.Dispose();
            panel1.Dispose();  panel2.Dispose();    panel3.Dispose();   panel4.Dispose();
            tableLayoutPanel1.Dispose();
        }

        private void OnYesClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, true);
            Dispose();
            this.Close();
        }

        private void OnNoClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, false);
            Dispose();
            this.Close();
        }
    }
}
