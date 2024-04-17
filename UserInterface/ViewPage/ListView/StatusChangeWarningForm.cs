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
        public delegate void WarningHandler(string status, bool value);
        public event WarningHandler WarningStatus;

        public string PrevStatus;
        public StatusChangeWarningForm()
        {
            InitializeComponent();
        }

        private void OnYesClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(PrevStatus, true);
            this.Close();
        }

        private void OnNoClicked(object sender, EventArgs e)
        {
            WarningStatus?.Invoke(PrevStatus, false);
            this.Close();
        }
    }
}
