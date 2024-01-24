using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiSignReceiveHd
{
    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public long? SignStart { get; set; }

    public long? SignEnd { get; set; }

    public int? SignCount { get; set; }

    public string SignYear { get; set; }

    public string InsureCode { get; set; }

    public string UserId { get; set; }

    public string Remark { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
