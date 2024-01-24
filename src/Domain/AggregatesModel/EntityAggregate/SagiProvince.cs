using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class SagiProvince
{
    public int ProvinceCode { get; set; }

    public int? ProvinceCodeSagi { get; set; }

    public string ProvinceName { get; set; }

    public string ProvinceDesc { get; set; }

    public string Sector { get; set; }

    public DateTime? CreaDate { get; set; }

    public string CreateBy { get; set; }
}
