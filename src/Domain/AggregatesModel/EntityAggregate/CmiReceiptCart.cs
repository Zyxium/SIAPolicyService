using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiReceiptCart
{
    public string ItemId { get; set; }

    public string CartId { get; set; }

    public string PolicyNo { get; set; }

    public decimal? NetPremium { get; set; }

    public decimal? TotalPremium { get; set; }

    public decimal? NetComm { get; set; }

    public decimal? NetPayment { get; set; }

    public string InsureCode { get; set; }
}
