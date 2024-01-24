using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CartQuotation
{
    public string ItemId { get; set; }

    public string CartId { get; set; }

    public string InsureCode { get; set; }

    public string InsureName { get; set; }

    public int? ProductTypeCode { get; set; }

    public string ProductTypeName { get; set; }

    public string CampaignCode { get; set; }

    public string CampaignName { get; set; }

    public decimal? LossPerSonAmt { get; set; }

    public decimal? LossPerTimeAmt { get; set; }

    public decimal? LossPerAssetAmt { get; set; }

    public decimal? LossPerDedugAmt { get; set; }

    public decimal? LossMotorPerTimeAmt { get; set; }

    public decimal? LossMotorPerDedugAmt { get; set; }

    public decimal? LossMotorPerFireAmt { get; set; }

    public decimal? LossPaperPassengerAmt { get; set; }

    public decimal? LossMedicalAmt { get; set; }

    public decimal? DriverInsurance { get; set; }

    public string NoOfSeat { get; set; }

    public string GarageTypeCd { get; set; }

    public string DriverTypeCd { get; set; }

    public decimal? PmiPremium { get; set; }

    public decimal? CmiPremium { get; set; }

    public decimal? PmiTotal { get; set; }
}
