using System.Threading.Tasks;
using Dychar.Admin.Configuration.Dto;

namespace Dychar.Admin.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
