using LVY-Backend.Configuration;
using LVY-Backend.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LVY-Backend.EntityFrameworkCore;

/* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
public class LVY-BackendDbContextFactory : IDesignTimeDbContextFactory<LVY-BackendDbContext>
{
    public LVY-BackendDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<LVY-BackendDbContext>();

        /*
         You can provide an environmentName parameter to the AppConfigurations.Get method. 
         In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
         Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
         https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
         */
        var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

        LVY-BackendDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LVY-BackendConsts.ConnectionStringName));

        return new LVY-BackendDbContext(builder.Options);
    }
}
