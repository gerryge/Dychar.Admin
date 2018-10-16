using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dacnsoft.Admin.Configuration.Dto;

namespace Dacnsoft.Admin.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AdminAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
