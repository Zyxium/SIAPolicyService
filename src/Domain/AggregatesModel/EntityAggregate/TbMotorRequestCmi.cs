using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorRequestCmi
{
    public string TranId { get; set; }

    public string TranReq { get; set; }

    public DateTime? TranDate { get; set; }

    public string CmiPolicyNo { get; set; }

    public string CmiSignNo { get; set; }

    public string PayerIdCard { get; set; }

    public string PayerTypeId { get; set; }

    public string PayerTypeDesc { get; set; }

    public int? PayerTitleId { get; set; }

    public string PayerTitleText { get; set; }

    public string PayerFirstname { get; set; }

    public string PayerLastname { get; set; }

    public string PayerCompanyPrefix { get; set; }

    public string PayerCompanyName { get; set; }

    public string PayerCompanySuffix { get; set; }

    public string PayerCompanyBranch { get; set; }

    public string PayerCompanyBranchNumber { get; set; }

    public string PayerHomeNo { get; set; }

    public string PayerMoo { get; set; }

    public string PayerBuilding { get; set; }

    public string PayerTrok { get; set; }

    public string PayerSoi { get; set; }

    public string PayerStreet { get; set; }

    public int? PayerSubDistrictId { get; set; }

    public string PayerSubDistrictName { get; set; }

    public int? PayerDistrictId { get; set; }

    public string PayerDistrictName { get; set; }

    public int? PayerProvinceId { get; set; }

    public string PayerProvinceName { get; set; }

    public string PayerZipcode { get; set; }

    public string PayerPhone { get; set; }

    public string BrandCode { get; set; }

    public string BrandName { get; set; }

    public string ModelCode { get; set; }

    public string ModelName { get; set; }

    public string LicenseNo1 { get; set; }

    public string LicenseNo2 { get; set; }

    public int? LicenseProvinceId { get; set; }

    public string LicenseProvince { get; set; }

    public string EngineNo { get; set; }

    public string ChassisNo { get; set; }

    public decimal? Cc { get; set; }

    public decimal? NoOfSeat { get; set; }

    public decimal? Weight { get; set; }

    public string CmiMotCode { get; set; }

    public DateOnly? CmiAgreeDate { get; set; }

    public DateOnly? CmiStartDate { get; set; }

    public DateOnly? CmiEndDate { get; set; }

    public int? CountDay { get; set; }

    public decimal? CmiPremium { get; set; }

    public decimal? CmiStamp { get; set; }

    public decimal? CmiVat { get; set; }

    public decimal? CmiTotal { get; set; }

    public string CmiCommType { get; set; }

    public decimal? CmiComm { get; set; }

    public decimal? CmiCommAmt { get; set; }

    public decimal? CmiCommTax { get; set; }

    public decimal? CmiCommTaxAmt { get; set; }

    public int? IsTax1Percent { get; set; }

    public decimal? Tax1Percent { get; set; }

    public decimal? CmiDiscount { get; set; }

    public decimal? CmiPayment { get; set; }

    public string AgentCode { get; set; }

    public string BrokerCode { get; set; }

    public string InsurCode { get; set; }

    public string UrlPolicy { get; set; }

    public int? IsPayment { get; set; }

    public int? IsTrans { get; set; }

    public int? IsCancel { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string UpdateBy { get; set; }

    public string ColorCode { get; set; }

    public string ColorName { get; set; }

    public string CountryCode { get; set; }
}
