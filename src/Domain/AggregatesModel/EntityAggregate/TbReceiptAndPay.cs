using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbReceiptAndPay
{
    public string DocNo { get; set; }

    public string UserId { get; set; }

    public int? ProductNo { get; set; }

    public string ProductName { get; set; }

    public string Description { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Receipt { get; set; }

    public decimal? Pay { get; set; }

    public decimal? Total { get; set; }

    public DateTime? CreateDate { get; set; }
}
