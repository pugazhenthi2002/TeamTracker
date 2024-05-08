using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class UcTaskDescription : UserControl
    {

        private string topLabelText = "Task Name";
        private string centerLabelText;
        private Color borderColor = Color.Black;
        private Color topLabelColor = Color.White;
        private Color topLabelForeColor = Color.White;

        public UcTaskDescription()
        {
            InitializeComponent();
        }

        public bool EnableEdit
        {
            get
            {
                return labelCenter.ReadOnly;
            }
            set
            {
                labelCenter.ReadOnly = value;
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color TopLabelColor
        {
            get { return topLabelColor; }
            set
            {
                topLabelColor = value;
                SetTopText();
            }
        }

        public Color TopLabelForeColor
        {
            get { return topLabelForeColor; }
            set
            {
                topLabelForeColor = value;
                SetTopLabelForeColor();
            }
        }

        public string TopLabelText
        {
            get { return topLabelText; }
            set
            {
                topLabelText = value;
                SetTopText();
            }
        }

        public string CenterLabelText
        {
            get { return centerLabelText; }
            set
            {
                centerLabelText = value;
                SetCenterText();
            }
        }

        public new void Dispose()
        {
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();   panel4.Dispose();
            labelCenter.Dispose();  labelTop.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Point pt1 = new Point(4, 4);
            Point pt2 = new Point(Width - 6, 4);
            Point pt3 = new Point(Width - 6, Height - 6);
            Point pt4 = new Point(4, Height - 6);
            Pen border = new Pen(borderColor, 2);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void SetTopLabelForeColor()
        {
            labelTop.ForeColor = topLabelForeColor;
        }

        private void SetTopText()
        {
            labelTop.BackColor = TopLabelColor;
            labelTop.Text = topLabelText;

        }
        private void SetCenterText()
        {
            labelCenter.Text = centerLabelText;
        }
    }
}
