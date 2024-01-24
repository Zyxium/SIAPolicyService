using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbCarbodytype
{
    public string BodyTypeId { get; set; }

    public string BodyTypeName { get; set; }

    public string MotorCode { get; set; }
}
