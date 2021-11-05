using System.Threading.Tasks;
using Abp.Application.Services;
using MyPortal.Sessions.Dto;

namespace MyPortal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
