﻿using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CmiCommission
{
    public string AgentCode { get; set; }

    public string InsureCode { get; set; }

    public string MotorCode { get; set; }

    public string CommTypeCode { get; set; }

    public decimal? CommissionValue { get; set; }

    public decimal? CommissionTax { get; set; }

    public decimal? CommissionNet { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
