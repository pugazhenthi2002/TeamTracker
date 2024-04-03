using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Focus();
        }

        private void rippleButton1_Click(object sender, EventArgs e)
        {
            ;
        }
        bool isDragging = false;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                ;
            }
        }
    }
}
