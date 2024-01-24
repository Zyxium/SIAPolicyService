using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbPaymenttype
{
    public int TypeId { get; set; }

    public string TypeName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
