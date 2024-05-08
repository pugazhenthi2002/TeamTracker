using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public enum ProjectStatus
    {
        UpComing,
        OnStage,
        OnProcess,
        Deployment,
        Completed
    }

    public class ProjectVersion
    {
        public int VersionID { get; set; }
        public string VersionName {  get; set; }
        public string VersionDescription { get; set; }
        public int ProjectID { get; set; }
        public string ClientEmail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus StatusOfVersion { get; set; }
        public bool IsDelayed { get; set; }
    }
}
