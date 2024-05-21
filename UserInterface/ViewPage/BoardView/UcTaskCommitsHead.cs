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
        public Image CommitImage
        {
            set
            {
                if(value != null)
                {
                    pictureBox1.Image?.Dispose();
                    pictureBox1.Image = value;
                }
            }
        }
        private DateTime commitDate = DateTime.Today;
        private int commitCount = 4;

        public UcTaskCommitsHead()
        {
            InitializeComponent();
            labelText.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            pictureBox1.Image?.Dispose();
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
