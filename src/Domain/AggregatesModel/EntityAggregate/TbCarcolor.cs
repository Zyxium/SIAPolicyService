using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbCarcolor
{
    public string ColorId { get; set; }

    public string ColorThaiDesc { get; set; }

    public string ColorEngDesc { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
