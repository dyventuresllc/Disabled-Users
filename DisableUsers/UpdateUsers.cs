using Relativity.Identity.V1.Services;
using Relativity.Identity.V1.UserModels;
using System;
using System.Threading.Tasks;
using Relativity.API;

namespace DisableUsers
{
    public class UserHandler
    {
        IAPILog Logger { get; set; }
        internal IServicesMgr ServiceManager { get; set; }

        public UserHandler(IServicesMgr serviceManager, IAPILog logger)
        {
            ServiceManager= serviceManager;
            Logger= logger;
        }
              
        public async Task DisableUsers(int userArtifactId, string keyword, string notes)
        {
            using (IUserManager userManager = ServiceManager.CreateProxy<IUserManager>(ExecutionIdentity.System))
            {
                try
                {
                    UserResponse userResponse = await userManager.ReadAsync(userArtifactId);
                    UserRequest request = new UserRequest(userResponse);
                    request.RelativityAccess = false;
                    request.Keywords = keyword;//"Disabled by QE Automation";
                    request.Notes = notes; //"User had no active groups, account disabled";
                    UserResponse updateResponse = await userManager.UpdateAsync(userArtifactId, request);

                    object[] errors = null;
                    Logger.LogInformation("", errors);
                }
                catch (Exception ex)
                {
                    object[] errors = null;
                    Logger.LogError(ex.Message, errors);
                }
            }
        }
    }
}
