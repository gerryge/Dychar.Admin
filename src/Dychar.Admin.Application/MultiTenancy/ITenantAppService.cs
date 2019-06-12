using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dychar.Admin.MultiTenancy.Dto;

namespace Dychar.Admin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
