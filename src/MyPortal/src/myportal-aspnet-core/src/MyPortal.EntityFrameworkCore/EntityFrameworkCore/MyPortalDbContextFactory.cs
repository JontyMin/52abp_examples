using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyPortal.Configuration;
using MyPortal.Web;

namespace MyPortal.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyPortalDbContextFactory : IDesignTimeDbContextFactory<MyPortalDbContext>
    {
        public MyPortalDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyPortalDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyPortalDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyPortalConsts.ConnectionStringName));

            return new MyPortalDbContext(builder.Options);
        }
    }
}
