using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbEndorse
{
    public int TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string TypeDesc { get; set; }

    public string PolicyNo { get; set; }

    public string LicenseNo { get; set; }

    public string Description { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string ComfirmBy { get; set; }

    public DateTime? ConfirmDate { get; set; }

    public string ConfirmDesc { get; set; }
}
