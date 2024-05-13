using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public enum ThemeMode
    {
        Cold,
        Heat
    }

    public static class ThemeManager
    {
        static public ColorPalattes CurrentTheme{ get; set; }
        static public ThemeMode CurrentThemeMode{ get; set; }

        static ThemeManager()
        {
            themes = new List<ColorPalattes>();
            themes.Add(new ColorPalattes()
            {
                PalatteModeName = ThemeMode.Cold,
                PrimaryI = ColorTranslator.FromHtml("#194a7a"),
                PrimaryII = ColorTranslator.FromHtml("#3c668e"),
                PrimaryIII = ColorTranslator.FromHtml("#567694"),
                SecondaryI = ColorTranslator.FromHtml("#7593af"),
                SecondaryII = ColorTranslator.FromHtml("#a3b7ca"),
                SecondaryIII = ColorTranslator.FromHtml("#d1dbe4"),
                MilestoneFadingOutColorCollection = new List<Color>()
                {
                    ColorTranslator.FromHtml("#03045e"),
                    ColorTranslator.FromHtml("#262d79"),
                    ColorTranslator.FromHtml("#475492"),
                    ColorTranslator.FromHtml("#677bab"),
                    ColorTranslator.FromHtml("#88a2c4"),
                    ColorTranslator.FromHtml("#a9c9dd"),
                    ColorTranslator.FromHtml("#caf0f6"),
                    ColorTranslator.FromHtml("#e5f8fb")
                },
                MilestoneStatusColorCollection = new Dictionary<MilestoneStatus, Color>()
                {
                    { MilestoneStatus.Completed,  ColorTranslator.FromHtml("#03045E")},
                    { MilestoneStatus.OnProcess,  ColorTranslator.FromHtml("#023E8A")},
                    { MilestoneStatus.Upcoming,  ColorTranslator.FromHtml("#0077B6")},
                    { MilestoneStatus.Delay,  ColorTranslator.FromHtml("#00B4D8")}
                },
                TaskStatusColorCollection = new Dictionary<TaskStatus, Color>()
                {
                    {TaskStatus.NotYetStarted, ColorTranslator.FromHtml("#03045E") },
                    {TaskStatus.OnProcess, ColorTranslator.FromHtml("#023E8A") },
                    {TaskStatus.Stuck, ColorTranslator.FromHtml("#0077B6") },
                    {TaskStatus.UnderReview, ColorTranslator.FromHtml("#00B4D8") },
                    {TaskStatus.Done, ColorTranslator.FromHtml("#48CAE4") },
                },
                VersionStatusColorCollection = new Dictionary<ProjectStatus, Color>()
                {
                    {ProjectStatus.Completed, ColorTranslator.FromHtml("#03045E") },
                    {ProjectStatus.Deployment, ColorTranslator.FromHtml("#023E8A") },
                    {ProjectStatus.OnProcess, ColorTranslator.FromHtml("#0077B6") },
                    {ProjectStatus.OnStage, ColorTranslator.FromHtml("#00B4D8") },
                    {ProjectStatus.UpComing, ColorTranslator.FromHtml("#48CAE4") },
                },
                TaskPriorityColorCollection = new Dictionary<Priority, Color>()
                {
                    {Priority.Critical, ColorTranslator.FromHtml("#0A2647") },
                    {Priority.Hard, ColorTranslator.FromHtml("#144272") },
                    {Priority.Medium, ColorTranslator.FromHtml("#205295") },
                    {Priority.Easy, ColorTranslator.FromHtml("#2C74B3") }
                }
            });
            themes.Add(new ColorPalattes()
            {
                PalatteModeName = ThemeMode.Heat,
                PrimaryI = ColorTranslator.FromHtml("#CC5803"),
                PrimaryII = ColorTranslator.FromHtml("#d76510"),
                PrimaryIII = ColorTranslator.FromHtml("#ed8a26"),
                SecondaryI = ColorTranslator.FromHtml("#FF9505"),
                SecondaryII = ColorTranslator.FromHtml("#ffbd42"),
                SecondaryIII = ColorTranslator.FromHtml("#fcc874"),
                MilestoneFadingOutColorCollection = new List<Color>()
                {
                    ColorTranslator.FromHtml("#bd0000"),
                    ColorTranslator.FromHtml("#ce3b00"),
                    ColorTranslator.FromHtml("#d65800"),
                    ColorTranslator.FromHtml("#de7500"),
                    ColorTranslator.FromHtml("#e79300"),
                    ColorTranslator.FromHtml("#efb000"),
                    ColorTranslator.FromHtml("#f7cd00"),
                    ColorTranslator.FromHtml("#ffea00")
                },
                MilestoneStatusColorCollection = new Dictionary<MilestoneStatus, Color>()
                {
                    { MilestoneStatus.Completed,  ColorTranslator.FromHtml("#bd0000")},
                    { MilestoneStatus.OnProcess,  ColorTranslator.FromHtml("#d65800")},
                    { MilestoneStatus.Upcoming,  ColorTranslator.FromHtml("#e79300")},
                    { MilestoneStatus.Delay,  ColorTranslator.FromHtml("#f7cd00")}
                },
                TaskStatusColorCollection = new Dictionary<TaskStatus, Color>()
                {
                    {TaskStatus.NotYetStarted, ColorTranslator.FromHtml("#bd0000") },
                    {TaskStatus.OnProcess, ColorTranslator.FromHtml("#d65800") },
                    {TaskStatus.Stuck, ColorTranslator.FromHtml("#e79300") },
                    {TaskStatus.UnderReview, ColorTranslator.FromHtml("#f7cd00") },
                    {TaskStatus.Done, ColorTranslator.FromHtml("#CC5803") },
                },
                VersionStatusColorCollection = new Dictionary<ProjectStatus, Color>()
                {
                    {ProjectStatus.Completed, ColorTranslator.FromHtml("#bd0000") },
                    {ProjectStatus.Deployment, ColorTranslator.FromHtml("#d65800") },
                    {ProjectStatus.OnProcess, ColorTranslator.FromHtml("#e79300") },
                    {ProjectStatus.OnStage, ColorTranslator.FromHtml("#f7cd00") },
                    {ProjectStatus.UpComing, ColorTranslator.FromHtml("#CC5803") },
                },
                TaskPriorityColorCollection = new Dictionary<Priority, Color>()
                {
                    
                    {Priority.Critical, ColorTranslator.FromHtml("#E77728") },
                    {Priority.Hard, ColorTranslator.FromHtml("#EDB230") },
                    {Priority.Medium, ColorTranslator.FromHtml("#FFD151") },
                    {Priority.Easy, ColorTranslator.FromHtml("#FFDDA1") }
                }
            });

            CurrentTheme = themes[0];
            CurrentThemeMode = ThemeMode.Cold;
        }

        static public Color GetHoverColor(Color color)
        {
            int R, G, B;
            if (GetBrightness(color))
            {
                R = color.R + 15 <= 0 ? 0 : color.R + 15;
                G = color.G + 15 <= 0 ? 0 : color.G + 15;
                B = color.B + 15 <= 0 ? 0 : color.B + 15;
            }
            else
            {
                R = color.R - 15 <= 0 ? 0 : color.R - 15;
                G = color.G - 15 <= 0 ? 0 : color.G - 15;
                B = color.B - 15 <= 0 ? 0 : color.B - 15;
            }

            return Color.FromArgb(R, G, B);
        }

        static public bool GetBrightness(Color color)
        {
            float brightness = color.GetBrightness();
            const float darkThreshold = 0.5f;
            // If the brightness is less than the threshold, it's a dark color
            return brightness <= darkThreshold;
        }

        static public Color GetTextColor(Color color)
        {
            return GetBrightness(color) ? CurrentTheme.SecondaryIII : CurrentTheme.PrimaryI;
        }

        static public Color GetMilestoneStatusColor(MilestoneStatus status)
        {
            return CurrentTheme.MilestoneStatusColorCollection[status];
        }

        static private List<ColorPalattes> themes;
    }
}
