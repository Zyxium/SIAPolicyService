using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbTransactionLog
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string UserId { get; set; }

    public string UseFor { get; set; }

    public string Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
