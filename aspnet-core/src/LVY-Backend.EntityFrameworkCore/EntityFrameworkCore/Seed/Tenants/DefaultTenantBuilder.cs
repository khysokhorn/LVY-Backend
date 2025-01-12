using Abp.MultiTenancy;
using LVY-Backend.Editions;
using LVY-Backend.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LVY-Backend.EntityFrameworkCore.Seed.Tenants;

public class DefaultTenantBuilder
{
    private readonly LVY-BackendDbContext _context;

    public DefaultTenantBuilder(LVY-BackendDbContext context)
    {
        _context = context;
    }

    public void Create()
    {
        CreateDefaultTenant();
    }

    private void CreateDefaultTenant()
    {
        // Default tenant

        var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == AbpTenantBase.DefaultTenantName);
        if (defaultTenant == null)
        {
            defaultTenant = new Tenant(AbpTenantBase.DefaultTenantName, AbpTenantBase.DefaultTenantName);

            var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition != null)
            {
                defaultTenant.EditionId = defaultEdition.Id;
            }

            _context.Tenants.Add(defaultTenant);
            _context.SaveChanges();
        }
    }
}
