using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTracker
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string NotificationHeader { get; set; }
        public string NotificationContent { get; set; }
        public int AssignedTo { get; set; }
        public DateTime NotificationDateTime { get; set; }
    }
}
