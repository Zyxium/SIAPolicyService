using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;

namespace SIAPolicyService.Domain.AggregatesModel.SIAPolicyAggregate.Interface;

public interface ISIAPolicyRepository
{
    string CreatePolicyAsync(ValidateTokenRequest request, string agent_code); 
    int UpdatePolicyAsync(string tran_id, string Cmi_Policy_no, string Cmi_Sign_no, string Url_Policy); 
}