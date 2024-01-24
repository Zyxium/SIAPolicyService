using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiPayinsurnceDt
{
    public int RowNumber { get; set; }

    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string InsureCode { get; set; }

    public string CmiPolicyNo { get; set; }

    public DateTime? CmiAgreeDate { get; set; }

    public DateTime? CmiStartDate { get; set; }

    public DateTime? CmiEndDate { get; set; }

    public int? CountDay { get; set; }

    public decimal? CmiPremium { get; set; }

    public decimal? CmiTotal { get; set; }

    public string CmiMotCode { get; set; }

    public string CommTypeCode1 { get; set; }

    public decimal? Commission1 { get; set; }

    public decimal? CommissionAmount1 { get; set; }

    public decimal? CommissionVat1 { get; set; }

    public decimal? CommissionVatAmount1 { get; set; }

    public decimal? CommissionTax1 { get; set; }

    public decimal? CommissionTaxAmount1 { get; set; }

    public string CommTypeCode2 { get; set; }

    public decimal? Commission2 { get; set; }

    public decimal? CommissionAmount2 { get; set; }

    public decimal? CommissionVat2 { get; set; }

    public decimal? CommissionVatAmount2 { get; set; }

    public decimal? CommissionTax2 { get; set; }

    public decimal? CommissionTaxAmount2 { get; set; }

    public string CommTypeCode3 { get; set; }

    public decimal? Commission3 { get; set; }

    public decimal? CommissionAmount3 { get; set; }

    public decimal? CommissionVat3 { get; set; }

    public decimal? CommissionVatAmount3 { get; set; }

    public decimal? CommissionTax3 { get; set; }

    public decimal? CommissionTaxAmount3 { get; set; }

    public string CommTypeCode4 { get; set; }

    public decimal? Commission4 { get; set; }

    public decimal? CommissionAmount4 { get; set; }

    public decimal? CommissionVat4 { get; set; }

    public decimal? CommissionVatAmount4 { get; set; }

    public decimal? CommissionTax4 { get; set; }

    public decimal? CommissionTaxAmount4 { get; set; }

    public decimal? NetPremiumAmount { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
