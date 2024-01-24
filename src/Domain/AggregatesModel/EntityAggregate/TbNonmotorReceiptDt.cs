using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbNonmotorReceiptDt
{
    public string DocNo { get; set; }

    public string PolicyNo { get; set; }

    public string CampaignName { get; set; }

    public decimal? NetPremium { get; set; }

    public decimal? TotalPremium { get; set; }

    public decimal? NetComm { get; set; }

    public decimal? NetPayment { get; set; }

    public string InsureCode { get; set; }
}
