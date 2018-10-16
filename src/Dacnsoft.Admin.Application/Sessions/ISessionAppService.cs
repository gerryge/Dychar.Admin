using System.Threading.Tasks;
using Abp.Application.Services;
using Dacnsoft.Admin.Sessions.Dto;

namespace Dacnsoft.Admin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
