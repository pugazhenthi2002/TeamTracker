using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class TaskCompletionProgressBar : UserControl
    {
        public int TotalTask { get; set; }
        public int CompletedTask
        {
            get { return completedTask; }
            set
            {
                if(TotalTask!=0)
                {
                    completedTask = value;
                    percentage = value * 100 / TotalTask;
                    angle = percentage * 360 / 100;
                    panel2.Invalidate();
                }
                else
                {
                    completedTask = 0;
                    percentage = 0;
                    angle = 0;
                    panel2.Invalidate();
                }
            }

        }
        private int completedTask, angle, percentage;

        public TaskCompletionProgressBar()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void OnProgressBarPaint(object sender, PaintEventArgs e)
        {
            int padding = panel2.Height / 10;
            int width = panel2.Width, height = panel2.Height;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle outer = new Rectangle(padding, padding, height - padding * 2, height - padding * 2);
            Rectangle inner = new Rectangle(height/5, height/5, (height * 3 / 5), (height * 3 / 5));
            Brush valueBrush = new SolidBrush(Color.LightGreen);
            Brush outerBrush = new SolidBrush(Color.FromArgb(221, 230, 237));
            Brush innerBrush = new SolidBrush(Color.FromArgb(39, 55, 77));
            Brush textBrush = new SolidBrush(Color.FromArgb(221, 230, 237));
            StringFormat SFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Font headerFont = new Font(new FontFamily("Ebrima"), 12, FontStyle.Bold);

            e.Graphics.FillEllipse(outerBrush, outer);
            e.Graphics.FillPie(valueBrush, outer, 270, angle);
            e.Graphics.FillEllipse(innerBrush, inner);


            e.Graphics.DrawString(percentage.ToString(), headerFont, textBrush, inner, SFormat);

            valueBrush.Dispose();   outerBrush.Dispose(); innerBrush.Dispose();
        }
    }
}
