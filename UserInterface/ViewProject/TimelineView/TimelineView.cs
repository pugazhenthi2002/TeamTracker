﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;
using UserInterface.ViewProject.TimelineView.Controls;

namespace UserInterface.ViewProject.TimelineView
{
    public partial class TimelineView : UserControl
    {
        public List<Projects> ProjectCollection
        {
            set
            {
                if (value != null)
                {
                    projectCollection = value;
                    projectViewCount = value.Count >= 5 ? 5 : value.Count;
                    upEnable = false;
                    downEnable = value.Count > 5 ? true : false;
                    startIdx = 0;
                    endIdx = projectViewCount - 1;
                    InitializeProjectsForTimeline();
                }
            }
        }

        private bool upEnable, downEnable;
        private int startIdx, endIdx = 0, selectedIdx = 0;
        private VerticalLabel prevControl;
        private Projects currentProject;
        private ProjectVersion currentVersion;
        private List<VerticalLabel> projectViewControlCollection;
        private List<Projects> projectCollection;
        private int projectViewCount = 0;

        public TimelineView()
        {
            InitializeComponent();
        }

        private void InitializeProjectsForTimeline()
        {
            projectViewControlCollection = new List<VerticalLabel>();
            VerticalLabel control;
            for(int ctr=0; ctr<projectViewCount; ctr++)
            {
                foreach(var Iter in projectViewControlCollection)
                {
                    Iter.BringToFront();
                }

                control = new VerticalLabel()
                {
                    Dock = DockStyle.Top,
                    Height = 115,
                    Project = projectCollection[ctr]
                };
                if (ctr == 0)
                {
                    currentProject = projectCollection[ctr];
                    currentVersion = VersionManager.FetchProjectLatestVersion(projectCollection[ctr].ProjectID);
                    timelinePaginate1.Version = currentVersion;
                    versionNames.Text = currentVersion.VersionName;
                    prevControl = control;
                    control.TextColor = Color.Red;
                }
                control.ProjectSelected += OnProjectSelected;
                projectDisplayPanel.Controls.Add(control);
                projectViewControlCollection.Add(control);
            }
            foreach (var Iter in projectViewControlCollection)
            {
                Iter.BringToFront();
            }
        }

        private void projectDownClick(object sender, EventArgs e)
        {
            if(downEnable)
            {
                selectedIdx--;
                startIdx++;
                endIdx++;
                ProjectPaginate();
            }
        }

        private void VersionNamesClick(object sender, EventArgs e)
        {
            VersionViewForm form = new VersionViewForm();
            form.Location = Cursor.Position;
            form.VersionCollection = VersionManager.FetchAllVersionFromProjectID(currentProject.ProjectID);
            form.VersionSelected += OnVersionSelected;
            form.Show();
        }

        private void OnVersionSelected(object sender, ProjectVersion e)
        {
            timelinePaginate1.Version = currentVersion = e;
            versionNames.Text = currentVersion.VersionName;
        }

        private void projectUpClick(object sender, EventArgs e)
        {
            if (upEnable)
            {
                selectedIdx++;
                startIdx--;
                endIdx--;
                ProjectPaginate();
            }
        }

        private void OnProjectSelected(object sender, Projects e)
        {
            currentVersion = VersionManager.FetchProjectLatestVersion(e.ProjectID);
            timelinePaginate1.Version = currentVersion;
            versionNames.Text = currentVersion.VersionName;
            currentProject = (sender as VerticalLabel).Project;
            selectedIdx = projectViewControlCollection.IndexOf((sender as VerticalLabel));
            ProjectPaginate();
            prevControl = sender as VerticalLabel;
        }

        private void ProjectPaginate()
        {
            for (int ctr = startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
            {
                if(selectedIdx == idx)
                {
                    projectViewControlCollection[idx].IsClicked = true;
                }
                else
                {
                    projectViewControlCollection[idx].IsClicked = false;
                }
                projectViewControlCollection[idx].Project = projectCollection[ctr];
            }

            upEnable = startIdx == 0 ? false : true;
            downEnable = endIdx == projectCollection.Count - 1 ? false : true;
        }
    }
}
