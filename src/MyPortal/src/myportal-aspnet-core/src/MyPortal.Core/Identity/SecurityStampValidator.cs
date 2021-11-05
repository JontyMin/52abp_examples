using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Abp.Domain.Uow;
using MyPortal.Authorization.Roles;
using MyPortal.Authorization.Users;
using MyPortal.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace MyPortal.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(IOptions<SecurityStampValidatorOptions> options, AbpSignInManager<Tenant, Role, User> signInManager, ISystemClock systemClock, ILoggerFactory loggerFactory, IUnitOfWorkManager unitOfWorkManager) : base(options, signInManager, systemClock, loggerFactory, unitOfWorkManager)
        {
        }
    }
}
