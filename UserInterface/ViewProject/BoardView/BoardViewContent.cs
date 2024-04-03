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
        public List<ProjectVersion> VersionCollection
        {
            set
            {
                versionCollection = value;
                SetStatusviseVersion();
            }
        }

        public BoardViewContent()
        {
            InitializeComponent();
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

            completedTemplate.VersionCollection = completedVersion;
            deploymentTemplate.VersionCollection = deploymentVersion;
            onProcessTemplate.VersionCollection = onProcessVerison;
            onStageTemplate.VersionCollection = onstageVersion;
            upcomingTemplates.VersionCollection = upcomingVersion;
        }
    }
}
