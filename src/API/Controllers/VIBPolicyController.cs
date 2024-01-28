using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    [HttpPost("cmi")]
    [ProducesResponseType(typeof(IssueTokenResponse), 200)]
    public async Task<IActionResult> CreateVIBPolicyAsync([FromBody] ValidateTokenRequest request)
    {
        var result = await _VIBPolicyService.CreateVIBPolicyAsync(request);
    
        return Ok(result);
    }
}