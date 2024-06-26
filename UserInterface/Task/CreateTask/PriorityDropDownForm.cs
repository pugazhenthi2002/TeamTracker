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

namespace TeamTracker
{
    public partial class PriorityDropDownForm : Form
    {
        public event EventHandler<Priority> PrioritySelect;
        private const int CSDropShadow = 0x00020000;

        public PriorityDropDownForm()
        {
            InitializeComponent();
            InitializePageColor();
            InitializeRoundedEdge();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            BtnCritical.ForeColor = label1.ForeColor = label2.ForeColor = label3.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
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

        
        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void OnClickPriorityBtn(object sender, MouseEventArgs e)
        {
            Priority priority;
            string text = (sender as Label).Text;

            if (text == "Easy") priority = Priority.Easy;
            else if (text == "Medium") priority = Priority.Medium;
            else if (text == "Hard") priority = Priority.Hard;
            else priority = Priority.Critical;

            PrioritySelect?.Invoke(sender, priority);
            this.Close();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Control).ForeColor = ThemeManager.CurrentTheme.PrimaryIII;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Control).ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }
    }
}
