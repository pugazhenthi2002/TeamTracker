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
        static public event EventHandler ThemeChange;

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
                PrimaryI = ColorTranslator.FromHtml("#933A09"),
                PrimaryII = ColorTranslator.FromHtml("#B85B1A"),
                PrimaryIII = ColorTranslator.FromHtml("#E1934D"),
                SecondaryI = ColorTranslator.FromHtml("#F6C286"),
                SecondaryII = ColorTranslator.FromHtml("#FEE4BE"),
                SecondaryIII = Color.FromArgb(255, 251, 252),
                MilestoneFadingOutColorCollection = new List<Color>()
                {
                    ColorTranslator.FromHtml("#4b1200"),
                    ColorTranslator.FromHtml("#6f2302"),
                    ColorTranslator.FromHtml("#933A09"),
                    ColorTranslator.FromHtml("#934a26"),
                    ColorTranslator.FromHtml("#a56e54"),
                    ColorTranslator.FromHtml("#b79181"),
                    ColorTranslator.FromHtml("#d2bbb1"),
                    ColorTranslator.FromHtml("#ede4e0")
                },
                MilestoneStatusColorCollection = new Dictionary<MilestoneStatus, Color>()
                {
                    { MilestoneStatus.Completed,  ColorTranslator.FromHtml("#4b1200")},
                    { MilestoneStatus.OnProcess,  ColorTranslator.FromHtml("#933A09")},
                    { MilestoneStatus.Upcoming,  ColorTranslator.FromHtml("#a56e54")},
                    { MilestoneStatus.Delay,  ColorTranslator.FromHtml("#d2bbb1")}
                },
                TaskStatusColorCollection = new Dictionary<TaskStatus, Color>()
                {
                    {TaskStatus.NotYetStarted, ColorTranslator.FromHtml("#4B1200") },
                    {TaskStatus.OnProcess, ColorTranslator.FromHtml("#933A09") },
                    {TaskStatus.Stuck, ColorTranslator.FromHtml("#B85B1A") },
                    {TaskStatus.UnderReview, ColorTranslator.FromHtml("#F6C286") },
                    {TaskStatus.Done, ColorTranslator.FromHtml("#6F2302") },
                },
                VersionStatusColorCollection = new Dictionary<ProjectStatus, Color>()
                {
                    {ProjectStatus.Completed, ColorTranslator.FromHtml("#4b1200") },
                    {ProjectStatus.Deployment, ColorTranslator.FromHtml("#6f2302") },
                    {ProjectStatus.OnProcess, ColorTranslator.FromHtml("#933A09") },
                    {ProjectStatus.OnStage, ColorTranslator.FromHtml("#a56e54") },
                    {ProjectStatus.UpComing, ColorTranslator.FromHtml("#b79181") },
                },
                TaskPriorityColorCollection = new Dictionary<Priority, Color>()
                {
                    {Priority.Critical, ColorTranslator.FromHtml("#4b1200") },
                    {Priority.Hard, ColorTranslator.FromHtml("#933A09") },
                    {Priority.Medium, ColorTranslator.FromHtml("#a56e54") },
                    {Priority.Easy, ColorTranslator.FromHtml("#d2bbb1") }
                }
            });

            CurrentTheme = themes[1];
            CurrentThemeMode = ThemeMode.Heat;
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

        static public Color GetTaskStatusColor(TaskStatus status)
        {
            return CurrentTheme.TaskStatusColorCollection[status];
        }

        static public Color GetTaskPriorityColor(Priority priority)
        {
            return CurrentTheme.TaskPriorityColorCollection[priority];
        }

        static public Color GetProjectStatusColor(ProjectStatus status)
        {
            return CurrentTheme.VersionStatusColorCollection[status];
        }

        static public void OnThemeChanged()
        {
            CurrentThemeMode = CurrentThemeMode == ThemeMode.Cold ? ThemeMode.Heat : ThemeMode.Cold;
            ThemeChange?.Invoke(new object(), EventArgs.Empty);
        }

        static private List<ColorPalattes> themes;
    }
}
