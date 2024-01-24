using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VAgentcommList
{
    public string AgentCode { get; set; }

    public decimal? CommissionValue { get; set; }

    public decimal? CommissionTax { get; set; }

    public decimal? CommissionNet { get; set; }

    public string Remark { get; set; }

    public string AgentName { get; set; }

    public string InsureCode { get; set; }

    public string InsureName { get; set; }

    public string CommTypeCode { get; set; }

    public string ComTypeName { get; set; }
}
