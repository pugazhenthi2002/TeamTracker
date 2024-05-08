using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class IssueAttachment
    {
        public int IssueAttachmentID { get; set; }
        public int IssueID { get; set; }
        public string DisplayName { get; set; }
        public string IssueAttachmentName { get; set; }
        public string IssueAttachmentLocation { get; set; }
    }
}
