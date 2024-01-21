using Core.DotNet.AggregatesModel.ExceptionAggregate;
using Core.DotNet.Extensions.Utilities;
using Core.DotNet.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using SIAPolicyService.Domain.AggregatesModel.PartnerAggregate;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate.Interface;
using SIAPolicyService.Domain.Services.Interface;

namespace SIAPolicyService.Domain.Services;

public class VIBPolicyService : IVIBPolicyService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IVIBPolicyRepository _VIBPolicyRepository;
    private readonly string _partnerReferenceCode;
    
    public VIBPolicyService(IUnitOfWork unitOfWork,
        IHttpContextAccessor httpContextAccessor,
        IVIBPolicyRepository VIBPolicyRepository,
        string partnerReferenceCode
    )
    {
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        _VIBPolicyRepository = VIBPolicyRepository ?? throw new ArgumentNullException(nameof(VIBPolicyRepository));
        _partnerReferenceCode = partnerReferenceCode;
        DateTimeExtensions.SetCultureInfo("en-US");
    }

    public async Task<IssueTokenResponse> CreateVIBPolicyAsync(ValidateDataRequest request)
    {
        var generate_token = await _VIBPolicyRepository.GenerateTokenAsync();
        if (generate_token is null)
            throw new CustomHttpBadRequestException("generate_token", "generate_invalid", "generate token found");
        
        var data_viriyah = new ValidateTokenRequest
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
            case "tui":
            {
                //save to db

                data_viriyah.partnerReferenceCode = _partnerReferenceCode;
                data_viriyah.agreementDate = DateTime.Now.ToString("yyyy-MM-dd");

            }
                break;
        }
        
        #endregion
        
        var validate_data = await _VIBPolicyRepository.ValidateTokenAsync(data_viriyah, generate_token.access_token);
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

        return issue_token_data;
    }
}
