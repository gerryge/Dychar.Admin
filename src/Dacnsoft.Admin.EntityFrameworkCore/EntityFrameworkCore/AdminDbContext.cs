using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dacnsoft.Admin.Authorization.Roles;
using Dacnsoft.Admin.Authorization.Users;
using Dacnsoft.Admin.MultiTenancy;

namespace Dacnsoft.Admin.EntityFrameworkCore
{
    public class AdminDbContext : AbpZeroDbContext<Tenant, Role, User, AdminDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AdminDbContext(DbContextOptions<AdminDbContext> options)
            : base(options)
        {
        }
    }
}
