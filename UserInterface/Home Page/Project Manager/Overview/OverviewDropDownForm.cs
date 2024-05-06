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
    public partial class OverviewDropDownForm : Form
    {
        public delegate void OverviewHandler(string name, ProjectVersion version);
        public event OverviewHandler OverviewSelected;

        public OverviewDropDownForm()
        {
            InitializeComponent();
        }

        public new void Dispose()
        {
             for(int ctr=0; ctr< Controls.Count; ctr++)
            {
                (Controls[ctr] as Label).Dispose();
                ctr--;
            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int drawHeight = 50;
            Pen pen = new Pen(Color.FromArgb(39, 55, 77), 2);

            while (drawHeight < Height)
            {
                e.Graphics.DrawLine(pen, new Point(5, drawHeight), new Point(Width - 5, drawHeight));
                drawHeight += 50;
            }
            pen.Dispose();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Dispose();
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializeDropDownForm();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        

        private void InitializeDropDownForm()
        {
            if(CurrentVersionCollection.Count >= 4)
            {
                Height = 200;
            }
            else
            {
                Height = CurrentVersionCollection.Count * 50;
            }

            Label label;

            foreach(var Iter in CurrentVersionCollection)
            {
                label = new Label()
                {
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 50,
                    Name = Iter.Key,
                    Text = Iter.Key + "\n" + Iter.Value.VersionName,
                    Font = new Font(new FontFamily("Ebrima"), 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(39, 55, 77),
                    BackColor = Color.Transparent
                };
                label.MouseEnter += OnLabelMouseEnter;
                label.MouseLeave += OnLabelMouseLeave;
                label.Click += OnOverviewClick;
                Controls.Add(label);
            }
        }

        private void OnLabelMouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(39, 55, 77);
            this.Invalidate();
        }

        private void OnLabelMouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(82, 109, 130);
            this.Invalidate();
        }

        private void OnOverviewClick(object sender, EventArgs e)
        {
            string name = (sender as Label).Name;
            foreach(var Iter in CurrentVersionCollection)
            {
                if(Iter.Key == name)
                {
                    OverviewSelected?.Invoke(name, Iter.Value);
                    this.Close();
                }
            }
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

        private const int CSDropShadow = 0x00020000;
        public Dictionary<string, ProjectVersion> CurrentVersionCollection;
    }
}
