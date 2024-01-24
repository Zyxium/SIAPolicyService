using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbCountry
{
    public string CountryCode { get; set; }

    public string DescriptionTh { get; set; }

    public string DescriptionEn { get; set; }
}
