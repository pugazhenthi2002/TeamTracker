using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class UcTaskCommitsHead : UserControl
    {
        private DateTime commitDate = DateTime.Today;
        private int commitCount = 4;

        public UcTaskCommitsHead()
        {
            InitializeComponent();
        }

        public int CommitCount
        {
            get { return commitCount; }
            set
            {
                commitCount = value;
                labelText.Text = commitCount + " commits on " + commitDate.ToString("dd/MM/yyyy");
            }
        }

        public DateTime CommitDate
        {
            get { return commitDate; }
            set
            {
                commitDate = value;
                labelText.Text = commitCount + " commits on " + commitDate.ToString("dd/MM/yyyy");
            }
        }
    }
}
