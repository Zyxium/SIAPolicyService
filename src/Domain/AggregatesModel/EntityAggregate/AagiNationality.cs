using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class AagiNationality
{
    public string NationalityCode { get; set; }

    public string NationalityName { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
