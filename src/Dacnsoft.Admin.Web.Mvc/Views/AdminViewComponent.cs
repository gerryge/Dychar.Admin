using Abp.AspNetCore.Mvc.ViewComponents;

namespace Dacnsoft.Admin.Web.Views
{
    public abstract class AdminViewComponent : AbpViewComponent
    {
        protected AdminViewComponent()
        {
            LocalizationSourceName = AdminConsts.LocalizationSourceName;
        }
    }
}
