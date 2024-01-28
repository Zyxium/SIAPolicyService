using Core.DotNet.AggregatesModel.ExceptionAggregate;
using Core.DotNet.Extensions.Utilities;
using Core.DotNet.Infrastructure;
using Microsoft.AspNetCore.Http;
using SIAPolicyService.Domain.AggregatesModel.SIAPolicyAggregate.Interface;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate.Interface;
using SIAPolicyService.Domain.Services.Interface;

namespace SIAPolicyService.Domain.Services;

public class VIBPolicyService : IVIBPolicyService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IVIBPolicyRepository _VIBPolicyRepository;
    private readonly ISIAPolicyRepository _SIAPolicyRepository;
    private readonly string _partnerReferenceCode;
    
    public VIBPolicyService(IUnitOfWork unitOfWork,
        IHttpContextAccessor httpContextAccessor,
        IVIBPolicyRepository VIBPolicyRepository,
        ISIAPolicyRepository SIAPolicyRepository,
        string partnerReferenceCode
    )
    {
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        _VIBPolicyRepository = VIBPolicyRepository ?? throw new ArgumentNullException(nameof(VIBPolicyRepository));
        _SIAPolicyRepository = SIAPolicyRepository ?? throw new ArgumentNullException(nameof(SIAPolicyRepository));
        _partnerReferenceCode = partnerReferenceCode;
        DateTimeExtensions.SetCultureInfo("en-US");
    }
    
    // public async Task<IssueTokenResponse> CreateVIBPolicyAsync(ValidateDataRequest request)
    // {
    //    // var ss = await _tb_agentRepository.CreatePolicyAsync(request);
    //     
    //  
    //     var data_viriyah = new ValidateTokenRequest
    //     {
    //         partnerReferenceCode = request.partnerReferenceCode,
    //         agreementDate = request.agreementDate,
    //         insuredType = request.insuredType,
    //         insured = request.insured.ToInsuredData(),
    //         receiptAs = request.receiptAs,
    //         receiptType = request.receiptType,
    //         receipt = request.receipt,
    //         policyDeliveryMethod = request.policyDeliveryMethod,
    //         intermediary = request.intermediary,
    //         payment = request.payment,
    //         vehicle = request.vehicle,
    //         coverage = request.coverage
    //     };
    //     
    //     
    //     
    //     #region change to get check in database
    //     
    //     switch (request.partnerReferenceCode)
    //     {
    //         case "tui":
    //         {
    //             //save to db
    //     
    //             data_viriyah.partnerReferenceCode = _partnerReferenceCode;
    //             data_viriyah.agreementDate = DateTime.Now.ToString("yyyy-MM-dd");
    //     
    //         }
    //             break;
    //     }
    //     
    //     #endregion
    //     
    //     var validate_data = await _VIBPolicyRepository.ValidateTokenAsync(data_viriyah, generate_token.access_token);
    //     if (validate_data is null)
    //         throw new CustomHttpBadRequestException("validate_data", "validate_invalid", "validate token found");
    //     
    //     var issue_token = new IssueTokenRequest
    //     {
    //         approvedCode = validate_data.approvedCode,
    //         partnerReferenceCode = _partnerReferenceCode,
    //         paymentReferenceCode = "",
    //         merchantID = ""
    //     };
    //     
    //     var issue_token_data = await _VIBPolicyRepository.IssueTokenAsync(issue_token, generate_token.access_token);
    //
    //
    //      var dd = await _tb_agentRepository.GetAllTbAgentAsync();
    //     
    //     if (dd.Count >0)
    //     {
    //         var ff = "";
    //     
    //     }
    //
    //   //  return issue_token_data;
    //   return new IssueTokenResponse();
    // }

    public async Task<IssueTokenResponse> CreateVIBPersonPolicyAsync(ValidatePersonTokenRequest request)
    {
        var agent_code = request.partnerReferenceCode;
        request.partnerReferenceCode = DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + "-" + request.partnerReferenceCode;
        
        _SIAPolicyRepository.CreatePolicyPersonAsync(request,agent_code);
        
        var generate_token = await _VIBPolicyRepository.GenerateTokenAsync();
        if (generate_token is null)
            throw new CustomHttpBadRequestException("generate_token", "generate_invalid", "generate token found");
        
        // var data_viriyah = new ValidatePersonTokenRequest
        // {
        //     partnerReferenceCode = request.partnerReferenceCode,
        //     agreementDate = request.agreementDate,
        //     insuredType = request.insuredType,
        //     insured = request.insured,
        //     receiptAs = request.receiptAs,
        //     receiptType = request.receiptType,
        //     receipt = request.receipt,
        //     policyDeliveryMethod = request.policyDeliveryMethod,
        //     intermediary = request.intermediary,
        //     payment = request.payment,
        //     vehicle = request.vehicle,
        //     coverage = request.coverage
        // };
        
        #region change to get check in database
        
        // switch (request.partnerReferenceCode)
        // {
        //     case "person":
        //     {
        //         //save to db
        //
        //         data_viriyah.partnerReferenceCode =
        //             DateTime.Now.ToString("yyyyMMddHHmmss-") + request.partnerReferenceCode; //_partnerReferenceCode;
        //     }
        //         break;
        //     case "corporate":
        //     {
        //         //save to db
        //
        //         data_viriyah.partnerReferenceCode = _partnerReferenceCode;
        //     }
        //         break;
        // }
        //
        #endregion
        
        var validate_data = await _VIBPolicyRepository.ValidatePersonTokenAsync(request, generate_token.access_token);
        if (validate_data is null)
            throw new CustomHttpBadRequestException("validate_data", "validate_invalid", "validate token found");
        
        var issue_token = new IssueTokenRequest
        {
            approvedCode = validate_data.approvedCode,
            partnerReferenceCode = request.partnerReferenceCode,
            paymentReferenceCode = "",
            merchantID = ""
        };
        
        var issue_token_data = await _VIBPolicyRepository.IssueTokenAsync(issue_token, generate_token.access_token);

        _SIAPolicyRepository.UpdatePolicyPersonAsync(request.partnerReferenceCode,issue_token_data.policyNo,"","");
        
        return issue_token_data;
    }

    public async Task<IssueTokenResponse> CreateVIBCorporatePolicyAsync(ValidateCorporateTokenRequest request)
    {
        var tranId = DateTime.Now.ToString("yyyyMMddHHmmsstt") + "-" + request.partnerReferenceCode;
        var generate_token = await _VIBPolicyRepository.GenerateTokenAsync();
        if (generate_token is null)
            throw new CustomHttpBadRequestException("generate_token", "generate_invalid", "generate token found");

        request.partnerReferenceCode = tranId;
        
        // var data_viriyah = new ValidatePersonTokenRequest
        // {
        //     partnerReferenceCode = request.partnerReferenceCode,
        //     agreementDate = request.agreementDate,
        //     insuredType = request.insuredType,
        //     insured = request.insured,
        //     receiptAs = request.receiptAs,
        //     receiptType = request.receiptType,
        //     receipt = request.receipt,
        //     policyDeliveryMethod = request.policyDeliveryMethod,
        //     intermediary = request.intermediary,
        //     payment = request.payment,
        //     vehicle = request.vehicle,
        //     coverage = request.coverage
        // };
        
        #region change to get check in database
        
        // switch (request.partnerReferenceCode)
        // {
        //     case "person":
        //     {
        //         //save to db
        //
        //         data_viriyah.partnerReferenceCode =
        //             DateTime.Now.ToString("yyyyMMddHHmmss-") + request.partnerReferenceCode; //_partnerReferenceCode;
        //     }
        //         break;
        //     case "corporate":
        //     {
        //         //save to db
        //
        //         data_viriyah.partnerReferenceCode = _partnerReferenceCode;
        //     }
        //         break;
        // }
        //
        #endregion
        
        var validate_data = await _VIBPolicyRepository.ValidateCorporateTokenAsync(request, generate_token.access_token);
        if (validate_data is null)
            throw new CustomHttpBadRequestException("validate_data", "validate_invalid", "validate token found");
        
        var issue_token = new IssueTokenRequest
        {
            approvedCode = validate_data.approvedCode,
            partnerReferenceCode = tranId,
            paymentReferenceCode = "",
            merchantID = ""
        };
        
        var issue_token_data = await _VIBPolicyRepository.IssueTokenAsync(issue_token, generate_token.access_token);

        _SIAPolicyRepository.UpdatePolicyPersonAsync(request.partnerReferenceCode,issue_token_data.policyNo,"","");
        
        return issue_token_data;
    }

    public async Task<IssueTokenResponse> CreateVIBCorporatePolicyAsync2(ValidateCorporateTokenRequest request)
    {
        var tranId = DateTime.Now.ToString("yyyyMMddHHmmss");// _tb_agentRepository.CreatePolicyCorporateAsync(request);
        var generate_token = await _VIBPolicyRepository.GenerateTokenAsync();
        if (generate_token is null)
            throw new CustomHttpBadRequestException("generate_token", "generate_invalid", "generate token found");
        
        var data_viriyah = new ValidateCorporateTokenRequest
        {
            partnerReferenceCode = request.partnerReferenceCode,
            agreementDate = request.agreementDate,
            insuredType = request.insuredType,
            insured = request.insured,
            receiptAs = request.receiptAs,
            receiptType = request.receiptType,
            receipt = request.receipt,
            policyDeliveryMethod = request.policyDeliveryMethod,
            intermediary = request.intermediary,
            payment = request.payment,
            vehicle = request.vehicle,
            coverage = request.coverage
        };
        
        #region change to get check in database
        
        switch (request.partnerReferenceCode)
        {
            case "nhong_person":
            {
                //save to db
        
                data_viriyah.partnerReferenceCode = _partnerReferenceCode;
            }
                break;
            case "nhong_corporate":
            {
                //save to db
        
                data_viriyah.partnerReferenceCode = _partnerReferenceCode;
            }
                break;
        }
        
        #endregion
        
        var validate_data = await _VIBPolicyRepository.ValidateCorporateTokenAsync(data_viriyah, generate_token.access_token);
        if (validate_data is null)
            throw new CustomHttpBadRequestException("validate_data", "validate_invalid", "validate token found");
        
        var issue_token = new IssueTokenRequest
        {
            approvedCode = validate_data.approvedCode,
            partnerReferenceCode = _partnerReferenceCode,
            paymentReferenceCode = "",
            merchantID = ""
        };
        
        var issue_token_data = await _VIBPolicyRepository.IssueTokenAsync(issue_token, generate_token.access_token);
        
        _SIAPolicyRepository.UpdatePolicyPersonAsync(tranId,issue_token_data.policyNo,"","");

        return issue_token_data;
    }
}