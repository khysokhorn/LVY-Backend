using Abp.Zero.EntityFrameworkCore;
using LVY.Backend.Authorization.Roles;
using LVY.Backend.Authorization.Users;
using LVY.Backend.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace LVY.Backend.EntityFrameworkCore;

public class BackendDbContext : AbpZeroDbContext<Tenant, Role, User, BackendDbContext>
{
    /* Define a DbSet for each entity of the application */

    public BackendDbContext(DbContextOptions<BackendDbContext> options)
        : base(options)
    {
    }
}
