using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiSignPayDt
{
    public string DocNo { get; set; }

    public string SignNo { get; set; }

    public int? IsUse { get; set; }

    public DateTime? IsUseDate { get; set; }
}
