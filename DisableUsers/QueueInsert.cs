using System;

namespace DisableUsers
{
    public class QueueTable
    {
        public QueueTable()
        {
        }
        public int UserArtifactID { get; set; }
        public DateTime DateLastActivity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime FirstNotificationDateSent { get; set; }
        public DateTime SecondNotificationDateSent { get; set; }
    }
}
