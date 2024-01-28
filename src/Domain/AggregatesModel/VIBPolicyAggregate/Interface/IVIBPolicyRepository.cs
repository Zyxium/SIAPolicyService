namespace SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate.Interface;

public interface IVIBPolicyRepository
{
    Task<GenerateTokenResponse> GenerateTokenAsync();
    Task<ValidateTokenResponse> ValidatePersonTokenAsync(ValidateTokenRequest request, string jwtToken);
    Task<IssueTokenResponse> IssueTokenAsync(IssueTokenRequest request, string jwtToken);
}



    