using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyPortal.MultiTenancy.Dto;

namespace MyPortal.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

