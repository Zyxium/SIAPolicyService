using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIAPolicyService.Domain.AggregatesModel.PartnerAggregate;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;
using SIAPolicyService.Domain.Services.Interface;

namespace SIAPolicyService.API.Controllers;

[ApiController]
[Route("VIBPolicyService")]
public class VIBPolicyController : ControllerBase
{
    private readonly IVIBPolicyService _VIBPolicyService;
    
    public VIBPolicyController(IVIBPolicyService VIBPolicyService)
    {
        _VIBPolicyService = VIBPolicyService ?? throw new ArgumentNullException(nameof(VIBPolicyService));
    }
    
    [AllowAnonymous]
    [HttpPost("cmi/person")]
    [ProducesResponseType(typeof(IssueTokenResponse), 200)]
    public async Task<IActionResult> CreateVIBPersonPolicyAsync([FromBody] ValidatePersonTokenRequest request)
    {
        var result = await _VIBPolicyService.CreateVIBPersonPolicyAsync(request);
    
        return Ok(result);
    }
    
    [AllowAnonymous]
    [HttpPost("cmi/corporate")]
    [ProducesResponseType(typeof(IssueTokenResponse), 200)]
    public async Task<IActionResult> CreateVIBCorporatePolicyAsync([FromBody] ValidateCorporateTokenRequest request)
    {
        var result = await _VIBPolicyService.CreateVIBCorporatePolicyAsync(request);
    
        return Ok(result);
    }
}