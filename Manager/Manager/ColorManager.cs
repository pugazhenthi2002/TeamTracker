using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public static class ColorManager
    {
        public static Color FetchTaskStatusColor(TaskStatus status)
        {
            switch (status)
            {
                case TaskStatus.Done: return Color.FromArgb(3, 4, 94);
                case TaskStatus.UnderReview: return Color.FromArgb(2, 62, 138);
                case TaskStatus.OnProcess: return Color.FromArgb(0, 119, 182);
                case TaskStatus.Stuck: return Color.FromArgb(0, 180, 216);
                default: return Color.FromArgb(72, 149, 239);
            }
        }
    }
}
