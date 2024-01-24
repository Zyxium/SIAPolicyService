using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class ViiCarbrand
{
    public string BrandId { get; set; }

    public string BrandName { get; set; }

    public string BrandIdVii { get; set; }

    public string OrderBy { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
