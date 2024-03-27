using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class FullContentViewForm : Form
    {
        public string TitleName { get; set; }
        public string Content
        {
            get
            { return content; }
            set
            { content = value; label1.Text = value; }
        }
       
        public FullContentViewForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            titleFont = new Font(new FontFamily("Microsoft PhagsPa"), 20, FontStyle.Bold);
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, label1, new object[] { true });
        }

        private void FullContentTitleBarPanel_Paint(object sender, PaintEventArgs e)
        {
            headCnt++;
            SFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            titleBrush = new SolidBrush(Color.FromArgb(52, 104, 192));
            rec = new Rectangle(0, 0, fullContentTitleBarPanel.Width, fullContentTitleBarPanel.Height);

            e.Graphics.DrawString(TitleName, titleFont, titleBrush, rec, SFormat);
        }


        private void CloseButton1_Click(object sender, EventArgs e)
        {
            NotificationTemplate.isFullContentDisplayed = false;
            this.Close();
        }

        private void FullContentFormPaint(object sender, PaintEventArgs e)
        {
            cnt++;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            Brush b = new SolidBrush(Color.FromArgb(253, 240, 209));
            Rectangle rectangle = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
            FillRoundRectangle(e.Graphics, rectangle, b, 10);
            b.Dispose();
        }

        private static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
        {
            int l = 2 * r;
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);
            gp.CloseAllFigures();
            return gp;
        }

        private void FillRoundRectangle(Graphics g, Rectangle rectangle, Brush b, int r)
        {
            Pen p = new Pen(Color.Black, 3)
            {
                DashStyle = DashStyle.Solid
            };
            GraphicsPath path = new GraphicsPath();
            path = GetRoundRectangle(rectangle, r);
            g.FillPath(b, path);
            g.DrawPath(p, path);
            p.Dispose();
        }

        private void FullContentViewForm_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(1, 1, 1);
            this.BackColor = Color.FromArgb(1, 1, 1);

        }

        private void FullContentMessagePanel_Paint(object sender, PaintEventArgs e)
        {
            var x = Location.X;
        }

        private string content;

        private void Label1_Resize(object sender, EventArgs e)
        {
            var x = label1.Size;
        }

        private Font titleFont;
        private Brush titleBrush;
        private Rectangle rec;
        private StringFormat SFormat;
        static private int cnt = 0, headCnt=0;

        private void FullContentMessagePanel_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
