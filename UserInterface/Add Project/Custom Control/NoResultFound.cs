using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class NoResultFound : UserControl
    {

        public NoResultFound()
        {
            InitializeComponent();
        }


        public string MessageText
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
    }
}
