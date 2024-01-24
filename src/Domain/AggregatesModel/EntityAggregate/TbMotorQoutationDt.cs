using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorQoutationDt
{
    public int RowId { get; set; }

    public string TranId { get; set; }

    public string InsureCode { get; set; }

    public int? ProductTypeCode { get; set; }

    public int? GarageTypeCd { get; set; }

    public int? DriverTypeCd { get; set; }

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

    public decimal? Premium { get; set; }

    public decimal? Stamp { get; set; }

    public decimal? Vat { get; set; }

    public decimal? Total { get; set; }

    public string DiscountType { get; set; }

    public decimal? DiscountValue { get; set; }

    public decimal? DiscountAmt { get; set; }

    public decimal? CmiPremium { get; set; }

    public decimal? SumPremium { get; set; }
}
