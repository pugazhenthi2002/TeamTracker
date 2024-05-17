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
        public AvailableTeamLeaders()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        public void InitializePageColor()
        {
            label1.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
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
            label1?.Dispose();
        }

        public void ClearAllEmployees()
        {
            for (int ctr = 0; ctr < profilePanel.Controls.Count; ctr++)
            {
                //(profilePanel.Controls[ctr] as TeamLeaderPicAndName).TeamLeaderClick -= OnTeamLeaderClicked;
                (profilePanel.Controls[ctr] as TeamLeaderPicAndName).Dispose();
                profilePanel.Controls.Remove(profilePanel.Controls[ctr]);
                ctr--;
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
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(0,label1.Height), new Point(Width, label1.Height));
            border.Dispose();
        }

        private List<Employee> teamLeaders;
    }
}
