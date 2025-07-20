using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Northwind.DataContext.SqlServer;


namespace Northwind.DataContext.SqlServer;


public static class NorthwindContextExtensions
{
  public static IServiceCollection AddNorthwindContext(
    this IServiceCollection services,
    string? connectionString = null)
  {
    if (connectionString is null)
    {
      SqlConnectionStringBuilder builder = new();

      builder.DataSource = ".";
      builder.InitialCatalog = "NORTHWND";
      builder.TrustServerCertificate = true;
      builder.MultipleActiveResultSets = true;
      builder.ConnectTimeout = 3;
      builder.IntegratedSecurity = true;

      connectionString = builder.ConnectionString;
    }

    services.AddDbContext<NorthwindContext>(options =>
    {
      options.UseSqlServer(connectionString);
      options.LogTo(NorthwindContextLogger.WriteLine,
        new[] { Microsoft.EntityFrameworkCore
          .Diagnostics.RelationalEventId.CommandExecuting });
    },
    contextLifetime: ServiceLifetime.Transient,
    optionsLifetime: ServiceLifetime.Transient);

    return services;
  }
}
