using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyPortal.Configuration;

namespace MyPortal.Web.Startup
{
    [DependsOn(typeof(MyPortalWebCoreModule))]
    public class MyPortalWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyPortalWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<MyPortalNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyPortalWebMvcModule).GetAssembly());
        }
    }
}
