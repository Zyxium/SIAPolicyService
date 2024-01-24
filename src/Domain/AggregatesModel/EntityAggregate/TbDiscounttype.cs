using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbDiscounttype
{
    public string TypeId { get; set; }

    public string TypeName { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
