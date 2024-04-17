using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class TextBoxU : UserControl
    {
        private Font placeholderTextCenterFont = new Font(FontFamily.GenericSansSerif, 11);
        private Font placeholderTextTopFont = new Font(FontFamily.GenericSansSerif, 9);
        private Color placeholderLabelAtTopColor = Color.FromArgb(65, 125, 225);
        private Color placeholderLabelAtCenterColor = Color.FromArgb(130, 130, 130);
        private Timer timer=new Timer();
        private bool isCenterPlaceHolder;
        private int borderRadius = 7;
        private Point placeholderlocation;


        public TextBoxU()
        {
            InitializeComponent();
            textBox1.MouseEnter += TextBox1MouseEnter;
            this.Resize += TextBoxUResize;
            textBox1.GotFocus += TextBoxUGotFocus;
            textBox1.LostFocus += TextBoxULostFocus;
            label1.Click += Label1Click;
            TextBoxUResize(this, EventArgs.Empty);
            isCenterPlaceHolder = true;
            timer.Interval = 15;
            timer.Tick += PlaceholderMove;
            this.Paint += TextBoxUPaint;
            Click += Label1Click;
        }

        public int Interval
        {
            get
            {
                return timer.Interval;
            }
            set
            {
                timer.Interval = value;
            }
        }
        public Color TextBoxColor
        {
            get { return textBox1.BackColor; }
            set
            {
                textBox1.BackColor = value;
            }
        }

        public Color PlaceholderLabelAtTopColor
        {
            get
            {
                return placeholderLabelAtTopColor;
            }
            set
            {
                placeholderLabelAtTopColor = value;
            }
        }
        public Color PlaceholderLabelAtCenterColor
        {
            get
            {
                return placeholderLabelAtCenterColor;
                
            }
            set
            {
                placeholderLabelAtCenterColor = value;
                label1.ForeColor = value;
                //textBox1.BackColor = value;
                Invalidate();
            }

        }
        public bool Multiline
        {
            get
            {
                return textBox1.Multiline;
               
            }
            set
            {
                textBox1.Multiline = value;
                TextBoxUResize(this, EventArgs.Empty);
            }
        }
        public DockStyle TextBoxDock
        {
            get
            {
                return textBox1.Dock;
            }
            set
            {
                 textBox1.Dock=value;
            }
        }
        public bool UseSystemPasswordChar
        {
            get
            {
               return  textBox1.UseSystemPasswordChar;

            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
                if(value)
                {
                    textBox1.Multiline = false;
                    textBox1.Dock = DockStyle.None;
                    TextBoxUResize(this, EventArgs.Empty);
                }
                else
                {
                    textBox1.Multiline = true;
                    textBox1.Dock = DockStyle.Fill;
                }

            }
        }
        public char PasswordChar
        {
            get
            {
                return textBox1.PasswordChar;
            }
            set
            {
                textBox1.PasswordChar = value;
            }
        }
        public string TextBoxtext
        {
            get
            {
                return textBox1.Text;
                
            }
            set
            {
                textBox1.Text = value;
                
            }
        }
        public string PlaceholderText
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
        public Color TextForeColor
        {
            get
            {
                return textBox1.ForeColor;
            }
            set
            {
               
                textBox1.ForeColor = value;
            }

        }


       
        private GraphicsPath GetGraphicsPath(Rectangle rect)
        {
           
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(rect.Width - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(rect.Width - borderRadius, rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(rect.X, rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void TextBoxUPaint(object sender, PaintEventArgs e)
        { var g= e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Color borderColor;
            if (isCenterPlaceHolder)
                 borderColor = placeholderLabelAtCenterColor;
            else
                borderColor = placeholderLabelAtTopColor;
            
            using (Pen pen=new Pen(borderColor,2))
            {
                g.DrawPath(pen,GetGraphicsPath(new Rectangle(ClientRectangle.Location.X + 3, ClientRectangle.Location.Y + 2, ClientRectangle.Width - 6, ClientRectangle.Height - 4)));
            }
        }

        private void Label1Click(object sender, EventArgs e)
        {
            if (isCenterPlaceHolder)
            {
                TextBoxUGotFocus(this,EventArgs.Empty);
               textBox1.Focus();
            }
        }

        private void TextBox1MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void PlaceholderMove(object sender, EventArgs e)
        {
            if (isCenterPlaceHolder == true&& (label1.Location.X>0&& label1.Location.Y>-3))
            {
                label1.Location=new Point(label1.Location.X-2, label1.Location.Y-2);
            }
            else if(isCenterPlaceHolder == false&& (label1.Location.X < placeholderlocation.X && label1.Location.Y< placeholderlocation.Y)){
                label1.Location = new Point(label1.Location.X +2, label1.Location.Y +2);
            }
            else
            {
                isCenterPlaceHolder = !isCenterPlaceHolder;
                timer.Stop();
                Invalidate();
            }
        }

        private void TextBoxULostFocus(object sender, EventArgs e)
        {
            Point temp_Point = PointToClient(Cursor.Position);
         //   if (2 > temp_Point.X || temp_Point.X >= Width-2|| 2 >temp_Point.Y || temp_Point.Y>= Height-2)
          //  {
                if (textBox1.Text == "" || textBox1.Text == null)
                {
                    label1.ForeColor = placeholderLabelAtCenterColor;
                    label1.Font = placeholderTextCenterFont;
                    timer.Start();
                }
          //  }
           
        }

        private void TextBoxUGotFocus(object sender, EventArgs e)
        {
            if (isCenterPlaceHolder)
            {
                label1.ForeColor = placeholderLabelAtTopColor;
                label1.Font = placeholderTextTopFont;
                timer.Start();
            }
           
        }

        private void TextBoxUResize(object sender, EventArgs e)
        {
            if (!textBox1.UseSystemPasswordChar)
                Padding = new Padding(18, 20, Padding.Right, Padding.Bottom);
            else
                Padding = new Padding(18, 15, Padding.Right, Padding.Bottom);


            textBox1.Width= Width-Padding.Left-Padding.Right;
            textBox1.Location= new Point(Padding.Left,Height/2-(textBox1.Height/2));
            if (!textBox1.UseSystemPasswordChar)
            {
                placeholderlocation = new Point(textBox1.Location.X + (textBox1.Location.Y + (textBox1.Height / 2 - label1.Height / 2)) , 1+ Height / 2 - label1.Height / 2);              
            }
            else
            {
                placeholderlocation = new Point(textBox1.Location.X + (textBox1.Location.Y + (textBox1.Height / 2 - label1.Height / 2)) , 1+ Height / 2 - label1.Height / 2);              
            }
            label1.Location = placeholderlocation;
        }
    }
}
