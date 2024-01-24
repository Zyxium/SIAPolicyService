using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbTree
{
    public string NodeParent { get; set; }

    public string NodeChild { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
