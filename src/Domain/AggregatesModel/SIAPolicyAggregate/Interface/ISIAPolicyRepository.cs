using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;

namespace SIAPolicyService.Domain.AggregatesModel.SIAPolicyAggregate.Interface;

public interface ISIAPolicyRepository
{
    string CreatePolicyPersonAsync(ValidatePersonTokenRequest request, string agent_code); 
    string CreatePolicyCorporateAsync(ValidateCorporateDataRequest request);
    int UpdatePolicyPersonAsync(string tran_id, string Cmi_Policy_no, string Cmi_Sign_no, string Url_Policy); 
    int UpdatePolicyCorporateAsync(ValidateCorporateDataRequest request);
}