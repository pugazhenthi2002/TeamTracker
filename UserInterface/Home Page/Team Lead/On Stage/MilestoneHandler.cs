using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Home_Page.Team_Lead.On_Stage
{
    public enum MilestoneOperation
    {
        Steady,
        Up,
        Down,
        Delete
    }

    public class MilestoneEventArgs
    {
        public int Position { get; set; }
        public string MilestoneName { get; set; }
        public DateTime MilestoneDate { get; set; }
        public MilestoneOperation Movement { get; set; }
    }
}
