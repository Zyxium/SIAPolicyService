using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiSignReceiveDt
{
    public string DocNo { get; set; }

    public string SignNo { get; set; }

    public int? IsDeal { get; set; }

    public string DealToAgent { get; set; }

    public DateTime? DealToDate { get; set; }
}
