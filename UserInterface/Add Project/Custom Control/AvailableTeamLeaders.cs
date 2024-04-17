using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class AvailableTeamLeaders : UserControl, IDisposable
    {

        public delegate void EmployeeHandler(Employee employee);
        public event EmployeeHandler TeamLeaderClick;
        private List<Employee> teamLeaders;

        public AvailableTeamLeaders()
        {
            InitializeComponent();
        }

        public new void Dispose()
        {
            if (profilePanel.Controls != null)
            {
                for(int ctr=0; ctr<profilePanel.Controls.Count; ctr++)
                {
                    (profilePanel.Controls[ctr] as TeamLeaderPicAndName).Dispose();
                    profilePanel.Controls.Remove(profilePanel.Controls[ctr]);
                    ctr--;
                }
            }
        }

        public List<Employee> TeamLeaders
        {
            get
            {
                return teamLeaders;
            }

            set
            {
                teamLeaders = value;
                if (value != null && value.Count > 0)
                {
                    InitializeProfiles();
                }
            }
        }

        private void InitializeProfiles()
        {
            TeamLeaderPicAndName uc;
            foreach (var Iter in teamLeaders)
            {
                uc = new TeamLeaderPicAndName
                {
                    EmployeeProfile = Iter,
                    Dock = DockStyle.Top
                };
                uc.TeamLeaderClick += OnTeamLeaderClicked;
                profilePanel.Controls.Add(uc);
            }
        }

        private void OnTeamLeaderClicked(Employee teamLead)
        {
            TeamLeaderClick?.Invoke(teamLead);
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawLine(border, new Point(0,label1.Height), new Point(Width, label1.Height));
            border.Dispose();
        }
    }
}
