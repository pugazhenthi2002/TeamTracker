using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface.ViewPage.ListView
{
    public partial class StatusChangeWarningForm : Form
    {
        public delegate void WarningHandler(object sender, string status, bool value);
        public event WarningHandler WarningStatus;

        public string PrevStatus;

        public new void Dispose()
        {
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();   panel4.Dispose();
            noButton.Dispose(); yesButton.Dispose();
            label1.Dispose();   label2.Dispose();   tableLayoutPanel1.Dispose();
        }

        public StatusChangeWarningForm()
        {
            InitializeComponent();
        }

        private void OnYesClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, PrevStatus, true);
        }

        private void OnNoClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(this, PrevStatus, false);
        }
    }
}
