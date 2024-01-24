using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMessage
{
    public int TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string ToAgent { get; set; }

    public string MessageTitle { get; set; }

    public string MessageDesc { get; set; }

    public int? IsRead { get; set; }

    public int? IsEnable { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
