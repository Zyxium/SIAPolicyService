using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class MtiCarbrand
{
    public string BrandId { get; set; }

    public string BrandName { get; set; }

    public string BrandIdMti { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public string OrderBy { get; set; }
}
