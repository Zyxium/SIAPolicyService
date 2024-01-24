using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbSeiCarmodel
{
    public string BrandId { get; set; }

    public string ModelId { get; set; }

    public string ModelName { get; set; }

    public string ModelIdSei { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
