using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LVY-Backend.Authorization;

namespace LVY-Backend;

[DependsOn(
    typeof(LVY-BackendCoreModule),
    typeof(AbpAutoMapperModule))]
public class LVY-BackendApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<LVY-BackendAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(LVY-BackendApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
