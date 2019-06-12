using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dychar.Admin.Authorization.Roles;
using Dychar.Admin.Authorization.Users;
using Dychar.Admin.MultiTenancy;

namespace Dychar.Admin.EntityFrameworkCore
{
    public class AdminDbContext : AbpZeroDbContext<Tenant, Role, User, AdminDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AdminDbContext(DbContextOptions<AdminDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("Dc");
        }
    }
}
