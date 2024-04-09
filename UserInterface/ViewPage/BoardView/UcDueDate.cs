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
    public partial class UcDueDate : UserControl
    {

        private string centerLabelText;
        private Color borderColor = Color.Blue;
        private DateTime date;
        private Color DueColor = Color.Blue;
        private string labelText = "Due";

        public UcDueDate()
        {
            InitializeComponent();
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
        public Color DueLabelcolor
        {
            get
            {
                return DueColor;
            }
            set
            {
                DueColor = value;
                SetDueLabelColor();
            }
        }

        public DateTime DueDate
        {
            get { return date; }
            set
            {
                date = value;
                SetDate();
            }
        }

        public string LabelText
        {
            get { return labelText; }
            set
            {
                labelText = value;
                SetDueText();
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

        private void SetDate()
        {
            if (date != DateTime.MinValue)
            {
                labelDate.Text = date.ToString("dd/MM/yyyy");
            }
        }
        private void SetDueLabelColor()
        {
            labelDue.BackColor = DueColor;
        }
        private void SetDueText()
        {
            labelDue.Text = labelText;
        }
        private void SetCenterText()
        {
            if (centerLabelText != "")
            {
                labelDate.Text = centerLabelText;
            }

        }
    }
}
