using System.Threading.Tasks;
using Abp.Application.Services;
using MyPortal.Authorization.Accounts.Dto;

namespace MyPortal.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
