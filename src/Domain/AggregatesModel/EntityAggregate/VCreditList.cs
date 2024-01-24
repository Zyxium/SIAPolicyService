using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VCreditList
{
    public string AgentCode { get; set; }

    public string AgentName { get; set; }

    public decimal CashAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal CreditUsesage { get; set; }

    public decimal CreditBalances { get; set; }

    public string Remark { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
