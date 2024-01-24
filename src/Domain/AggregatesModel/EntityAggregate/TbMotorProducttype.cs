using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorProducttype
{
    public int ProductTypeCode { get; set; }

    public string ProductTypeName { get; set; }

    public string ProductTypeDesc { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string UseFor { get; set; }
}
