using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbNonmotorReceiptHd
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

    public int? PayTypeId { get; set; }

    public int? PaymentCount { get; set; }

    public int? IsEnable { get; set; }

    public int? IsCancel { get; set; }

    public string Remark { get; set; }

    public string UserId { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
