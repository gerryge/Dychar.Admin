using Abp.AutoMapper;
using Dacnsoft.Admin.Sessions.Dto;

namespace Dacnsoft.Admin.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
