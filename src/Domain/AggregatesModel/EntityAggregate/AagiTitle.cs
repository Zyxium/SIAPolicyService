using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class AagiTitle
{
    public int TitleId { get; set; }

    public string TitleDesc { get; set; }

    public string TitleIdAagi { get; set; }

    public string TitleCodeAagi { get; set; }

    public string Sex { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
