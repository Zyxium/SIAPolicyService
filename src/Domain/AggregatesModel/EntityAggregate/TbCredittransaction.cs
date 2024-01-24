using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbCredittransaction
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string AgentCode { get; set; }

    public string UseFor { get; set; }

    public decimal? CreditAmount { get; set; }

    public decimal? CreditUsage { get; set; }

    public decimal? CreditBalance { get; set; }

    public string Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
