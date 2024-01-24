using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class SagiSubdistrictTemp
{
    public int ProvinceCode { get; set; }

    public int DistrictCode { get; set; }

    public int SubDistrictCode { get; set; }

    public string SubDistrictName { get; set; }
}
