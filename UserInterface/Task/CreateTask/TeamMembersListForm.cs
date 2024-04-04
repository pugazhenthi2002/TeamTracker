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
using UserInterface.ViewProject;

namespace TeamTracker
{
    public partial class TeamMembersListForm : Form
    {
        public event EventHandler<Employee> EmployeeSelect;

        public TeamMembersListForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        public EventHandler<Employee> TeamMemberClick;
        private List<Employee> teamList = new List<Employee>();
        public List<Employee> TeamList
        {
            set
            {
                teamList = value;
                InitializeTeamMembers();
            }
        }

        private const int CSDropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
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
                this.Size = new Size(this.Width, 50 * (teamList.Count()));
            }
            else
            {
                this.Size = new Size(this.Width, 50 * 4);
            }

            EmployeeProfilePicAndName control;
            foreach (Employee emp in teamList)
            {
                control = new EmployeeProfilePicAndName()
                {
                    Profile = emp,
                    Dock = DockStyle.Top,
                    Height = 50,
                    NormalColor = Color.FromArgb(201, 210, 217),
                    HoverColor = Color.FromArgb(191, 200, 207)
                };
                control.EmployeeSelect += OnEmployeeSelect;
                Controls.Add(control);
            }
        }

        private void OnEmployeeSelect(object sender, Employee e)
        {
            TeamMemberClick?.Invoke(this, e);
            this.Close();
        }
    }
}
