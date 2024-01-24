using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbSector
{
    public string SectorId { get; set; }

    public string SectorName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
