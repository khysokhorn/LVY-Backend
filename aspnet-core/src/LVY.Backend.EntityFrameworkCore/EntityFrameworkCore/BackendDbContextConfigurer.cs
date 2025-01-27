using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace LVY.Backend.EntityFrameworkCore;

public static class BackendDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<BackendDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<BackendDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
