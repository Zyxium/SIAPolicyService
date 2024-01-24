using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbCustomertype
{
    public string CustTypeCode { get; set; }

    public string CustTypeName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
