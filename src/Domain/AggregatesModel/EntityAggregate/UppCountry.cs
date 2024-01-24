using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class UppCountry
{
    public string CountryCode { get; set; }

    public string DescriptionTh { get; set; }

    public string DescriptionEn { get; set; }

    public int? IsEnable { get; set; }
}
