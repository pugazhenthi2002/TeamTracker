using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

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
            DoubleBuffered = true;
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, labelDate, new object[] { true });
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, labelDue, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, panel1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, panel2, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, panel3, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, panel4, new object[] { true });
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

        public Color HeaderForecolor
        {
            get
            {
                return labelDue.ForeColor;
            }
            set
            {
                labelDue.ForeColor = value;
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

        public new void Dispose()
        {
            labelDate.Dispose();    labelDue.Dispose();
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();   panel4.Dispose();
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
