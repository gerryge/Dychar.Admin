using System.Threading.Tasks;
using Dacnsoft.Admin.Configuration.Dto;

namespace Dacnsoft.Admin.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
