using Abp.Zero.EntityFrameworkCore;
using LVY-Backend.Authorization.Roles;
using LVY-Backend.Authorization.Users;
using LVY-Backend.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace LVY-Backend.EntityFrameworkCore;

public class LVY-BackendDbContext : AbpZeroDbContext<Tenant, Role, User, LVY-BackendDbContext>
{
    /* Define a DbSet for each entity of the application */

    public LVY-BackendDbContext(DbContextOptions<LVY-BackendDbContext> options)
        : base(options)
    {
    }
}
