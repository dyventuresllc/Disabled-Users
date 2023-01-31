//using NUnit.Framework;
//using Relativity.Services.ServiceProxy;
//using System;
//using System.Threading.Tasks;
//using IWorkspaceManager = Relativity.Services.Interfaces.Workspace.IWorkspaceManager;
//using Relativity.API;
//using System.Net;
//using DisableUsers;
//using Relativity.Identity.V1.Services;
//using Relativity.Identity.V1.UserModels;
//using System.Linq;
//using Microsoft.Extensions.Configuration;
//using System.Data;
//using System.IO;
//using DisableUsers;

//namespace RelativityTestingHarness
//{
//    [TestFixture]
//    public class UnitTest1
//    {
//        //public IServiceHelper ServiceHelper { get; set; }
        
//        //public UnitTest1(IServiceHelper helper) 
//        //{
//        //    ServiceHelper = helper;            
//        //}


//        [Test]
//        public async Task QueryTest()
//        {
//            //Uri restUri = new Uri("https://qe-us-current-sandbox.relativity.one/relativity.rest/api");
//            Uri restUri = new Uri("https://qe-us.relativity.one/relativity.rest/api");
//            //Uri restUri = new Uri("https://VM-T041WEB001/Relativity.Rest/API/");
//            Credentials credentials = new UsernamePasswordCredentials("damienyoung@quinnemanuel.com", "C@Y8=%+XsP]U");
//            ServiceFactorySettings settings = new ServiceFactorySettings(restUri, credentials);
//            ServiceFactory factory = new ServiceFactory(settings);
 
//            using (IUserManager userManager = factory.CreateProxy<IUserManager>())
//            {
//                try
//                {

//                    WorkspaceUserData userlist = await userManager.RetrieveAllWithRelativityAccessAsync(-1);

//                    var dt = userlist.ActiveUsers.ToList();




//                    UserResponse uResponse = await userManager.ReadAsync(1033672);
//                    UserRequest request = new UserRequest(uResponse);
//                    request.RelativityAccess = false;
//                    request.Keywords = "Disabled by Policy";
//                    request.Notes = "User disabled for inactivity, partner permission not required for re-enablement";
//                    UserResponse updateResponse = await userManager.UpdateAsync(1033672, request);
//                }
//                catch (Exception ex)
//                {
//                    //catch this
//                }
//            }


//        }


//        [Test]
//        public void GetDataTest() 
//        {
//            //var x = new GetData();
//            //x.ListActiveUsersByLastLogin(ServiceHelper.GetDBContext(-1));
//        }


//        [Test]
//        public void DapperGetDataTest()
//        {

         

//            var config = new ConfigurationBuilder()
//                        .SetBasePath(Directory.GetCurrentDirectory())
//                        .AddJsonFile("appsettings.json")
//                        .Build();

//            var connString = config.GetConnectionString("Relativity-EU");

//            IDbConnection conn = new System.Data.SqlClient.SqlConnection(connString);

//            var x = new DapperUsersNeverLoggedIn(conn);
//            //var x = new DapperUsersWithNoGroups(conn);

//           // var y = x.GetAllUsersWithNoGroups();


//            //      //.SetBasePath(Directory.GetCurrentDirectory())
//            //      .AddJsonFile("appsettings.json")
//            //      .Build();

//            //var connString = config.GetConnectionString("DefaultConnection");

//        }


//        [Test]
//        public void UsersNeverLoggedIn()
//        {

//            var config = new ConfigurationBuilder()
//                        .SetBasePath(Directory.GetCurrentDirectory())
//                        .AddJsonFile("appsettings.json")
//                        .Build();

//            var connString = config.GetConnectionString("Relativity-EU");

//            IDbConnection conn = new System.Data.SqlClient.SqlConnection(connString);

//            var z = new GetSqlData(config);

            


//           //z.x();
//        }

//    }
//}