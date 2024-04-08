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

namespace UserInterface.ViewProject.TimelineView.Controls
{
    public partial class VerticalLabel : UserControl
    {
        private bool isClicked = true;
        private string text;
        private Font textFont = new Font(new FontFamily("Ebrima"), 12);
        private Color textColor = Color.FromArgb(39, 55, 77);
        private Projects project;

        public VerticalLabel()
        {
            InitializeComponent();
        }

        public event EventHandler<Projects> ProjectSelected;


        public Projects Project
        {
            get { return project; }
            set
            {
                project = value;
                text = value.ProjectName;
                panel2.Invalidate();
            }
        }

        public bool IsClicked
        {
            get
            {
                return isClicked;
            }
            set
            {
                isClicked = value;
                panel1.BackColor = textColor = isClicked ? Color.Red : Color.FromArgb(39, 55, 77);
                panel2.Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                panel1.BackColor = value;
                panel2.Invalidate();
            }
        }

        public Font TextFont
        {
            get { return textFont; }
            set
            {
                textFont = value;
                panel2.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen border = new Pen(textColor, 2);
            e.Graphics.DrawLine(border, new Point(0, Height), new Point(Width, Height));
            e.Graphics.DrawLine(border, new Point(0, 0), new Point(Width, 0));
            e.Graphics.DrawLine(border, new Point(0, 0), new Point(0, Height));
            border.Dispose();
        }

        private void OnVerticalTextPaint(object sender, PaintEventArgs e)
        {
            Brush b = new SolidBrush(textColor);
            StringFormat format = new StringFormat();
            format.Alignment = format.LineAlignment =  StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            e.Graphics.DrawString(text, textFont, b, new Rectangle(0,0,panel2.Width, panel2.Height), format);
            b.Dispose();
        }

        private void OnProjectClicked(object sender, EventArgs e)
        {
            ProjectSelected?.Invoke(this, project);
        }

        
    }
}
