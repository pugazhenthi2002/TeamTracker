﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.ViewProject
{
    public partial class VersionViewForm : Form
    {
        public List<ProjectVersion> VersionCollection;
        public List<Label> labelControlCollection;

        private const int CSDropShadow = 0x00020000;


        public VersionViewForm()
        {
            InitializeComponent();
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            for(int ctr = 0; ctr < Controls.Count; ctr++)
            {
                (Controls[ctr] as Label).MouseEnter -= OnLabelMouseEnter;
                (Controls[ctr] as Label).MouseLeave -= OnLabelMouseLeave;
                (Controls[ctr] as Label).Click -= OnVersionClick;
            }
        }

        public event EventHandler<ProjectVersion> VersionSelected;


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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int drawHeight = 50;
            Pen pen = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);

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
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializeDropDownForm();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void OnLabelMouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            this.Invalidate();
        }

        private void OnLabelMouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = ThemeManager.CurrentTheme.PrimaryIII;
            this.Invalidate();
        }

        private void InitializeDropDownForm()
        {
            if (VersionCollection.Count >= 4)
            {
                Height = 200;
            }
            else
            {
                Height = VersionCollection.Count * 50;
            }

            Label label;
            labelControlCollection = new List<Label>();

            foreach (var Iter in VersionCollection)
            {
                foreach (var ctr in labelControlCollection)
                {
                    ctr.BringToFront();
                }

                label = new Label()
                {
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 50,
                    Name = Iter.VersionName,
                    Text = Iter.VersionName,
                    Font = new Font(new FontFamily("Ebrima"), 10, FontStyle.Bold),
                    ForeColor = ThemeManager.CurrentTheme.PrimaryI,
                    BackColor = Color.Transparent
                };
                label.MouseEnter += OnLabelMouseEnter;
                label.MouseLeave += OnLabelMouseLeave;
                label.Click += OnVersionClick;
                labelControlCollection.Add(label);
                Controls.Add(label);
            }
            foreach (var ctr in labelControlCollection)
            {
                ctr.BringToFront();
            }
        }

        private void OnVersionClick(object sender, EventArgs e)
        {
            string name = (sender as Label).Name;
            foreach (var Iter in VersionCollection)
            {
                if (Iter.VersionName == name)
                {
                    VersionSelected?.Invoke(this, Iter);
                    this.Close();
                }
            }
        }
    }
}
