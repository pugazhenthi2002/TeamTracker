using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public enum EditMode
    {
        Task,
        Version
    }
    public class Edit
    {
        public int EditID { get; set; }
        public int EditModeID { get; set; }
        public EditMode ModeOfEdit { get; set; }
    }
}
