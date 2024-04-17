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
        

        public event EventHandler AttachmentRemove;

        public PDFAttachment()
        {
            InitializeComponent();
        }


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

        public new void Dispose()
        {
            pictureBox1.Image.Dispose();
            closePicBox.Image.Dispose();
            closePicBox.Dispose();
            pictureBox1.Dispose();
            label1.Dispose();
            tableLayoutPanel1.Dispose();
            panel1.Dispose();
        }

        private void OnCloseCLick(object sender, EventArgs e)
        {
            AttachmentRemove?.Invoke(this, e);
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            if (closePicBox.Image != null)
                closePicBox.Image.Dispose();

            closePicBox.Image = UserInterface.Properties.Resources.Close_Alice_Blue_30;
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            if (closePicBox.Image != null)
                closePicBox.Image.Dispose();

            closePicBox.Image = UserInterface.Properties.Resources.Close_30;
        }
    }
}
