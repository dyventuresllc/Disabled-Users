using System.Collections.Generic;

namespace DisableUsers
{
    public interface IUsersNoGroup
    {
       IEnumerable<UsersNoGroups> SelectAllUsersWithNoGroups();
    }

    public interface IUserOver
    {
        IEnumerable<UsersOver> SelectAllUsersOver(int numOfDays);
    }

    public interface IUsersNeverLogged
    {
        IEnumerable<UsersNeverLoggedIn> SelectAllUsersNeverLoggedIn(int numOfDays);
    }
    
}
