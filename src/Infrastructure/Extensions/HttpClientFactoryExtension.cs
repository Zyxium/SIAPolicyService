using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using SIAPolicyService.Infrastructure.Configurations;

namespace SIAPolicyService.Infrastructure.Extensions;

[ExcludeFromCodeCoverage]
public static class HttpClientFactoryExtension
{
    private const string ViriyahApiClient = "VIRIYAH_API";

    public static HttpClient CreateViriyahApiClient(this IHttpClientFactory httpClientFactory) => httpClientFactory.CreateClient(ViriyahApiClient);

    public static IServiceCollection AddCustomHttpClients(this IServiceCollection services, EnvironmentOptions options)
    {
        services.AddHttpClient(ViriyahApiClient, c => { c.BaseAddress = new Uri(options.VIRIYAH_API_ENDPOINT); });
        
        // services.AddHttpClient(NotificationApiClient, c => { c.BaseAddress = new Uri(options.NOTIFICATION_ENDPOINT); });
        //
        // services.AddHttpClient(ResourcesApiClient, c => { c.BaseAddress = new Uri(options.RESOURCE_API_ENDPOINT); });
        //
        // services.AddHttpClient(SearchApiClient, c => { c.BaseAddress = new Uri(options.SEARCH_API_ENDPOINT); });
        //
        return services;
    }
}