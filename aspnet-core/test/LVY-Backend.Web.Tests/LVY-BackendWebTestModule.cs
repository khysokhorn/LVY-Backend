using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LVY-Backend.EntityFrameworkCore;
using LVY-Backend.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LVY-Backend.Web.Tests;

[DependsOn(
    typeof(LVY-BackendWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class LVY-BackendWebTestModule : AbpModule
{
    public LVY-BackendWebTestModule(LVY-BackendEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(LVY-BackendWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(LVY-BackendWebMvcModule).Assembly);
    }
}