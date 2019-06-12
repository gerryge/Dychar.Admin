using System.Threading.Tasks;
using Abp.Application.Services;
using Dychar.Admin.Authorization.Accounts.Dto;

namespace Dychar.Admin.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
