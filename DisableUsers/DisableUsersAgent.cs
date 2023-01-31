using Relativity.API;
using kCura.Agent;

namespace DisableUsers
{
    public class DisableUsersAgent : AgentBase
    {
       

        public override void Execute()
        {
            IDBContext eddsDbContext;
            eddsDbContext = Helper.GetDBContext(-1);

            //var x = new GetData();
            //x.ListActiveUsersByLastLogin(eddsDbContext);      
        }


        public override string Name
        {
            get 
            {
                return "DisabledUsersAgent";
            }
        }
    }
}
