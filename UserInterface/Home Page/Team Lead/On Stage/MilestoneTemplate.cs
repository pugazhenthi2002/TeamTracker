using System;
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

        public string placeHolderText;

        private bool? isEligibleContraints;
        private bool isFocused;
        public bool IsFocused
        {
            get
            {
                return isFocused;
            }

            set
            {
                isFocused = value;
                Invalidate();
            }
        }

        public bool IsDownSwapEnable { get; set; }
        public bool IsUpSwapEnable { get; set; }

        public int counter;
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

        public Milestone milestone;
        public Milestone SelectedMilestone
        {
            get
            {
                return milestone;
            }

            set
            {
                milestone = value;
                placeHolderText = value.MileStoneName;
                InitializeControl();
            }
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 10, 10));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 10, 10));
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

        public MilestoneTemplate()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            SubscribeEvents();
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

            upButton.Image = IsUpSwapEnable ? Properties.Resources.Up_Light_Blue : Properties.Resources.Up_Medium_Blue;
            downButton.Image = IsDownSwapEnable ? Properties.Resources.Down_Light_Blue : Properties.Resources.Down_Medium_Blue;
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            if (isEligibleContraints!=null && isEligibleContraints==true)
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
            }
        }

        private void CheckDuplication(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                isEligibleContraints =  CheckConstraints?.Invoke(this, new MilestoneEventArgs()
                {
                    MilestoneDate = milestoneDate.Value.Date,
                    MilestoneName = milestoneName.Text,
                    Movement = MilestoneOperation.Steady,
                    Position = Convert.ToInt32(counterLabel.Text)
                });

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (isFocused)
            {
                Pen border = new Pen(Color.Red, 2);
                e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, Width - 1, Height - 1), 5));
                border.Dispose();
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
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawRectangle(border, new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1));
            border.Dispose(); 
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Hand;
            if (picBox.Name == "upButton")
            {
                picBox.Image = Properties.Resources.Up_Dark_Blue_Hover;
            }
            else
            {
                picBox.Image = Properties.Resources.Down_Dark_Blue_Hover;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Default;
            if (picBox.Name == "upButton")
            {
                picBox.Image = IsUpSwapEnable ? Properties.Resources.Up_Light_Blue : Properties.Resources.Up_Dark_Blue;
            }
            else
            {
                picBox.Image = IsDownSwapEnable ? Properties.Resources.Down_Light_Blue : Properties.Resources.Down_Dark_Blue;
            }
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            if(closeButton.Image != null)   closeButton.Image.Dispose();

            closeButton.Image = Properties.Resources.Close_Light_Blue_Hover;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            if (closeButton.Image != null) closeButton.Image.Dispose();

            closeButton.Image = Properties.Resources.Close_30;
        }
    }
}
