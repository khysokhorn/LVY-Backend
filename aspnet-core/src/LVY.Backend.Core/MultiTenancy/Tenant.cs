using Abp.MultiTenancy;
using LVY.Backend.Authorization.Users;

namespace LVY.Backend.MultiTenancy;

public class Tenant : AbpTenant<User>
{
    public Tenant()
    {
    }

    public Tenant(string tenancyName, string name)
        : base(tenancyName, name)
    {
    }
}
