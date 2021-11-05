using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.EntityHistory;
using Abp.Localization;
using Abp.Organizations;
using Abp.UI.Inputs;
using AutoMapper;
using MyPortal.Authorization.Roles;
using MyPortal.Authorization.Users;
using MyPortal.MultiTenancy;
using MyPortal.Roles.Dto;
using MyPortal.Sessions.Dto;

namespace MyPortal.CustomDtoAutoMapper
{
    /// <summary>
    ///     配置自定义的 的AutoMapper
    /// </summary>
    public static  class CustomerAppDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //Role
            configuration.CreateMap<RoleEditDto, Role>().ReverseMap();
            configuration.CreateMap<Role, RoleListDto>();
           // configuration.CreateMap<UserRole, UserListRoleDto>();
            //User
                  configuration.CreateMap<User, UserLoginInfoDto>();

            


        
         
        }
    }
}
