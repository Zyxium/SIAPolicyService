using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Core.DotNet.Domain.Services;
using Core.DotNet.Infrastructure;
using Microsoft.EntityFrameworkCore;
using SIAPolicyService.Domain.AggregatesModel.SIAPolicyAggregate.Interface;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate.Interface;
using SIAPolicyService.Domain.Services;
using SIAPolicyService.Domain.Services.Interface;
using SIAPolicyService.Infrastructure.Configurations;
using SIAPolicyService.Infrastructure.DbContexts;
using SIAPolicyService.Infrastructure.Extensions;
using SIAPolicyService.Infrastructure.Repositories;

namespace SIAPolicyService.API.Extensions;

[ExcludeFromCodeCoverage]
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCustomConfigurations(this IServiceCollection services, EnvironmentOptions options)
    {   
        services.AddCustomDbContext(options.SQLSERVER_CONNECTIONSTRING);
        services.AddScoped<DbContext>(m => m.GetService<SIADbContext>());
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddCustomHttpClients(options);

        #region Repositories
        
        services.AddScoped<IVIBPolicyRepository, VIBPolicyRepository>(m => new VIBPolicyRepository(
            m.GetService<IHttpClientFactory>(),
            m.GetService<IHttpContextAccessor>(),
            options));
        
        services.AddScoped<Itb_agentRepository, tb_agentRepository>();
        
        
        
        #endregion

        #region Services
        
       // services.AddTransient<ICacheService, CacheService>();
        services.AddTransient<IVIBPolicyService, VIBPolicyService>(m => new VIBPolicyService(
            m.GetService<IUnitOfWork>(),
            m.GetService<IHttpContextAccessor>(),
            m.GetService<IVIBPolicyRepository>(),
            m.GetService<Itb_agentRepository>(),
            options.VIRIYAH_CLIENT_ID));
        
        #endregion

        return services;
    }

    public static IServiceCollection AddCustomDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContextPool<SIADbContext>(options =>
        {
             options.UseSqlServer(connectionString,
                 sqlOptions =>
                 {
                     sqlOptions.MigrationsAssembly(typeof(SIADbContext).GetTypeInfo().Assembly.GetName().Name);
                     sqlOptions.EnableRetryOnFailure(10, TimeSpan.FromMinutes(10), null);
                 });
        });

        return services;
    }
}