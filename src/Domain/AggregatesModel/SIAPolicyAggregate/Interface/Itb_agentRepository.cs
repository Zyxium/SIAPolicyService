using Core.DotNet.Infrastructure;
using SIAPolicyService.Domain.AggregatesModel.EntityAggregate;
using SIAPolicyService.Domain.AggregatesModel.PartnerAggregate;

namespace SIAPolicyService.Domain.AggregatesModel.SIAPolicyAggregate.Interface;

public interface Itb_agentRepository
{
    string CreatePolicyPersonAsync(ValidatePersonDataRequest request); 
    string CreatePolicyCorporateAsync(ValidateCorporateDataRequest request);
    int UpdatePolicyPersonAsync(string tran_id, string Cmi_Policy_no, string Cmi_Sign_no, string Url_Policy); 
    int UpdatePolicyCorporateAsync(ValidateCorporateDataRequest request);
}