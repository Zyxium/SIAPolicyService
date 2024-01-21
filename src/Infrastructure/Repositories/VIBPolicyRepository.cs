using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using Core.DotNet.AggregatesModel.ExceptionAggregate;
using Core.DotNet.Extensions.Utilities;
using Microsoft.AspNetCore.Http;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate.Interface;
using SIAPolicyService.Infrastructure.Configurations;
using SIAPolicyService.Infrastructure.Extensions;

namespace SIAPolicyService.Infrastructure.Repositories;

public class VIBPolicyRepository : IVIBPolicyRepository
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly EnvironmentOptions _options;

    public VIBPolicyRepository(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, EnvironmentOptions options)
    {
        _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        _options = options ?? throw new ArgumentNullException(nameof(options));
    }
    
    public async Task<GenerateTokenResponse> GenerateTokenAsync()
    {
        var client = _httpClientFactory.CreateViriyahApiClient();
        client = client.SetGenerateToken(_options);
        
        var clientResult = await client.PostAsJsonAsync($"authen/token/v1/generate", "{}");
        var content = await clientResult.Content.ReadAsStringAsync();
        
        if ( !clientResult.IsSuccessStatusCode )
        {
            throw new CustomHttpBadRequestException("send_viriyah_validate", "failed", clientResult.ReasonPhrase);
        }
        
        var response = content.DeserializerObject<GenerateTokenResponse>();
        
        return response;
    }

    public async Task<ValidateTokenResponse> ValidateTokenAsync(ValidateTokenRequest request, string jwtToken)
    {
        var client = _httpClientFactory.CreateViriyahApiClient();
        client = client.SetValidateToken(_options, jwtToken);
        
        var clientResult = await client.PostAsJsonAsync($"policy/motor/cmi/v2/validate", request);
        var content = await clientResult.Content.ReadAsStringAsync();
        
        if ( !clientResult.IsSuccessStatusCode )
        {
            throw new CustomHttpBadRequestException("send_viriyah_validate", "failed", clientResult.ReasonPhrase);
        }
        
        var response = content.DeserializerObject<ValidateTokenResponse>();
        
        return response;
    }

    public async Task<IssueTokenResponse> IssueTokenAsync(IssueTokenRequest request, string jwtToken)
    {
        var client = _httpClientFactory.CreateViriyahApiClient();
        client = client.SetIssueToken(_options, jwtToken);
        
        var clientResult = await client.PostAsJsonAsync($"policy/motor/cmi/v2/issue", request);
        var content = await clientResult.Content.ReadAsStringAsync();
        
        if ( !clientResult.IsSuccessStatusCode )
        {
            throw new CustomHttpBadRequestException("send_viriyah_issue", "failed", clientResult.ReasonPhrase);
        }
        
        var response = content.DeserializerObject<IssueTokenResponse>();
        
        return response;
    }
}