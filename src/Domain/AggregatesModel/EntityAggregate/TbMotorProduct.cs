using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorProduct
{
    public int ProductNo { get; set; }

    public string ProductCode { get; set; }

    public string ProductName { get; set; }

    public string MotCode { get; set; }

    public string ProductDescription { get; set; }

    public decimal? NetPrem { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Duty { get; set; }

    public decimal? TotalPrem { get; set; }

    public decimal? LossPerSonAmt { get; set; }

    public decimal? LossPerTimeAmt { get; set; }

    public decimal? LossPerAssetAmt { get; set; }

    public decimal? LossPerDedugAmt { get; set; }

    public decimal? LossMotorPerTimeAmt { get; set; }

    public decimal? LossMotorPerDedugAmt { get; set; }

    public decimal? LossMotorPerFireAmt { get; set; }

    public decimal? LossPaperDriver1Amt { get; set; }

    public decimal? LossPaperPassengerNo { get; set; }

    public decimal? LossPaperPassengerAmt { get; set; }

    public decimal? LossDistPerDriver1Amt { get; set; }

    public decimal? LossDistPerPassengerNo { get; set; }

    public decimal? LossDistPerPassengerAmt { get; set; }

    public decimal? LossMedicalNo { get; set; }

    public decimal? LossMedicalAmt { get; set; }

    public decimal? DriverInsurance { get; set; }

    public decimal? PrimaryCoverPrem { get; set; }

    public decimal? DocAttachmentPrem { get; set; }

    public decimal? Sum13Prem { get; set; }

    public decimal? AddedHistoryPrem { get; set; }

    public decimal? DiscountDeducAmt { get; set; }

    public decimal? DiscountGroupAmt { get; set; }

    public decimal? DiscountHistoryAmt { get; set; }

    public decimal? DiscountOtherAmt { get; set; }

    public string InsureCode { get; set; }

    public int? ProductTypeCode { get; set; }

    public string ProductImageUrl { get; set; }

    public string GarageTypeCd { get; set; }

    public string OrderByList { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IsEnable { get; set; }
}
