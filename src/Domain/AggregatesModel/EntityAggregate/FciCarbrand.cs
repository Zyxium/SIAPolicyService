using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class FciCarbrand
{
    public string BrandId { get; set; }

    public string BrandName { get; set; }

    public string BrandIdFci { get; set; }

    public string OrderBy { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
