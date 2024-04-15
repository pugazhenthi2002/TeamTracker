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

        public MilestoneTemplate()
        {
            InitializeComponent();
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

            upButton.Image = IsUpSwapEnable ? Properties.Resources.sort_up : Properties.Resources.sort_up_hover;
            downButton.Image = IsDownSwapEnable ? Properties.Resources.sort_down : Properties.Resources.sort_down_hover;
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            if (isEligibleContraints!=null && isEligibleContraints==true)
            {
                MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
                {
                    MilestoneDate = milestoneDate.Value,
                    MilestoneName = milestoneName.Text,
                    Position = Convert.ToInt32(counterLabel.Text),
                    Movement = MilestoneOperation.Steady
                });
                milestone.EndDate = milestoneDate.Value;
            }
            else
            {
                milestoneDate.Value = milestone.EndDate;
            }
        }

        private void CheckPreviousDate(object sender, EventArgs e)
        {
            isEligibleContraints = CheckConstraints?.Invoke(this, new MilestoneEventArgs()
            {
                MilestoneDate = milestoneDate.Value,
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
                    MilestoneDate = milestoneDate.Value,
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
                    MilestoneDate = milestoneDate.Value,
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
                MilestoneDate = milestoneDate.Value,
                MilestoneName = milestoneName.Text,
                Position = Convert.ToInt32(counterLabel.Text),
                Movement = MilestoneOperation.Delete
            });
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter && isEligibleContraints != null && isEligibleContraints == true)
            {
                MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
                {
                    MilestoneDate = milestoneDate.Value,
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
                    MilestoneDate = milestoneDate.Value,
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
                Pen border = new Pen(Color.Red);
                e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, Width - 1, Height - 1), 10));
                border.Dispose();
            }
        }

        private void OnClicked(object sender, EventArgs e)
        {
            FocusChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
