using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class MotorPremiumSet
{
    public int TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string PremiumTitle { get; set; }

    public decimal? LossPerSonAmt { get; set; }

    public decimal? LossPerTimeAmt { get; set; }

    public decimal? LossPerAssetAmt { get; set; }

    public decimal? LossPerDedugAmt { get; set; }

    public decimal? LossMotorPerTimeAmt { get; set; }

    public decimal? LossMotorPerFireAmt { get; set; }

    public decimal? LossMotorPerDedugAmt { get; set; }

    public decimal? LossPaperDriver1Amt { get; set; }

    public decimal? LossMedicalNo { get; set; }

    public decimal? LossMedicalAmt { get; set; }

    public decimal? LossDistPerDriver1Amt { get; set; }

    public decimal? LossDistPerPassengerNo { get; set; }

    public decimal? LossDistPerPassengerAmt { get; set; }

    public decimal? LossPaperPassengerNo { get; set; }

    public decimal? LossPaperPassengerAmt { get; set; }

    public decimal? DriverInsurance { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public string Remark { get; set; }
}
