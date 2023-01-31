using Dapper;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace DisableUsers
{
    public class DapperUsersWithNoGroups : IUsersNoGroup
    {
        private readonly IDbConnection _conn;

        public DapperUsersWithNoGroups(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<UsersNoGroups> SelectAllUsersWithNoGroups()
        {
            string script = File.ReadAllText(@"D:\CSharp\DY\Relativity\DisableUsers\SQL\UsersWithNoGroups.sql");
            return _conn.Query<UsersNoGroups>(script);
        }
    }

    public class DapperUsersOver : IUserOver
    {
        private readonly IDbConnection _conn;

        public DapperUsersOver(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<UsersOver> SelectAllUsersOver(int numOfDays)
        {
            var param = new { NumOfDays = numOfDays };
            string script = File.ReadAllText(@"D:\CSharp\DY\Relativity\DisableUsers\SQL\UsersOverX.sql");
            return _conn.Query<UsersOver>(script, param);
        }
    }

    public class DapperUsersNeverLoggedIn: IUsersNeverLogged
    {
       private readonly IDbConnection _conn;

        public DapperUsersNeverLoggedIn(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<UsersNeverLoggedIn> SelectAllUsersNeverLoggedIn(int numOfDays) 
        {            
            var param = new { NumofDays = numOfDays };
            string script = File.ReadAllText(@"D:\CSharp\DY\Relativity\DisableUsers\SQL\UsersNeverLoggedIn.sql");
            return _conn.Query<UsersNeverLoggedIn>(script,param);
        }
    }
}
