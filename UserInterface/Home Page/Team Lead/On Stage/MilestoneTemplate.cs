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

namespace UserInterface.Home_Page.Team_Lead.On_Stage
{
    public partial class MilestoneTemplate : UserControl
    {
        public delegate void MilestoneHandler(object sender, MilestoneEventArgs m);
        public delegate bool ContraintsHandler(object sender, MilestoneEventArgs m);
        public event MilestoneHandler MilestoneOperate;
        public event EventHandler FocusChanged;
        public event ContraintsHandler CheckConstraints;

        public bool IsFocused
        {
            get
            {
                return isFocused;
            }

            set
            {
                isFocused = value;
                tableLayoutPanel1.BackColor = value ? ThemeManager.CurrentTheme.SecondaryI : ThemeManager.CurrentTheme.SecondaryII;
            }
        }

        public bool IsDownSwapEnable { get; set; }
        public bool IsUpSwapEnable { get; set; }

        public int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                counter = value;
                counterLabel.Text = value.ToString();
            }
        }

        public Milestone SelectedMilestone
        {
            get
            {
                return milestone;
            }

            set
            {
                if (value != null)
                {
                    milestone = value;
                    placeHolderText = value.MileStoneName;
                    InitializeControl();
                }
            }
        }

        private void InitializeRoundedEdge()
        {
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 10, 10));
        }

        public MilestoneTemplate()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            SubscribeEvents();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        public new void Dispose()
        {
            if (closeButton.Image != null) closeButton.Image.Dispose();
            if (upButton.Image != null) upButton.Image.Dispose();
            if (downButton.Image != null) downButton.Image.Dispose();

            closeButton.Dispose(); upButton.Dispose(); downButton.Dispose();
            panel1.Dispose(); panel2.Dispose(); counterLabel.Dispose();
            tableLayoutPanel1.Dispose();
            milestoneDate.Dispose();
            milestoneName.Dispose();
        }

        private void InitializePageColor()
        {
            tableLayoutPanel1.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            milestoneName.BackColor = milestoneDate.SkinColor = ThemeManager.CurrentTheme.SecondaryIII;
            milestoneName.ForeColor = milestoneDate.BorderColor = milestoneDate.TextColor = ThemeManager.CurrentTheme.PrimaryI;
            upButton.Image?.Dispose();  downButton.Image?.Dispose();    closeButton.Image?.Dispose();

            closeButton.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Dark : Properties.Resources.Heat_Close_Dark;
            ResetButton();
        }

        private void SubscribeEvents()
        {
            upButton.Click += GetFocus;
            upButton.Click += OnUpButtonClicked;

            downButton.Click += GetFocus;
            downButton.Click += OnDownButtonClicked;

            milestoneDate.ValueChanged += CheckPreviousDate;
            milestoneDate.ValueChanged += OnValueChanged;

            milestoneName.KeyDown += CheckDuplication;
            milestoneName.KeyDown += OnKeyDown;

            milestoneName.LostFocus += AddMilestonePlaceHolders;
            milestoneDate.GotFocus += TemplateGotFocus;
        }

        private void TemplateGotFocus(object sender, EventArgs e)
        {
            FocusChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AddMilestonePlaceHolders(object sender, EventArgs e)
        {
            milestoneName.Text = placeHolderText;
        }

        private void InitializeControl()
        {
            milestoneName.Text = milestone.MileStoneName;
            milestoneDate.Value = milestone.EndDate;

            if (upButton.Image != null) upButton.Image.Dispose();
            if (downButton.Image != null) downButton.Image.Dispose();

            ResetButton();
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            if (isEligibleContraints != null && isEligibleContraints == true)
            {
                MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
                {
                    MilestoneDate = milestoneDate.Value.Date,
                    MilestoneName = milestoneName.Text,
                    Position = Convert.ToInt32(counterLabel.Text),
                    Movement = MilestoneOperation.Steady
                });
                milestone.EndDate = milestoneDate.Value.Date;
            }
            else
            {
                milestoneDate.Value = milestone.EndDate.Date;
            }
        }

        private void CheckPreviousDate(object sender, EventArgs e)
        {
            isEligibleContraints = CheckConstraints?.Invoke(this, new MilestoneEventArgs()
            {
                MilestoneDate = milestoneDate.Value.Date,
                MilestoneName = milestoneName.Text,
                Movement = MilestoneOperation.Steady,
                Position = Convert.ToInt32(counterLabel.Text)
            });
        }

        private void OnUpButtonClicked(object sender, EventArgs e)
        {
            if (IsUpSwapEnable)
            {
                MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
                {
                    MilestoneDate = milestoneDate.Value.Date,
                    MilestoneName = milestoneName.Text,
                    Position = Convert.ToInt32(counterLabel.Text),
                    Movement = MilestoneOperation.Up
                });
            }
        }

        private void OnDownButtonClicked(object sender, EventArgs e)
        {
            if (IsDownSwapEnable)
            {
                MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
                {
                    MilestoneDate = milestoneDate.Value.Date,
                    MilestoneName = milestoneName.Text,
                    Position = Convert.ToInt32(counterLabel.Text),
                    Movement = MilestoneOperation.Down
                });
            }
        }

        private void GetFocus(object sender, EventArgs e)
        {
            FocusChanged?.Invoke(this, EventArgs.Empty);
        }

        private void OnDelete(object sender, EventArgs e)
        {
            MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
            {
                MilestoneDate = milestoneDate.Value.Date,
                MilestoneName = milestoneName.Text,
                Position = Convert.ToInt32(counterLabel.Text),
                Movement = MilestoneOperation.Delete
            });
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && isEligibleContraints != null && isEligibleContraints == true)
            {
                MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
                {
                    MilestoneDate = milestoneDate.Value.Date,
                    MilestoneName = milestoneName.Text,
                    Position = Convert.ToInt32(counterLabel.Text),
                    Movement = MilestoneOperation.Steady
                });
                placeHolderText = milestoneName.Text;
                Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void CheckDuplication(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                isEligibleContraints = CheckConstraints?.Invoke(this, new MilestoneEventArgs()
                {
                    MilestoneDate = milestoneDate.Value.Date,
                    MilestoneName = milestoneName.Text,
                    Movement = MilestoneOperation.Steady,
                    Position = Convert.ToInt32(counterLabel.Text)
                });

            }
        }

        private void OnClicked(object sender, EventArgs e)
        {
            FocusChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawRectangle(border, new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1));
            border.Dispose();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            if (picBox.Name == "upButton")
            {
                picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Up_Dark_Hover : Properties.Resources.Heat_Up_Dark_Hover;
            }
            else
            {
                picBox.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Down_Dark_Hover : Properties.Resources.Heat_Down_Dark_Hover;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            if (picBox.Name == "upButton")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    upButton.Image = IsUpSwapEnable ? Properties.Resources.Cold_Up_Dark : Properties.Resources.Cold_Up_Light;
                }
                else
                {
                    upButton.Image = IsUpSwapEnable ? Properties.Resources.Heat_Up_Dark : Properties.Resources.Heat_Up_Light;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    downButton.Image = IsDownSwapEnable ? Properties.Resources.Cold_Down_Dark : Properties.Resources.Cold_Down_Light;
                }
                else
                {
                    downButton.Image = IsDownSwapEnable ? Properties.Resources.Heat_Down_Dark : Properties.Resources.Heat_Down_Light;
                }
            }
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            if (closeButton.Image != null) closeButton.Image.Dispose();

            closeButton.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Dark_Hover : Properties.Resources.Heat_Close_Dark_Hover;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            if (closeButton.Image != null) closeButton.Image.Dispose();

            closeButton.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Close_Dark : Properties.Resources.Heat_Close_Dark;
        }

        private void ResetButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                upButton.Image = IsUpSwapEnable ? Properties.Resources.Cold_Up_Dark : Properties.Resources.Cold_Up_Light;
                downButton.Image = IsDownSwapEnable ? Properties.Resources.Cold_Down_Dark : Properties.Resources.Cold_Down_Light;
            }
            else
            {
                upButton.Image = IsUpSwapEnable ? Properties.Resources.Heat_Up_Dark : Properties.Resources.Heat_Up_Light;
                downButton.Image = IsDownSwapEnable ? Properties.Resources.Heat_Down_Dark : Properties.Resources.Heat_Down_Light;
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

        public Milestone milestone;
        public string placeHolderText;
        public int counter;
        private bool? isEligibleContraints;
        private bool isFocused;
    }
}
