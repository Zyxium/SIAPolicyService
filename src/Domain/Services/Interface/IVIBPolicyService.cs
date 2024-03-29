using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;

namespace SIAPolicyService.Domain.Services.Interface;

public interface IVIBPolicyService
{
    Task<IssueTokenResponse> CreateVIBPolicyAsync(ValidateTokenRequest request);
}