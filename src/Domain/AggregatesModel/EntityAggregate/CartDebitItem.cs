using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CartDebitItem
{
    public string ItemId { get; set; }

    public string CartId { get; set; }

    public string PolicyNo { get; set; }

    public string CampaignName { get; set; }

    public decimal? PmiPremium { get; set; }

    public decimal? PmiStamp { get; set; }

    public decimal? PmiVat { get; set; }

    public decimal? PmiTotal { get; set; }

    public decimal? PmiDiscount { get; set; }

    public decimal? PmiPayment { get; set; }

    public string InsurCode { get; set; }

    public string TranIdPmi { get; set; }
}
