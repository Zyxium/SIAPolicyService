using SIAPolicyService.Domain.AggregatesModel.PartnerAggregate;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;

namespace SIAPolicyService.Domain.Services.Interface;

public interface IVIBPolicyService
{
    Task<IssueTokenResponse> CreateVIBPolicyAsync(ValidateDataRequest request);
}