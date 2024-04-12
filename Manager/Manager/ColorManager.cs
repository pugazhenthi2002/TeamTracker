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
        static ColorManager()
        {
            ColorFadingOut = new List<Color>()
            {
                Color.FromArgb(3, 4, 94), Color.FromArgb(5, 16, 101), Color.FromArgb(8, 26, 108), Color.FromArgb(12, 35, 115), Color.FromArgb(18, 44, 121),
                Color.FromArgb(23, 53, 127), Color.FromArgb(30, 62, 132), Color.FromArgb(37, 71, 138), Color.FromArgb(44, 80, 143), Color.FromArgb(52, 89, 148),
                Color.FromArgb(60, 98, 152), Color.FromArgb(69, 107, 157), Color.FromArgb(78, 116, 161), Color.FromArgb(88, 125, 165), Color.FromArgb(98, 133, 170),
                Color.FromArgb(109, 142, 174), Color.FromArgb(120, 151, 178), Color.FromArgb(132, 160, 182), Color.FromArgb(144, 168, 186), Color.FromArgb(156, 177, 191)
            };

            MilestoneColorFadingOut = new List<Color>()
            {
                Color.FromArgb(247, 37, 133), Color.FromArgb(181, 23, 158), Color.FromArgb(114, 9, 183), Color.FromArgb(86, 11, 173), Color.FromArgb(72, 12, 168),
                Color.FromArgb(3, 4, 94), Color.FromArgb(2, 62, 138), Color.FromArgb(58, 12, 163), Color.FromArgb(63, 55, 201), Color.FromArgb(67, 97, 238),
                Color.FromArgb(0, 119, 182), Color.FromArgb(0, 150, 199), Color.FromArgb(0, 180, 216), Color.FromArgb(72, 202, 228), Color.FromArgb(72, 149, 239),
                Color.FromArgb(76, 201, 240), Color.FromArgb(144, 224, 239), Color.FromArgb(173, 232, 244), Color.FromArgb(202, 240, 248), Color.FromArgb(157, 178, 191),
            };
        }

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
        public static List<Color> ColorFadingOut;
        public static List<Color> MilestoneColorFadingOut;
    }
}
