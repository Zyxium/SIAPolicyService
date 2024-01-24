using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VmiPayinsuranceHd
{
    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string InsureCode { get; set; }

    public string InsureName { get; set; }

    public decimal? VmiPremium { get; set; }

    public decimal? VmiTotal { get; set; }

    public int? CountPolicy { get; set; }

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

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string Remark { get; set; }

    public int? PayTypeId { get; set; }
}
