using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Task.CreateTask;

namespace TeamTracker
{
    public partial class MilestoneDropDownForm : Form
    {

        private List<Milestone> milestoneList = new List<Milestone>();
        private const int CSDropShadow = 0x00020000;


        public MilestoneDropDownForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }

        public EventHandler MilestoneClick;

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


        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void InitializeMilestones()
        {
            if (milestoneList.Count <= 4)
            {
                this.Size = new Size(this.Width, 50 * (milestoneList.Count()));
            }
            else
            {
                this.Size = new Size(this.Width, 50 * 4);
            }

            foreach (Milestone milestone in milestoneList)
            {
                Button mileStoneBtn = new Button();
                mileStoneBtn.FlatStyle = FlatStyle.Flat;
                mileStoneBtn.FlatAppearance.BorderSize = 0;
                mileStoneBtn.ForeColor = Color.FromArgb(201, 210, 217);
                mileStoneBtn.Text = milestone.MileStoneName;
                mileStoneBtn.Size = new Size(this.Width, 50);
                mileStoneBtn.Dock = DockStyle.Top;
                mileStoneBtn.Click += OnClickMilestoneBtn;
                this.Controls.Add(mileStoneBtn);
            }

            foreach(Button Iter in Controls)
            {
                Iter.BringToFront();
            }
        }

        private void OnClickMilestoneBtn(object sender, EventArgs e)
        {
            if(IsMilestoneAlreadyCompleted((sender as Button).Text))
            {
                MilestoneWarningForm form = new MilestoneWarningForm();
                form.WarningStatus += OnWarningStatus;
                form.Show();
            }
            else
            {
                MilestoneClick?.Invoke(sender as Button, e);
                this.Close();
            }
        }

        private void OnWarningStatus(object sender, bool e)
        {
            if (e)
            {
                MilestoneClick?.Invoke(sender, EventArgs.Empty);
                this.Close();
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
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
    }
}
