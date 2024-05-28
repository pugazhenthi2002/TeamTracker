using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class VersionAttachment
    {
        public int VersionID { get; set; }
        public string DisplayName { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentLocation { get; set; }
    }
}
