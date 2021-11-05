using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyPortal.Controllers
{
    public abstract class MyPortalControllerBase: AbpController
    {
        protected MyPortalControllerBase()
        {
            LocalizationSourceName = MyPortalConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
