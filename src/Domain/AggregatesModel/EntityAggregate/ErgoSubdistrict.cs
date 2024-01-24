using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class ErgoSubdistrict
{
    public int ProvinceCode { get; set; }

    public int DistrictCode { get; set; }

    public int SubDistrictCode { get; set; }

    public string SubDistrictName { get; set; }

    public string Zipcode { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
