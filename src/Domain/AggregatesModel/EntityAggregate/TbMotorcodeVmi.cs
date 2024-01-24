using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorcodeVmi
{
    public string MotCode { get; set; }

    public string Description { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
