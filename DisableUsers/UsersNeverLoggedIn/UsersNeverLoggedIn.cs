using System;

namespace DisableUsers
{ 
    public class UsersNeverLoggedIn
    {
        public UsersNeverLoggedIn()
        {
        }
        public int ArtifactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedOn { get; set; }
        public int NumDaySinceAccountCreated { get; set; }
    }
}
