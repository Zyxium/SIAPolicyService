using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbOccupation
{
    public string OccupationCode { get; set; }

    public string OccupationDescEn { get; set; }

    public string OccupationDescTh { get; set; }
}
