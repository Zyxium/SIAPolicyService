using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class OldProvince
{
    public int ProvinceCode { get; set; }

    public string ProvinceName { get; set; }

    public string ProvinceDesc { get; set; }

    public int? OldProvinceCode { get; set; }

    public DateTime? CreaDate { get; set; }

    public string CreateBy { get; set; }
}
