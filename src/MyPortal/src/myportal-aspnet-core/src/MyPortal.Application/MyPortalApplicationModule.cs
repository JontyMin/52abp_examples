using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyPortal.Authorization;

namespace MyPortal
{
    [DependsOn(
        typeof(MyPortalCoreModule),
        typeof(AbpAutoMapperModule))]
    public class MyPortalApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyPortalAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyPortalApplicationModule).GetAssembly());


            var thisAssembly = typeof(MyPortalApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
