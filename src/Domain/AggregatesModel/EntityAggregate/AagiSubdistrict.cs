using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class AagiSubdistrict
{
    public int ProvinceCode { get; set; }

    public int DistrictCode { get; set; }

    public int SubDistrictCode { get; set; }

    public string SubDistrictName { get; set; }

    public string Zipcode { get; set; }

    public int? ProvinceCodeAagi { get; set; }

    public int? DistrictCodeAagi { get; set; }

    public int? SubDistrictCodeAagi { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
