using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbInsurance
{
    public string InsureCode { get; set; }

    public string InsureName { get; set; }

    public string InsureTitle { get; set; }

    public string BranceName { get; set; }

    public string InsureAddress { get; set; }

    public string InsurePhone { get; set; }

    public string InsureFax { get; set; }

    public string InsureEmail { get; set; }

    public string InsureWebsite { get; set; }

    public string ContactName { get; set; }

    public string TaxId { get; set; }

    public int? IsEnable { get; set; }

    public int? IsSeviceCancel { get; set; }

    public int? IsCmi { get; set; }

    public int? IsVmi { get; set; }

    public string Orderbycase { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public int? IsCarrier { get; set; }
}
