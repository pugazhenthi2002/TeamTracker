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
        public event EventHandler<Priority> PrioritySelect;
        private const int CSDropShadow = 0x00020000;

        public PriorityDropDownForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

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

        
        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void OnClickPriorityBtn(object sender, MouseEventArgs e)
        {
            Priority priority;
            string text = (sender as Button).Text;

            if (text == "Easy") priority = Priority.Easy;
            else if (text == "Medium") priority = Priority.Medium;
            else if (text == "Hard") priority = Priority.Hard;
            else priority = Priority.Critical;

            PrioritySelect?.Invoke(sender, priority);
            this.Close();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            for (int i = 50; i < 200; i += 50)
            {
                e.Graphics.DrawLine(border, 3, i, Width - 3, i);
            }
            border.Dispose();
        }
    }
}
