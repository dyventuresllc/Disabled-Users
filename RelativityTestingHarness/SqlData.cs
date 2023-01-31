using NUnit.Framework;
using DisableUsers;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.IO;

namespace RelativityTestingHarness
{
    [TestFixture]
    public class SqlDataTest
    {

        [Test]
        public void NeverLoggedIn()
        {

            var config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();

            var connString = config.GetConnectionString("Relativity-EU");

            IDbConnection conn = new System.Data.SqlClient.SqlConnection(connString);

            var data = new GetSqlData(config);

            DataTable dt = data.UsersNotLoggedInTable();
            
            Assert.IsTrue(dt.Rows.Count > 1);
        }


        [Test]
        public void NoGroups()
        {
            var config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();

            var connString = config.GetConnectionString("Relativity-EU");

            IDbConnection conn = new System.Data.SqlClient.SqlConnection(connString);

            var data = new GetSqlData(config);

            DataTable dt = data.UsersWithNoGroupsTable();

            Assert.IsTrue(dt.Rows.Count > 1);
        }

        [Test]
        public void UsersOver()
        {
            var config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();

            var connString = config.GetConnectionString("Relativity-EU");

            IDbConnection conn = new System.Data.SqlClient.SqlConnection(connString);

            var data = new GetSqlData(config);

            DataTable dt = data.UsersOverTable();

            Assert.IsTrue(dt.Rows.Count > 1);
        }

    }
}