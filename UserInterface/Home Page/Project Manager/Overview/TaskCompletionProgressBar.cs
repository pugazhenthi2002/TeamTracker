﻿using System;
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
                    CompletedTask = value;
                    percentage = value * 100 / TotalTask;
                    angle = percentage * 360 / 100;
                    panel2.Invalidate();
                }
                else
                {
                    percentage = 0;
                    angle = 0;
                    panel2.Invalidate();
                }
            }

        }
        private int completedTask, angle, percentage;

        public TaskCompletionProgressBar()
        {
            InitializeComponent();
        }

        private void OnProgressBarPaint(object sender, PaintEventArgs e)
        {
            int width = panel2.Width, height = panel2.Height;

            Rectangle outer = new Rectangle(0, 0, width, height);
            Rectangle inner = new Rectangle(width/5, height/5, width * 3 / 5, height * 3 / 5);
            Brush valueBrush = new SolidBrush(Color.Green);
            Brush outerBrush = new SolidBrush(Color.Gray);
            Brush innerBrush = new SolidBrush(Color.White);
            Brush textBrush = new SolidBrush(Color.Black);
            StringFormat SFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Font headerFont = new Font(new FontFamily("Ebrima"), 12, FontStyle.Bold);

            e.Graphics.FillEllipse(outerBrush, outer);
            e.Graphics.FillPie(innerBrush, outer, 270, angle);
            e.Graphics.FillEllipse(valueBrush, inner);
            e.Graphics.DrawString(percentage.ToString(), headerFont, textBrush, inner, SFormat);

            valueBrush.Dispose();   outerBrush.Dispose(); innerBrush.Dispose();
        }
    }
}