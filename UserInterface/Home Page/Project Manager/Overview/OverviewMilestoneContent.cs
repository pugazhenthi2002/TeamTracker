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
using System.Runtime.InteropServices;

namespace UserInterface.Home_Page.Project_Manager.Overview
{
    public partial class OverviewMilestoneContent : UserControl
    {

        private ProjectVersion version;
        private bool IsBackEnable = false, IsNextEnable = true;
        private int flag;

        public OverviewMilestoneContent()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }


        public ProjectVersion Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
                if (value != null)
                    InitializeOverview();
                IsBackEnable = false;
                IsNextEnable = true;

                if (backNavigatePicBox.Image != null) backNavigatePicBox.Image.Dispose();
                if (nextNavPicBox.Image != null) nextNavPicBox.Image.Dispose();

                backNavigatePicBox.Image = IsBackEnable ? Properties.Resources.Left_Medium_Blue : Properties.Resources.Left_Dark_Blue;
                nextNavPicBox.Image = IsNextEnable ? Properties.Resources.Right_Medium_Blue : Properties.Resources.Right_Dark_Blue;
            }
        }

        private void OnResize(object sender, EventArgs e)
        {
            int topBottom = (milestonePanel.Height - 150)/2;
            milestonePanel.Padding = new Padding(0, topBottom, 0, topBottom);
            tableLayoutPanel3.Invalidate();
            tableLayoutPanel4.Invalidate();
            tableLayoutPanel5.Invalidate();
            tableLayoutPanel6.Invalidate();
            InitializeRoundedEdge();
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

        


        private void BackMilestoneClick(object sender, EventArgs e)
        {
            if (IsBackEnable)
                flag = milestoneView1.ChangeMilestoneUI(false);

            if (flag < 0) IsBackEnable = false;
            else { IsBackEnable = true; }
            IsNextEnable = true;

            if (backNavigatePicBox.Image != null) backNavigatePicBox.Image.Dispose();
            if (nextNavPicBox.Image != null) nextNavPicBox.Image.Dispose();

            backNavigatePicBox.Image = IsBackEnable ? Properties.Resources.Left_Medium_Blue : Properties.Resources.Left_Dark_Blue;
            nextNavPicBox.Image = IsNextEnable ? Properties.Resources.Right_Medium_Blue : Properties.Resources.Right_Dark_Blue;
        }

        private void NextMilestoneClick(object sender, EventArgs e)
        {
            if (IsNextEnable)
                flag = milestoneView1.ChangeMilestoneUI(true);

            if (flag > 0) IsNextEnable = false;
            else { IsNextEnable = true; }
            IsBackEnable = true;

            backNavigatePicBox.Image = IsBackEnable ? Properties.Resources.Left_Medium_Blue : Properties.Resources.Left_Dark_Blue;
            nextNavPicBox.Image = IsNextEnable ? Properties.Resources.Right_Medium_Blue : Properties.Resources.Right_Dark_Blue;
        }

        private void InitializeOverview()
        {
            List<int> result = TaskManager.FetchTaskCount(version.VersionID);

            taskCountLabel.Text = result[0].ToString();
            completedTaskLabel.Text = result[1].ToString();
            dueTaskLabel.Text = result[2].ToString();
            incompleteTaskLabel.Text = result[3].ToString();

            milestoneView1.MilestoneCollection = MilestoneManager.FetchMilestones(version.VersionID);

            flag = milestoneView1.ChangeMilestoneUI(true);

            if (flag > 0) IsNextEnable = false;
            else { IsNextEnable = IsBackEnable = true; }

            taskCompletionProgressBar1.TotalTask = result[0];
            taskCompletionProgressBar1.CompletedTask = result[1];
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Hand;
            if (picBox.Name == "backNavigatePicBox")
            {
                picBox.Image = Properties.Resources.Left_Dark_Blue_Hover;
            }
            else
            {
                picBox.Image = Properties.Resources.Right_Dark_Blue_Hover;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Default;
            if (picBox.Name == "backNavigatePicBox")
            {
                picBox.Image = IsBackEnable ? Properties.Resources.Left_Dark_Blue : Properties.Resources.Left_Medium_Blue;
            }
            else
            {
                picBox.Image = IsNextEnable ? Properties.Resources.Right_Dark_Blue : Properties.Resources.Right_Medium_Blue;
            }
        }

        private void OnTablePanelPaint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(221, 230, 237), 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(pen, new Point(15, panel1.Height), new Point((sender as TableLayoutPanel).Width - 15, panel1.Height));
            pen.Dispose();
        }

        private void OnLegendPaint(object sender, PaintEventArgs e)
        {
            Brush brush;
            if ((sender as Panel).Name == "donePanel") brush = new SolidBrush(Color.FromArgb(3, 4, 94));
            else if ((sender as Panel).Name == "delayPanel") brush = new SolidBrush(Color.FromArgb(0, 119, 182));
            else if ((sender as Panel).Name == "currentPanel") brush = new SolidBrush(Color.FromArgb(0, 180, 216));
            else brush = new SolidBrush(Color.FromArgb(144, 224, 239));

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(brush, new Rectangle(0, 0, (sender as Panel).Width-1, (sender as Panel).Height-1));
            brush.Dispose();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(221, 230, 237));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            e.Graphics.DrawPath(pen, BorderGraphicsPath.GetRoundRectangle(rec, 10));
        }

        private void InitializeRoundedEdge()
        {
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, 20, 20));
            backNavigatePicBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, backNavigatePicBox.Width, backNavigatePicBox.Height, 10, 10));
            nextNavPicBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nextNavPicBox.Width, nextNavPicBox.Height, 10, 10));
        }
    }
}
