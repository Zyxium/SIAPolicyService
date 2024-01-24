using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VReceiptPolicyMaster
{
    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string AgentCode { get; set; }

    public string AgentName { get; set; }

    public decimal? NetPremium { get; set; }

    public decimal? TotalPremium { get; set; }

    public decimal? Commission { get; set; }

    public decimal? NetPayment { get; set; }

    public string TypeName { get; set; }

    public decimal? CashAmount { get; set; }

    public decimal? PayAmount { get; set; }

    public string CreateBy { get; set; }

    public int? CountPay { get; set; }

    public string InsureCode { get; set; }
}
