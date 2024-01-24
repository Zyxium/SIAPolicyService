using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VUserlist
{
    public string Id { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string AgentName { get; set; }

    public string CodeName { get; set; }
}
