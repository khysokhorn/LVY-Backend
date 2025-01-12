using Abp.Modules;
using Abp.Reflection.Extensions;
using LVY-Backend.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace LVY-Backend.Web.Host.Startup
{
    [DependsOn(
       typeof(LVY-BackendWebCoreModule))]
    public class LVY-BackendWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LVY-BackendWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LVY-BackendWebHostModule).GetAssembly());
        }
    }
}
