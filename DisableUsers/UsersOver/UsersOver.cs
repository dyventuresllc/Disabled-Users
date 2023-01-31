using System;

namespace DisableUsers
{ 
    public class UsersOver
    {
        public UsersOver()
        {
        }
        public int ArtifactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int DaySinceLastLogin { get; set; }
    }
}
