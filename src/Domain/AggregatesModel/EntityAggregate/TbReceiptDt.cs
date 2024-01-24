using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbReceiptDt
{
    public string DocNo { get; set; }

    public string UserId { get; set; }

    public int ProductNo { get; set; }

    public string ProductName { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Total { get; set; }

    public DateTime? CreateDate { get; set; }
}
