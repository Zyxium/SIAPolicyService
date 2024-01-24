using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiCmiDocumentLink
{
    public int RowId { get; set; }

    public string TranId { get; set; }

    public string Insurcode { get; set; }

    public string Type { get; set; }

    public string Layer { get; set; }

    public string Link { get; set; }

    public bool? Header { get; set; }

    public string Createby { get; set; }

    public DateTime? Createdate { get; set; }
}
