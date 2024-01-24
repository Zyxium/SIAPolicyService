using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorDebitDt
{
    public string DocNo { get; set; }

    public string TranId { get; set; }

    public string InsureCode { get; set; }

    public decimal? NetPremium { get; set; }

    public decimal? Stamp { get; set; }

    public decimal? Vat { get; set; }

    public decimal? TotalPremium { get; set; }

    public string CommType { get; set; }

    public decimal? CommValue { get; set; }

    public decimal? CommAmt { get; set; }

    public decimal? CommTax { get; set; }

    public decimal? CommTaxAmt { get; set; }

    public decimal? NetPayment { get; set; }

    public int? IsTax1Percent { get; set; }

    public decimal? Tax1Percent { get; set; }
}
