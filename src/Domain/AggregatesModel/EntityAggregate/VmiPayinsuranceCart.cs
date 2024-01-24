using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VmiPayinsuranceCart
{
    public string ItemId { get; set; }

    public string CartId { get; set; }

    public string VmiPolicyNo { get; set; }

    public decimal? VmiPremium { get; set; }

    public decimal? VmiTotal { get; set; }

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
