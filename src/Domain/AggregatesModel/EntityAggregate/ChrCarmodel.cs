using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class ChrCarmodel
{
    public string ModelTranId { get; set; }

    public string BrandId { get; set; }

    public string BrandName { get; set; }

    public string ModelId { get; set; }

    public string ModelName { get; set; }

    public string ModelIdChr { get; set; }

    public string SubModelId { get; set; }

    public string SubModelName { get; set; }

    public string YearBegin { get; set; }

    public string YearEnd { get; set; }

    public string ModelGroupId { get; set; }

    public string ModelCountry { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
