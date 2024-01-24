using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiStockpaper
{
    public int TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string Agentcode { get; set; }

    public string Agentname { get; set; }

    public string Insurecode { get; set; }

    public string Insurename { get; set; }

    public int? Qty { get; set; }

    public string Remark { get; set; }

    public string Createby { get; set; }

    public DateTime? Createdate { get; set; }
}
