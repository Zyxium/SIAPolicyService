using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class AagiVmiModellist
{
    public int RowId { get; set; }

    public string PackageId { get; set; }

    public string CoverType { get; set; }

    public string BrandId { get; set; }

    public string BrandName { get; set; }

    public string ModelId { get; set; }

    public string Modelname { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
