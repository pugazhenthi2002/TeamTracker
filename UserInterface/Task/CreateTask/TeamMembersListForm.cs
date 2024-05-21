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
        public EventHandler<Employee> TeamMemberClick;
        private List<Employee> teamList = new List<Employee>();
        private const int CSDropShadow = 0x00020000;


        public TeamMembersListForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        public event EventHandler<Employee> EmployeeSelect;

        private int dropDownCount = 4;
        public int DropDownCount
        {
            get { return dropDownCount; }
            set { dropDownCount = value; }
        }

        public List<Employee> TeamList
        {
            set
            {
                if(value!=null)
                {
                    teamList = value;
                    InitializeTeamMembers();
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

        private void InitializeTeamMembers()
        {
            if (teamList.Count <= dropDownCount)
            {
                this.Size = new Size(this.Width, 50 * (teamList.Count()));
            }
            else
            {
                this.Size = new Size(this.Width, 50 * dropDownCount);
            }
            EmployeeProfilePicAndName control;
            int ctr = 0;
            foreach (Employee emp in teamList)
            {
                control = new EmployeeProfilePicAndName()
                {
                    Profile = emp,
                    Dock = DockStyle.Top,
                    Height = 50,
                    NormalColor = ThemeManager.CurrentTheme.SecondaryIII,
                    HoverColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryIII),
                    ForeColor = ThemeManager.CurrentTheme.PrimaryI
                };

                control.Focus();
                control.EmployeeSelect += OnEmployeeSelect;
                Controls.Add(control);
                ctr++;
            }

            foreach(Control Iter in Controls)
            {
                Iter.BringToFront();
            }

            Focus();
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
        }

        private void OnEmployeeSelect(object sender, Employee e)
        {
            var x = Focused;
            TeamMemberClick?.Invoke(this, e);
            this.Close();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Focus();
        }
    }
}
