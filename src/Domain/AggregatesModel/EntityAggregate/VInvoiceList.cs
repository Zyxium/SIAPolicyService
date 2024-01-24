using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VInvoiceList
{
    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string CustName { get; set; }

    public string LicenseNo { get; set; }

    public decimal? Amount { get; set; }

    public string VatType { get; set; }

    public decimal? Vat { get; set; }

    public decimal? VatAmt { get; set; }

    public decimal? DiscountAmt { get; set; }

    public decimal? Total { get; set; }

    public string PayTypeDesc { get; set; }

    public string Remark { get; set; }

    public int? IsEdit { get; set; }

    public string AgentCode { get; set; }
}
