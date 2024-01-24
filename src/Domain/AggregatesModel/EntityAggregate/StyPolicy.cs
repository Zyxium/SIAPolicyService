using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class StyPolicy
{
    public int No { get; set; }

    public string PolicyNo { get; set; }

    public string StickerNo { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public DateTime? UsingDate { get; set; }

    public string UsingBy { get; set; }
}
