using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class ColorPalattes
    {
        public ThemeMode PalatteModeName { get; set; }
        public Color PrimaryI { get; set; }
        public Color PrimaryII { get; set; }
        public Color PrimaryIII { get; set; }
        public Color SecondaryI { get; set; }
        public Color SecondaryII { get; set; }
        public Color SecondaryIII { get; set; }

        public List<Color> MilestoneFadingOutColorCollection { get; set; }
        public Dictionary<MilestoneStatus, Color> MilestoneStatusColorCollection { get; set; }
        public Dictionary<TaskStatus, Color> TaskStatusColorCollection { get; set; }
        public Dictionary<Priority, Color> TaskPriorityColorCollection { get; set; }
        public Dictionary<ProjectStatus, Color> VersionStatusColorCollection { get; set; }
    }
}
