using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbCreditteamLog
{
    public int TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string SupAgentCode { get; set; }

    public decimal? SupCreditAmount { get; set; }

    public decimal? SupUsageAmount { get; set; }

    public decimal? SupBalanceAmount { get; set; }

    public string AgentCode { get; set; }

    public decimal? CreditAmount { get; set; }

    public decimal? UsageAmount { get; set; }

    public decimal? BalanceAmount { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
