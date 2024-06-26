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
using UserInterface;
using UserInterface.Task.CreateTask;
using UserInterface.ViewPage;

namespace TeamTracker
{
    public partial class MilestoneDropDownForm : Form
    {
        public bool IsEditModeOn { get; set; }
        private TransparentForm transparentForm;
        private List<Milestone> milestoneList = new List<Milestone>();
        private const int CSDropShadow = 0x00020000;
        private Milestone selectedMilestone;

        public MilestoneDropDownForm()
        {
            InitializeComponent();
            InitializePageColor();
            InitializeRoundedEdge();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
        }

        public EventHandler<Milestone> MilestoneClick;

        private int dropDownCount=4;
        public int DropDownCount
        {
            get { return dropDownCount; }
            set { dropDownCount = value; }
        }

        public List<Milestone> MilestoneList
        {
            
            set
            {
                if (value != null)
                {
                    milestoneList = value;
                    InitializeMilestones();
                }
            }
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

        private void UnSubscribeEventsAndRemoveMemory()
        {
            for(int ctr=0; ctr < Controls.Count; ctr++)
            {
                (Controls[ctr] as Label).Click -= OnClickMilestoneBtn;
                (Controls[ctr] as Label).MouseEnter -= OnMouseEnter;
                (Controls[ctr] as Label).MouseLeave -= OnMouseLeave;
                (Controls[ctr] as Label).Dispose();
                ctr--;
            }
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void InitializeMilestones()
        {
            if (milestoneList.Count <= dropDownCount)
            {
                this.Size = new Size(this.Width, 50 * (milestoneList.Count()));
            }
            else
            {
                this.Size = new Size(this.Width, 50 * dropDownCount);
            }

            foreach (Milestone milestone in milestoneList)
            {
                Label mileStoneBtn = new Label();
                mileStoneBtn.AutoSize = false;
                mileStoneBtn.TextAlign = ContentAlignment.MiddleCenter;
                mileStoneBtn.FlatStyle = FlatStyle.Flat;
                mileStoneBtn.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
                mileStoneBtn.BackColor = Color.Transparent;
                mileStoneBtn.Font = new Font(new FontFamily("Ebrima"), 12, FontStyle.Bold);
                mileStoneBtn.Text = milestone.MileStoneName;
                mileStoneBtn.Size = new Size(this.Width, 50);
                mileStoneBtn.Dock = DockStyle.Top;
                mileStoneBtn.Click += OnClickMilestoneBtn;
                mileStoneBtn.MouseEnter += OnMouseEnter;
                mileStoneBtn.MouseLeave += OnMouseLeave;
                this.Controls.Add(mileStoneBtn);
            }

            foreach(Control Iter in Controls)
            {
                Iter.BringToFront();
            }
            this.Invalidate();
            var x = Focused;
            Focus();
        }

        private void OnClickMilestoneBtn(object sender, EventArgs e)
        {
            var x = Controls.GetChildIndex(sender as Control);
            selectedMilestone = milestoneList[milestoneList.Count - Controls.GetChildIndex(sender as Control) - 1];
            if (!IsEditModeOn)
            {
                if (IsMilestoneAlreadyCompleted((sender as Label).Text))
                {
                    WarningForm form = new WarningForm();
                    form.Content = "Are you sure, you want to Add a Task to Already Completed Milestone. A Warning will be sent to your Project Manager.";
                    form.WarningStatus += OnWarningStatus;

                    transparentForm = new TransparentForm();
                    transparentForm.Show(ParentForm);
                    transparentForm.ShowForm(form);
                }
                else
                {
                    MilestoneClick?.Invoke(this, selectedMilestone);
                    Dispose();
                    this.Close();
                }
            }
            else
            {
                MilestoneClick?.Invoke(this, selectedMilestone);
                Dispose();
                this.Close();
            }
        }

        private void OnWarningStatus(object sender, bool e)
        {
            (sender as WarningForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (e)
            {
                MilestoneClick?.Invoke(this, selectedMilestone);
            }
            else
            {
                MilestoneClick?.Invoke(this, null);
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Dispose();
            this.Close();
        }

        private bool IsMilestoneAlreadyCompleted(string text)
        {
            foreach (var Iter in milestoneList)
            {
                if (Iter.MileStoneName == text)
                {
                    return Iter.Status == MilestoneStatus.Completed;
                }
            }

            return false;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            (sender as Control).ForeColor = ThemeManager.CurrentTheme.PrimaryIII;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            (sender as Control).ForeColor = ThemeManager.CurrentTheme.PrimaryI; 
        }
    }
}
