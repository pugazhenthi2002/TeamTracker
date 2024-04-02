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
    public partial class PageButton : UserControl
    {
        public string ButtonName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public Image ButtonImage
        {
            get { return pictureBox1.Image; }
            set
            {
                if(pictureBox1.Image!=null)
                {
                    pictureBox1.Image.Dispose();
                }

                if(value != null)
                {
                    pictureBox1.Image = value;
                }
            }
        }

        public Color FontColor
        {
            get { return label1.ForeColor; }
            set
            {
                label1.ForeColor = value;
            }
        }

        public bool IsClicked
        {
            get { return isClicked; }
            set
            {
                isClicked = value;
                panel1.Invalidate();
            }
        }

        private bool isClicked;

        public PageButton()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (isClicked)
            {
                int width = panel1.Width, height = panel1.Height;
                Brush brush = new SolidBrush(label1.ForeColor);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPolygon(brush, new Point[] {
                    new Point(0, height/2),
                    new Point(width, 0),
                    new Point(width, height)
                });
                brush.Dispose();
            }
        }
    }
}
