using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class AspNetRole
{
    public string Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<AspNetUser> Users { get; set; } = new List<AspNetUser>();
}
