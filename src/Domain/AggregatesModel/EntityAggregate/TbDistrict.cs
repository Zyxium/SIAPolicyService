using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbDistrict
{
    public int DistrictCode { get; set; }

    public int ProvinceCode { get; set; }

    public string DistrictName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
