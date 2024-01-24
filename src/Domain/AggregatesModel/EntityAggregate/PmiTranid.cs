using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class PmiTranid
{
    public int? TranId { get; set; }

    public DateTime? TranDate { get; set; }
}
