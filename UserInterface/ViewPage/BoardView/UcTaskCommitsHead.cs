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
        private DateTime commitDate;
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
                SetCommitCount();
            }
        }

        public DateTime CommitDate
        {
            get { return commitDate; }
            set
            {
                commitDate = value;
                SetCommitDate();
            }
        }

        private void SetCommitCount()
        {
            labelCommitCount.Text = commitCount+"";
        }

        private void SetCommitDate()
        {
            labelCommitDate.Text = commitDate.ToString("dd/MM/yyyy");
        }
    }
}
