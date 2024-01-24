using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbDaliveryTracking
{
    public string TranId { get; set; }

    public string Department { get; set; }

    public string DeliveryCode { get; set; }

    public string TrackingNumber { get; set; }

    public DateTime? TrackingDate { get; set; }

    public string Createby { get; set; }

    public DateTime? Createdate { get; set; }
}
