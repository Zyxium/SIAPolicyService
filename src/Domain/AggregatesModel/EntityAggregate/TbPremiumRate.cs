using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbPremiumRate
{
    public int Id { get; set; }

    public int? DaysLowerLimit { get; set; }

    public int? DaysHigherLimit { get; set; }

    public int? ShortPerc { get; set; }

    public DateTime? CreaDate { get; set; }

    public string CreateBy { get; set; }
}
