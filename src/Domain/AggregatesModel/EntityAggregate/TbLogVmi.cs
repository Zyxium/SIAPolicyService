using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbLogVmi
{
    public int LogId { get; set; }

    public string LogType { get; set; }

    public string LicenseNo { get; set; }

    public string InsureCode { get; set; }

    public string DataMessage { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
