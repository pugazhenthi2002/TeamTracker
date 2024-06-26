﻿using System;
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
        private Font textFont = new Font(new FontFamily("Ebrima"), 12, FontStyle.Bold);
        private Color textColor;
        private Projects project;

        public VerticalLabel()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void InitializePageColor()
        {
            textColor = panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
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
                panel2.BackColor = isClicked ? textColor: ThemeManager.CurrentTheme.SecondaryIII;
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
            e.Graphics.DrawLine(border, new Point(0, Height - 1), new Point(Width, Height - 1));
            e.Graphics.DrawLine(border, new Point(1, 1), new Point(Width, 1));
            e.Graphics.DrawLine(border, new Point(1, 1), new Point(1, Height));
            border.Dispose();
        }

        private void OnVerticalTextPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush b;
            if (!isClicked)
                b = new SolidBrush(textColor);
            else
                b = new SolidBrush(ThemeManager.CurrentTheme.SecondaryIII);

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
