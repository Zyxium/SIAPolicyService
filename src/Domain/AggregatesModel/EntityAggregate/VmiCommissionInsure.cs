using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VmiCommissionInsure
{
    public string InsureCode { get; set; }

    public string ProductTypeCode { get; set; }

    public string CommTypeCode1 { get; set; }

    public decimal? CommissionValue1 { get; set; }

    public decimal? CommissionVat1 { get; set; }

    public decimal? CommissionTax1 { get; set; }

    public decimal? CommissionNet1 { get; set; }

    public string CommTypeCode2 { get; set; }

    public decimal? CommissionValue2 { get; set; }

    public decimal? CommissionVat2 { get; set; }

    public decimal? CommissionTax2 { get; set; }

    public decimal? CommissionNet2 { get; set; }

    public string CommTypeCode3 { get; set; }

    public decimal? CommissionValue3 { get; set; }

    public decimal? CommissionVat3 { get; set; }

    public decimal? CommissionTax3 { get; set; }

    public decimal? CommissionNet3 { get; set; }

    public string CommTypeCode4 { get; set; }

    public decimal? CommissionValue4 { get; set; }

    public decimal? CommissionVat4 { get; set; }

    public decimal? CommissionTax4 { get; set; }

    public decimal? CommissionNet4 { get; set; }

    public decimal? CommissionNet { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
