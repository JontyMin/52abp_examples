using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyPortal.EntityFrameworkCore
{
    public static class MyPortalDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyPortalDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyPortalDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
