﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.ViewProject.BoardView.Custom_Controls
{
    public partial class BoardViewTemplate : UserControl
    {

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

        private void InitializeBorder()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorder();
        }
        public ProjectVersion BoardVersion
        {
            get { return boardVersion; }
            set
            {
                boardVersion = value;
                versionNameLabel.Text = value.VersionName;
                versionDateLabel.Text = value.StartDate.ToShortDateString() + " - " + value.EndDate.ToShortDateString();
            }
        }

        private ProjectVersion boardVersion;
        public BoardViewTemplate()
        {
            InitializeComponent();
            InitializeBorder();
        }

        private void OnMilestoneLabelPaint(object sender, PaintEventArgs e)
        {
            int width = (sender as Label).Width, height = (sender as Label).Height;
            Brush brush1 = new SolidBrush(Color.Gold);
            Brush brush2 = new SolidBrush(Color.White);
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = sFormat.LineAlignment = StringAlignment.Center;
            Font font = new Font(new FontFamily("Ebrima"), 10, FontStyle.Bold);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush1, new Rectangle(0, 0, width - 1, height - 1));
            e.Graphics.DrawString("5", font, brush2, new Rectangle(-1, -1, width, height), sFormat);
            brush1.Dispose();
        }

        private void OnTaskLabelPaint(object sender, PaintEventArgs e)
        {
            int width = (sender as Label).Width, height = (sender as Label).Height;
            Brush brush1 = new SolidBrush(Color.FromArgb(32, 201, 151));
            Brush brush2 = new SolidBrush(Color.White);
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = sFormat.LineAlignment = StringAlignment.Center;
            Font font = new Font(new FontFamily("Ebrima"), 10, FontStyle.Bold);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush1, new Rectangle(0, 0, width, height));
            e.Graphics.DrawString("5", font, brush2, new Rectangle(0, 0, width, height), sFormat);
            brush1.Dispose();
        }

        private void OnMilestoneStatusPaint(object sender, PaintEventArgs e)
        {

        }
    }
}
