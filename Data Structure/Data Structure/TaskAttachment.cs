using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class TaskAttachment
    {
        public int TaskAttachmentID { get; set; }
        public int TaskID { get; set; }
        public string DisplayName { get; set; }
        public string TaskAttachmentName { get; set; }
        public string TaskAttachmentLocation { get; set; }
    }
}
