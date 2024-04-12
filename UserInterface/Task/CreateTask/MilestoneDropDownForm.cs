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
                milestoneList = value;
                InitializeMilestones();
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
            this.Size = new Size(this.Width, 40 * (milestoneList.Count()));

            foreach(Milestone milestone in milestoneList)
            {
                Button mileStoneBtn = new Button();
                mileStoneBtn.FlatStyle = FlatStyle.Flat;
                mileStoneBtn.FlatAppearance.BorderSize = 0;
                mileStoneBtn.ForeColor = Color.FromArgb(201, 210, 217);
                mileStoneBtn.Text = milestone.MileStoneName;
                mileStoneBtn.Size = new Size(this.Width, 40);
                mileStoneBtn.Dock = DockStyle.Top;

                mileStoneBtn.Click += OnClickMilestoneBtn;
            }
        }

        private void OnClickMilestoneBtn(object sender, EventArgs e)
        {
            MilestoneClick?.Invoke(sender, e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }
    }
}
