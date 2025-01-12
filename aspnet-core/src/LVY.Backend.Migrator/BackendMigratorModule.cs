using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LVY.Backend.Configuration;
using LVY.Backend.EntityFrameworkCore;
using LVY.Backend.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace LVY.Backend.Migrator;

[DependsOn(typeof(BackendEntityFrameworkModule))]
public class BackendMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public BackendMigratorModule(BackendEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(BackendMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            BackendConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(BackendMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
