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
    
    public async Task<IssueTokenResponse> CreateVIBPolicyAsync(ValidateTokenRequest request)
    {
        var agent_code = request.partnerReferenceCode;
        request.partnerReferenceCode = DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + "-" + request.partnerReferenceCode;
        
        _SIAPolicyRepository.CreatePolicyAsync(request,agent_code);
        
        var generate_token = await _VIBPolicyRepository.GenerateTokenAsync();
        if (generate_token is null)
            throw new CustomHttpBadRequestException("generate_token", "generate_invalid", "generate token found");
        
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

        _SIAPolicyRepository.UpdatePolicyAsync(request.partnerReferenceCode,issue_token_data.policyNo,"","");
        
        return issue_token_data;
    }
}