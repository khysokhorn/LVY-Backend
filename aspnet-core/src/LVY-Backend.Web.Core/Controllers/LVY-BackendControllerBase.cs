using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LVY-Backend.Controllers
{
    public abstract class LVY-BackendControllerBase : AbpController
    {
        protected LVY-BackendControllerBase()
        {
            LocalizationSourceName = LVY-BackendConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
