using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class PriorityDropDownForm : Form
    {
        public PriorityDropDownForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }

        public EventHandler PriorityBtnClicked;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));

        }

        private void OnClickPriorityBtn(object sender, MouseEventArgs e)
        {
            PriorityBtnClicked?.Invoke(sender, e);
        }
    }
}
