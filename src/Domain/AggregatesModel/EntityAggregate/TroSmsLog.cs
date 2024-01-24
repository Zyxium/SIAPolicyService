using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TroSmsLog
{
    public int No { get; set; }

    public string LicenseNo { get; set; }

    public string SmslogDesc { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public string Msisdn { get; set; }

    public int? UsedCredit { get; set; }
}
