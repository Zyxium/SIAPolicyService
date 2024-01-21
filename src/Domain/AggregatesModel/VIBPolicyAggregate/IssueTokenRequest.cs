namespace SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;

public class IssueTokenRequest
{
    public string approvedCode { get; set; }
    public string partnerReferenceCode { get; set; }
    public string paymentReferenceCode { get; set; }
    public string merchantID { get; set; }
}