using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class PmiCancel
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string AgentCode { get; set; }

    public string PolicyNo { get; set; }

    public string SignNo { get; set; }

    public string InsCode { get; set; }

    public string Note { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
