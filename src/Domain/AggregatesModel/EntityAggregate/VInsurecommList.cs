using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VInsurecommList
{
    public string InsureCode { get; set; }

    public string InsureName { get; set; }

    public decimal? CommissionValue { get; set; }

    public decimal? CommissionTax { get; set; }

    public decimal? CommissionNet { get; set; }

    public string Remark { get; set; }

    public decimal? Ov { get; set; }

    public int? DueDate { get; set; }

    public string CommTypeCode { get; set; }

    public string ComTypeName { get; set; }
}
