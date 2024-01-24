using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbAgenttype
{
    public string AgentTypeCode { get; set; }

    public string AgentTypeName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
