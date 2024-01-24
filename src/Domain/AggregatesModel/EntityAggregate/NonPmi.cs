using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class NonPmi
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public int? FlagReNew { get; set; }

    public string NonPolicyNo { get; set; }

    public string NonSignNo { get; set; }

    public string OldPolicyNo { get; set; }

    public string PayerIdCard { get; set; }

    public string PayerTypeId { get; set; }

    public string PayerTypeDesc { get; set; }

    public int? PayerTitleId { get; set; }

    public string PayerTitleText { get; set; }

    public string PayerFirstname { get; set; }

    public string PayerLastname { get; set; }

    public string PayerOccupationCode { get; set; }

    public string PayerOccupation { get; set; }

    public string PayerSex { get; set; }

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

    public string PayerBlock { get; set; }

    public int? PayerSubDistrictId { get; set; }

    public string PayerSubDistrictName { get; set; }

    public int? PayerDistrictId { get; set; }

    public string PayerDistrictName { get; set; }

    public int? PayerProvinceId { get; set; }

    public string PayerProvinceName { get; set; }

    public string PayerZipcode { get; set; }

    public string PayerPhone { get; set; }

    public string AreaTypeDesc { get; set; }

    public decimal? AreaTypeAmount { get; set; }

    public string FurnitureDesc { get; set; }

    public decimal? FurnitureAmount { get; set; }

    public string StockDesc { get; set; }

    public decimal? StockAmount { get; set; }

    public string MachineDesc { get; set; }

    public decimal? MachineAmount { get; set; }

    public string AreaLocationDesc { get; set; }

    public string ProductTypeCode { get; set; }

    public string ProductTypeDesc { get; set; }

    public string CampaignCode { get; set; }

    public string CampaignName { get; set; }

    public DateOnly? NonAgreeDate { get; set; }

    public DateOnly? NonStartDate { get; set; }

    public DateOnly? NonEndDate { get; set; }

    public int? CountDay { get; set; }

    public decimal? NonSumInsurance { get; set; }

    public decimal? NonPremium { get; set; }

    public decimal? NonStamp { get; set; }

    public decimal? NonVat { get; set; }

    public decimal? NonTotal { get; set; }

    public string NonCommType { get; set; }

    public decimal? NonComm { get; set; }

    public decimal? NonCommAmt { get; set; }

    public decimal? NonCommTax { get; set; }

    public decimal? NonCommTaxAmt { get; set; }

    public int? IsTax1Percent { get; set; }

    public decimal? Tax1Percent { get; set; }

    public decimal? NonPayment { get; set; }

    public string AgentCode { get; set; }

    public string BrokerCode { get; set; }

    public string InsurCode { get; set; }

    public string UrlPolicy { get; set; }

    public string Beneficiary1 { get; set; }

    public string Beneficiary2 { get; set; }

    public int? IsPayment { get; set; }

    public int? IsDebitNote { get; set; }

    public int? IsTrans { get; set; }

    public int? IsCancel { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string UpdateBy { get; set; }

    public string Remark { get; set; }

    public string RemarkBroker { get; set; }

    public string ResponsNumber { get; set; }
}
