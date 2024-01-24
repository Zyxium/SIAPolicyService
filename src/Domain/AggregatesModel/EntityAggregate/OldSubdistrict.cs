using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class OldSubdistrict
{
    public int ProvinceCode { get; set; }

    public int DistrictCode { get; set; }

    public int SubDistrictCode { get; set; }

    public string SubDistrictName { get; set; }

    public string Zipcode { get; set; }

    public int? OldProvinceCode { get; set; }

    public int? OldDistrictCode { get; set; }

    public int? OldSubDistrictCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
