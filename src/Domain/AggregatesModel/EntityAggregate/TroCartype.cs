using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TroCartype
{
    public int TypeId { get; set; }

    public string TypeCode { get; set; }

    public string TypeName { get; set; }
}
