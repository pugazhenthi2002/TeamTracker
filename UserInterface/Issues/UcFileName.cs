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
    public partial class UcFileName : UserControl
    {
        private string fileName = "filename.txt";

        public UcFileName()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
                SetFileName();
            }
        }

        private void SetFileName()
        {
            labelFileName.Text = fileName;
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_Red;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_Black;
        }

        private void OnClickClose(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
