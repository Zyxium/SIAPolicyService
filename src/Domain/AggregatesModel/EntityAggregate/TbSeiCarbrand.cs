using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbSeiCarbrand
{
    public string BrandId { get; set; }

    public string BrandName { get; set; }

    public string BrandIdSei { get; set; }

    public int? OrderBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
