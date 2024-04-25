using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class TransparentForm : Form
    {
        public TransparentForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            TransparencyKey = Color.FromArgb(255, 100, 100, 255);
            BackColor = Color.FromArgb(1, 1, 1);
            Opacity = 0.2;
        }

        public void ShowForm(Form form)
        {
            form.ShowDialog();
        }
    }
}
