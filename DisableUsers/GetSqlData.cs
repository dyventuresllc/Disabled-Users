using DisableUsers.Helpers;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace DisableUsers
{
    public class GetSqlData
    {
        private IConfigurationRoot _config;
        private IDbConnection conn;

        public GetSqlData(IConfigurationRoot config)
        {
            _config = config;
        }

        public GetSqlData(IDbConnection conn)
        {
            this.conn = conn;
        }

        public DataTable UsersNotLoggedInTable()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connString = config.GetConnectionString("Relativity-EU");
            
            IDbConnection conn = new SqlConnection(connString);

            using(conn)
            {
                var data = new DapperUsersNeverLoggedIn(conn);
                List<UsersNeverLoggedIn> usersNeverLoggedIn = data.SelectAllUsersNeverLoggedIn(7).ToList();
                return usersNeverLoggedIn.ToDataTable();
            }
        }

        public DataTable UsersWithNoGroupsTable()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connString = config.GetConnectionString("Relativity-EU");

            IDbConnection conn = new SqlConnection(connString);

            using (conn)
            {
                var data = new DapperUsersWithNoGroups(conn);
                List<UsersNoGroups> usersNoGroups = data.SelectAllUsersWithNoGroups().ToList();
                return usersNoGroups.ToDataTable();
            }

        }

        public DataTable UsersOverTable()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connString = config.GetConnectionString("Relativity-EU");

            IDbConnection conn = new SqlConnection(connString);

            using (conn)
            {
                var data = new DapperUsersOver(conn);
                List<UsersOver> usersNoGroups = data.SelectAllUsersOver(90).ToList();
                return usersNoGroups.ToDataTable();
            }
        }

        public void T()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connString = config.GetConnectionString("Relativity-EU");

            IDbConnection conn = new SqlConnection(connString);
            conn.ChangeDatabase("_DB1");


        }


    }
}
