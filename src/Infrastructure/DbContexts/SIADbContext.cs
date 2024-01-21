using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Core.DotNet.Extensions.DbContext;
using Core.DotNet.Extensions.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SIAPolicyService.Infrastructure.DbContexts;

public class SIADbContext : DbContext
{
    public SIADbContext(DbContextOptions<SIADbContext> options) : base(options)
    {
        Debug.WriteLine("AuthenticationDbContext::ctor ->" + GetHashCode());
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new LogSystemEntityTypeConfiguration());
      
        modelBuilder.ApplyGlobalFiltersSoftDeleted();
        //modelBuilder.UseSnakeCaseNames(DatabaseType.SQLServer);
    }
}

[ExcludeFromCodeCoverage]
public class BPContextDesignFactory : IDesignTimeDbContextFactory<SIADbContext>
{
    public SIADbContext CreateDbContext(string[] args)
    {
        var connectionString = ConfigurationExtension
            .CreateConfigurationBuilder("API")
            .AddJsonFile($"appsettings.Development.json", true, true)
            .AddEnvironmentVariables()
            .Build()["SQLSERVER_CONNECTIONSTRING"];

        var dbContextOptions = new DbContextOptionsBuilder<SIADbContext>()
            .UseSqlServer(connectionString)
            .Options;

        return new SIADbContext(dbContextOptions);
    }
}