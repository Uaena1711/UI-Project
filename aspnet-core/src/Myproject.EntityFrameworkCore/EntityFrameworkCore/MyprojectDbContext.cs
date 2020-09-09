using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Myproject.Authorization.Roles;
using Myproject.Authorization.Users;
using Myproject.MultiTenancy;

namespace Myproject.EntityFrameworkCore
{
    public class MyprojectDbContext : AbpZeroDbContext<Tenant, Role, User, MyprojectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyprojectDbContext(DbContextOptions<MyprojectDbContext> options)
            : base(options)
        {
        }
    }
}
