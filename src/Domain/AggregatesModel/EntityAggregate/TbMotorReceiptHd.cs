using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorReceiptHd
{
    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string AgentCode { get; set; }

    public string AgentName { get; set; }

    public int? CountPolicy { get; set; }

    public decimal? NetPremium { get; set; }

    public decimal? Stamp { get; set; }

    public decimal? Vat { get; set; }

    public decimal? TotalPremium { get; set; }

    public decimal? CommAmount { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? Tax1Percent { get; set; }

    public decimal? NetPayment { get; set; }

    public string InsureCode { get; set; }

    public string Remark { get; set; }

    public int? IsEnable { get; set; }

    public int? IsCancel { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string TeamAgentCode { get; set; }

    public decimal? TeamAmount { get; set; }

    public string TeamRemark { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? PayTypeId { get; set; }

    public string PayTypeDesc { get; set; }
}
