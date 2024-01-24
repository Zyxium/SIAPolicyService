using SIAPolicyService.Domain.AggregatesModel.PartnerAggregate;

namespace SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate.Interface;

public interface IVIBPolicyRepository
{
    Task<GenerateTokenResponse> GenerateTokenAsync();
    Task<ValidateTokenResponse> ValidatePersonTokenAsync(ValidatePersonTokenRequest request, string jwtToken);
    Task<ValidateTokenResponse> ValidateCorporateTokenAsync(ValidateCorporateTokenRequest request, string jwtToken);
    Task<IssueTokenResponse> IssueTokenAsync(IssueTokenRequest request, string jwtToken);
}



    