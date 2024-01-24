using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorPayinsureDt
{
    public int RowId { get; set; }

    public string DocNo { get; set; }

    public string CustName { get; set; }

    public string PolicyNo { get; set; }

    public string PolicyType { get; set; }

    public decimal? NetPremium { get; set; }

    public decimal? TotalPremium { get; set; }

    public decimal? CommPercent { get; set; }

    public decimal? CommBath { get; set; }

    public decimal? CommTaxPercent { get; set; }

    public decimal? CommTaxBath { get; set; }

    public decimal? AmtPayment { get; set; }
}
