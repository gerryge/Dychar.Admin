using System.Threading.Tasks;
using Abp.Application.Services;
using Dacnsoft.Admin.Authorization.Accounts.Dto;

namespace Dacnsoft.Admin.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
