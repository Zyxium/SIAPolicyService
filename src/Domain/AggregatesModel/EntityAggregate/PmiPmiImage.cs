using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class PmiPmiImage
{
    public int Id { get; set; }

    public string TranId { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public string Description { get; set; }

    public string Base64String { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
