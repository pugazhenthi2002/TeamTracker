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
    public partial class AddMilestoneForm : Form
    {
        

        public AddMilestoneForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            labelWarning.Hide();
        }

        public EventHandler ClickAdd;

        public string MileStoneName { get; private set; }
        public DateTime From { get; private set; }
        public DateTime To { get; private set; }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }


        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            buttonDiscard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDiscard.Width, buttonDiscard.Height, 10, 10));
            buttonAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonAdd.Width, buttonAdd.Height, 10, 10));


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
        private void OnPaintDateBase(object sender, PaintEventArgs e)
        {
            Point pt1 = new Point(4, 4);
            Point pt2 = new Point((sender as Panel).Width - 6, 4);
            Point pt3 = new Point((sender as Panel).Width - 6, (sender as Panel).Height - 6);
            Point pt4 = new Point(4, (sender as Panel).Height - 6);
            Pen border = new Pen(Color.Black, 2);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void OnClickDiscard(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OnClickAdd(object sender, EventArgs e)
        {
            if (textBoxMilestone.TextBoxtext == "" )
            {
                labelWarning.Text = "Milestone name not set!";
                labelWarning.Show();
                return;
            }
            else if(dateTimePickerFrom.Value>dateTimePickerTo.Value)
            {
                labelWarning.Text = "Invalid Due date!";
                labelWarning.Show();
                return;
            }
            MileStoneName = textBoxMilestone.TextBoxtext;
            From = dateTimePickerFrom.Value;
            To = dateTimePickerTo.Value;

            ClickAdd?.Invoke(sender, e);
            this.Dispose();
        }
    }
}
