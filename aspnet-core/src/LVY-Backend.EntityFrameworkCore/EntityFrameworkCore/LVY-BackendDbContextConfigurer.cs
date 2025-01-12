using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace LVY-Backend.EntityFrameworkCore;

public static class LVY-BackendDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<LVY-BackendDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<LVY-BackendDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
