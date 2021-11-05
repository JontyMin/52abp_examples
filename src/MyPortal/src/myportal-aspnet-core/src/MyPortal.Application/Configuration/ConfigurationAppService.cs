using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyPortal.Configuration.Dto;

namespace MyPortal.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyPortalAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
