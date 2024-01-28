using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;

namespace SIAPolicyService.Domain.AggregatesModel.SIAPolicyAggregate;

public class ValidatePersonDataRequest
{
    public string partnerReferenceCode { get; set; }
    public string agreementDate { get; set; }
    public string insuredType { get; set; }
    public Insured insured { get; set; }
    public string receiptAs { get; set; }
    public string receiptType { get; set; }
    public Receipt receipt { get; set; }
    public PolicyDeliveryMethod policyDeliveryMethod { get; set; }
    public Vehicle vehicle { get; set; }
    public Intermediary intermediary { get; set; }
    public Payment payment { get; set; }
    public Coverage coverage { get; set; }
}

public class ValidateCorporateDataRequest : ValidatePersonDataRequest
{

}