using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Project_Manager_Main_Page
{
    public partial class ThemeToggle : UserControl
    {
        public ThemeToggle()
        {
            InitializeComponent();
        }

        private void OnToggled(object sender, EventArgs e)
        {
            isToggled = !isToggled;
        }

        private bool isToggled = false;

        private void OnToggleTick(object sender, EventArgs e)
        {
            if (isToggled)
            {

            }
            else
            {

            }
        }
    }
}
