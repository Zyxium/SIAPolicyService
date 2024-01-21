namespace SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;

public class IssueTokenResponse
{
    public string integrationStatusCode { get; set; }
    public string policyNo { get; set; }
    public string receiptNumber { get; set; }
    public string applicationNumber { get; set; }
    public object fileLibrary { get; set; }
}