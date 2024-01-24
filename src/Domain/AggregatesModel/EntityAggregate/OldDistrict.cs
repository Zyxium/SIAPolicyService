using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class OldDistrict
{
    public int DistrictCode { get; set; }

    public int ProvinceCode { get; set; }

    public string DistrictName { get; set; }

    public int? OldDistrictCode { get; set; }

    public int? OldProvinceCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
