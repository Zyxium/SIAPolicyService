using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbNewEvent
{
    public int Id { get; set; }

    public string Toppic { get; set; }

    public string ShortDescription { get; set; }

    public string LongDescription { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IsUsage { get; set; }
}
