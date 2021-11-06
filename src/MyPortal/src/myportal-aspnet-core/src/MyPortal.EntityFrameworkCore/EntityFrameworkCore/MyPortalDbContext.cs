using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyPortal.Authorization.Roles;
using MyPortal.Authorization.Users;
using MyPortal.MultiTenancy;
using MyPortal.Students;

namespace MyPortal.EntityFrameworkCore
{
    public class MyPortalDbContext : AbpZeroDbContext<Tenant, Role, User, MyPortalDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Student> Students { get; set; }

        public MyPortalDbContext(DbContextOptions<MyPortalDbContext> options)
            : base(options)
        {
        }
    }
}
