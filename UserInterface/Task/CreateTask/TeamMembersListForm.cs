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
    public partial class TeamMembersListForm : Form
    {
        public TeamMembersListForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }


        public EventHandler TeamMemberClick;
        private List<Employee> teamList = new List<Employee>();
        public List<Employee> TeamList
        {

            set
            {
                teamList = value;
                InitializeTeamMembers();
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void InitializeTeamMembers()
        {
            if (teamList.Count <= 4)
            {
                this.Size = new Size(this.Width, 40 * (teamList.Count()));
            }
            else
            {
                this.Size = new Size(this.Width, 40 * 4);
            }


            foreach(Employee emp in teamList)
            {
                Button member = new Button();
                member.FlatStyle = FlatStyle.Flat;
                member.FlatAppearance.BorderSize = 0;
                member.ForeColor = Color.FromArgb(201, 210, 217);
                member.Text = emp.EmployeeFirstName ;
                member.Size = new Size(this.Width, 40);
                member.Dock = DockStyle.Top;
                member.Click += OnClickMemberBtn;

            }
        }

        private void OnClickMemberBtn(object sender, EventArgs e)
        {
            TeamMemberClick?.Invoke(sender, e);
        }
    }
}
