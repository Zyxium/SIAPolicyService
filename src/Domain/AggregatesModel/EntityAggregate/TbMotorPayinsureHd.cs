using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorPayinsureHd
{
    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string InsureCode { get; set; }

    public int? PolicyTypeCode { get; set; }

    public int? IsCmi { get; set; }

    public DateTime? PolicyDateStart { get; set; }

    public DateTime? PolicyDateEnd { get; set; }

    public int? CountRec { get; set; }

    public decimal? NetPremium { get; set; }

    public decimal? TotalPremium { get; set; }

    public decimal? CommPercent { get; set; }

    public decimal? CommBath { get; set; }

    public decimal? CommTaxPercent { get; set; }

    public decimal? CommTaxBath { get; set; }

    public decimal? AmtPayment { get; set; }

    public string Remark { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
