using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class LatestUpgradedVersion : UserControl
    {
        public ProjectVersion LatestVersion
        {
            set
            {
                if (value != null)
                {
                    versionName.Text = value.VersionName;
                    startDateLabel.Text = value.StartDate.ToShortDateString();
                    endDateLabel.Text = value.EndDate.ToShortDateString();
                    clientEmailLabel.Text = value.ClientEmail;
                    taskCountLabel.Text = TaskManager.FetchTaskCount(value.VersionID).ToString();
                    descriptionLabel.Text = value.VersionDescription;
                }
            }
        }

        public LatestUpgradedVersion()
        {
            InitializeComponent();
        }
    }
}
