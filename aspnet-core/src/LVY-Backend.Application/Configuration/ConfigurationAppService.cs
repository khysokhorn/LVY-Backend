using Abp.Authorization;
using Abp.Runtime.Session;
using LVY-Backend.Configuration.Dto;
using System.Threading.Tasks;

namespace LVY-Backend.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : LVY-BackendAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
