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
    public partial class AvailableTeamLeaders : UserControl
    {

        public delegate void EmployeeHandler(Employee employee);
        public event EmployeeHandler TeamLeaderClick;
        private List<Employee> teamLeaders;

        public AvailableTeamLeaders()
        {
            InitializeComponent();
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
            profilePanel.Controls.Clear();
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

    }
}
