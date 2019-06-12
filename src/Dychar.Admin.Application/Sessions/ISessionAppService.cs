using System.Threading.Tasks;
using Abp.Application.Services;
using Dychar.Admin.Sessions.Dto;

namespace Dychar.Admin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
