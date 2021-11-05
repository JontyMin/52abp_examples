using System.Threading.Tasks;
using MyPortal.Configuration.Dto;

namespace MyPortal.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
