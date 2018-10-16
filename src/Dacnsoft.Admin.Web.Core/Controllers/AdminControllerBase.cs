using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Dacnsoft.Admin.Controllers
{
    public abstract class AdminControllerBase: AbpController
    {
        protected AdminControllerBase()
        {
            LocalizationSourceName = AdminConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
