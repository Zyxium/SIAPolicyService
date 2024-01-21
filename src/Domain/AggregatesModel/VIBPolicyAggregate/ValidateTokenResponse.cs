namespace SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;

public class ValidateTokenResponse
{
    public string integrationStatusCode { get; set; }
    public string approvedCode { get; set; }
    public string expiryDate { get; set; }
}