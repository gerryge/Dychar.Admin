using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dacnsoft.Admin.MultiTenancy.Dto;

namespace Dacnsoft.Admin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
