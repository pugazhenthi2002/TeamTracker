using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.ViewProject.BoardView
{
    public partial class BoardViewContent : UserControl
    {
        private List<ProjectVersion> versionCollection;

        public BoardViewContent()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void InitializePageColor()
        {
            completedTemplate.BorderColor = ThemeManager.GetProjectStatusColor(ProjectStatus.Completed);
            deploymentTemplate.BorderColor = ThemeManager.GetProjectStatusColor(ProjectStatus.Deployment);
            onProcessTemplate.BorderColor = ThemeManager.GetProjectStatusColor(ProjectStatus.OnProcess);
            onStageTemplate.BorderColor = ThemeManager.GetProjectStatusColor(ProjectStatus.OnStage);
            upcomingTemplates.BorderColor = ThemeManager.GetProjectStatusColor(ProjectStatus.UpComing);
            completedTemplate.BackColor = deploymentTemplate.BackColor = onProcessTemplate.BackColor = onStageTemplate.BackColor = upcomingTemplates.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            ucNotFound1.BackColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        public List<ProjectVersion> VersionCollection
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    ucNotFound1.Visible = false;
                    tableLayoutPanel1.Visible = true;
                    versionCollection = value;
                    SetStatusviseVersion();
                }
                else
                {
                    ucNotFound1.Visible = true;
                    tableLayoutPanel1.Visible = false;
                }
            }
        }

        private void SetStatusviseVersion()
        {
            List<ProjectVersion> completedVersion = new List<ProjectVersion>();
            List<ProjectVersion> deploymentVersion = new List<ProjectVersion>();
            List<ProjectVersion> onProcessVerison = new List<ProjectVersion>();
            List<ProjectVersion> onstageVersion = new List<ProjectVersion>();
            List<ProjectVersion> upcomingVersion = new List<ProjectVersion>();

            foreach (var Iter in versionCollection)
            {
                switch (Iter.StatusOfVersion)
                {
                    case ProjectStatus.Completed: completedVersion.Add(Iter);   break;
                    case ProjectStatus.Deployment: deploymentVersion.Add(Iter); break;
                    case ProjectStatus.OnProcess: onProcessVerison.Add(Iter); break;
                    case ProjectStatus.OnStage: onstageVersion.Add(Iter); break;
                    case ProjectStatus.UpComing: upcomingVersion.Add(Iter); break;
                }
            }

            completedVersion.Sort((c1, c2) => c2.EndDate.CompareTo(c1.EndDate));
            deploymentVersion.Sort((d1, d2) => d2.EndDate.CompareTo(d1.EndDate));
            onProcessVerison.Sort((o1, o2) => o2.EndDate.CompareTo(o1.EndDate));
            onstageVersion.Sort((o1, o2) => o2.EndDate.CompareTo(o1.EndDate));
            upcomingVersion.Sort((u1, u2) => u2.EndDate.CompareTo(u1.EndDate));

            completedTemplate.VersionCollection = completedVersion;
            deploymentTemplate.VersionCollection = deploymentVersion;
            onProcessTemplate.VersionCollection = onProcessVerison;
            onStageTemplate.VersionCollection = onstageVersion;
            upcomingTemplates.VersionCollection = upcomingVersion;
        }

        private void statusViewTemplate1_Load(object sender, EventArgs e)
        {

        }
    }
}
