using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Home_Page.Project_Manager.Deploy
{
    public partial class UcZipFileView : UserControl
    {
        public UcZipFileView()
        {
            InitializeComponent();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            labelDownloadZip.Font = new Font(labelDownloadZip.Font, FontStyle.Bold);
            pictureBoxZip.Image = Properties.Resources.Zip_red;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            labelDownloadZip.Font = new Font(labelDownloadZip.Font, FontStyle.Regular);
            pictureBoxZip.Image = Properties.Resources.Zip_Black;
        }
    }
}
