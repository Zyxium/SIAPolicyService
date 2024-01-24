using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiSignPayHd
{
    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string AgentCode { get; set; }

    public string InsureCode { get; set; }

    public long? SignStart { get; set; }

    public long? SignEnd { get; set; }

    public int? SignCount { get; set; }

    public string Remark { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
