using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbDeliverySource
{
    public string Code { get; set; }

    public string Name { get; set; }

    public string TrackingLink { get; set; }
}
