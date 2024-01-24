using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class FciTitleCorporate
{
    public int TitleId { get; set; }

    public string TitleDesc { get; set; }

    public string TitleIdFci { get; set; }

    public string Sex { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
