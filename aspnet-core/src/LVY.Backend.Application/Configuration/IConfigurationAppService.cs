using LVY.Backend.Configuration.Dto;
using System.Threading.Tasks;

namespace LVY.Backend.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
