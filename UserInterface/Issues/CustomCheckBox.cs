using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Issues
{
    public partial class CustomCheckBox : UserControl
    {
        public event EventHandler CheckBoxValueChanged;
        private bool isChecked;
        private Color checkBoxColor;

        public bool Checked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                panel1.Invalidate();
            }
        }

        public string CheckBoxText
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

        public CustomCheckBox()
        {
            InitializeComponent();
        }

        private void CheckPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(panel1.Width / 10, panel1.Height / 10, panel1.Width * 8 / 10, panel1.Height * 8 / 10);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int R, G, B;
            R = BackColor.R + 50 <= 255 ? BackColor.R + 50 : 255;
            G = BackColor.G + 50 <= 255 ? BackColor.G + 50 : 255;
            B = BackColor.B + 50 <= 255 ? BackColor.B + 50 : 255;
            Brush brush;

            if (!isChecked)
                brush = new SolidBrush(Color.FromArgb(R, G, B));
            else
                brush = new SolidBrush(label1.ForeColor);

            e.Graphics.FillPath(brush, BorderGraphicsPath.GetRoundRectangle(rec, 10));

            R = BackColor.R - 50 >= 0 ? BackColor.R - 50 : 0;
            G = BackColor.G - 50 >= 0 ? BackColor.G - 50 : 0;
            B = BackColor.B - 50 >= 0 ? BackColor.B - 50 : 0;

            Pen border = new Pen(Color.FromArgb(R, G, B), 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(rec, 10));

            if (isChecked)
            {
                e.Graphics.DrawLines(border, new Point[]
                {
                new Point(rec.X+5,rec.Height/2),
                new Point(rec.X+rec.Width*4/10,rec.Y+(rec.Height*8/10)-5),
                new Point(rec.X+rec.Width-5, rec.Y+rec.Height/10+2)
                });
            }

            border.Dispose();
            brush.Dispose();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            isChecked = !isChecked;
            panel1.Invalidate();
            CheckBoxValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
