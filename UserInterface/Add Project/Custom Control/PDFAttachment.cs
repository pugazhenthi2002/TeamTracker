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
    public partial class PDFAttachment : UserControl
    {
        public string FileName
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        public event EventHandler AttachmentRemove;

        public PDFAttachment()
        {
            InitializeComponent();
        }

        private void OnCloseCLick(object sender, EventArgs e)
        {
            AttachmentRemove?.Invoke(this, e);
        }
    }
}
