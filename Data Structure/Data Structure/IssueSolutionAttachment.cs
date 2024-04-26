using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class IssueSolutionAttachment
    {
        public int IssueSolnAttachmentID { get; set; }
        public int IssueSolutionID { get; set; }
        public string DisplayName { get; set; }
        public string IssueSolnAttachmentName { get; set; }
        public string IssueSolnAttachmentLocation { get; set; }
    }
}
