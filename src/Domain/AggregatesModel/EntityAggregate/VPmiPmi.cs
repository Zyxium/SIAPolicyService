using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VPmiPmi
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string PmiPolicyNo { get; set; }

    public string PmiSignNo { get; set; }

    public string PayerIdCard { get; set; }

    public string CustName { get; set; }

    public string PayerHomeNo { get; set; }

    public string PayerMoo { get; set; }

    public string PayerBuilding { get; set; }

    public string PayerTrok { get; set; }

    public string PayerSoi { get; set; }

    public string PayerStreet { get; set; }

    public string PayerSubDistrictName { get; set; }

    public string PayerDistrictName { get; set; }

    public string PayerProvinceName { get; set; }

    public string PayerZipcode { get; set; }

    public string PayerPhone { get; set; }

    public string LongAddress { get; set; }

    public string BrandName { get; set; }

    public string ModelName { get; set; }

    public string ModelYear { get; set; }

    public string ModelColorId { get; set; }

    public string ModelColorName { get; set; }

    public string LicenseNo1 { get; set; }

    public string LicenseNo2 { get; set; }

    public string LicenseProvince { get; set; }

    public string LicenseNo { get; set; }

    public string EngineNo { get; set; }

    public string ChassisNo { get; set; }

    public decimal? Cc { get; set; }

    public decimal? NoOfSeat { get; set; }

    public decimal? Weight { get; set; }

    public string CampaignCode { get; set; }

    public string CampaignName { get; set; }

    public string ProductTypeName { get; set; }

    public DateOnly? PmiAgreeDate { get; set; }

    public DateOnly? PmiStartDate { get; set; }

    public DateOnly? PmiEndDate { get; set; }

    public int? CountDay { get; set; }

    public string CarTypeCode { get; set; }

    public decimal? PmiPremium { get; set; }

    public decimal? PmiStamp { get; set; }

    public decimal? PmiVat { get; set; }

    public decimal? PmiTotal { get; set; }

    public decimal? PmiComm { get; set; }

    public decimal? PmiCommTax { get; set; }

    public decimal? PmiDiscount { get; set; }

    public decimal? PmiPayment { get; set; }

    public string AgentCode { get; set; }

    public string BrokerCode { get; set; }

    public string InsurCode { get; set; }

    public string UrlPolicy { get; set; }

    public int? IsPayment { get; set; }

    public int? IsDebitNote { get; set; }

    public int? IsTrans { get; set; }

    public int? IsCancel { get; set; }

    public string FlagCctv { get; set; }

    public string AgentName { get; set; }

    public string PayType { get; set; }

    public string Payment { get; set; }
}
