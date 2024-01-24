using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VReceiptMotorList
{
    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string AgentCode { get; set; }

    public string AgentName { get; set; }

    public int? CountPolicy { get; set; }

    public decimal? NetPremium { get; set; }

    public decimal? TotalPremium { get; set; }

    public decimal? Commission { get; set; }

    public decimal? NetPayment { get; set; }

    public string TypeName { get; set; }

    public string CustName { get; set; }

    public int? PayTypeId { get; set; }

    public int? PaymentCount { get; set; }

    public string PaymentName { get; set; }

    public int? PaymentCount2 { get; set; }
}
