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


        private void OnCloseCLick(object sender, EventArgs e)
        {
            AttachmentRemove?.Invoke(this, e);
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            if (closePicBox.Image != null)
                closePicBox.Image.Dispose();

            closePicBox.Image = UserInterface.Properties.Resources.Close;
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            if (closePicBox.Image != null)
                closePicBox.Image.Dispose();

            closePicBox.Image = UserInterface.Properties.Resources.close_Hover;
        }
    }
}
