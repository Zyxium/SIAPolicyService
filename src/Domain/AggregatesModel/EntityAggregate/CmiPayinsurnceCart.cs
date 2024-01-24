using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiPayinsurnceCart
{
    public string ItemId { get; set; }

    public string CartId { get; set; }

    public string CmiPolicyNo { get; set; }

    public decimal? CmiPremium { get; set; }

    public decimal? CmiTotal { get; set; }

    public decimal? CommissionAmount1 { get; set; }

    public decimal? CommissionVatAmount1 { get; set; }

    public decimal? CommissionTaxAmount1 { get; set; }

    public decimal? CommissionAmount2 { get; set; }

    public decimal? CommissionVatAmount2 { get; set; }

    public decimal? CommissionTaxAmount2 { get; set; }

    public decimal? CommissionAmount3 { get; set; }

    public decimal? CommissionVatAmount3 { get; set; }

    public decimal? CommissionTaxAmount3 { get; set; }

    public decimal? CommissionAmount4 { get; set; }

    public decimal? CommissionVatAmount4 { get; set; }

    public decimal? CommissionTaxAmount4 { get; set; }

    public decimal? NetPremiumAmount { get; set; }
}
