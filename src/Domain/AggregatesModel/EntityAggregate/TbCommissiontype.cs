using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbCommissiontype
{
    public string CommTypeCode { get; set; }

    public string ComTypeName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
