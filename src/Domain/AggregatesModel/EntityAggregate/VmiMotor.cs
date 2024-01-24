using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VmiMotor
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public int? FlagReNew { get; set; }

    public string VmiPolicyNo { get; set; }

    public string VmiPolicyNoOld { get; set; }

    public string CmiPolicyNo { get; set; }

    public string CmiPolicyNoOld { get; set; }

    public string PayerTypeId { get; set; }

    public string PayerTypeDesc { get; set; }

    public string PayerIdCard { get; set; }

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

    public string SubModelCode { get; set; }

    public string SubModelName { get; set; }

    public string ModelYear { get; set; }

    public string ModelColorId { get; set; }

    public string ModelColorName { get; set; }

    public string LicenseNo1 { get; set; }

    public string LicenseNo2 { get; set; }

    public int? LicenseProvinceId { get; set; }

    public string LicenseProvince { get; set; }

    public string LicenseDesc { get; set; }

    public string EngineNo { get; set; }

    public string ChassisNo { get; set; }

    public decimal? Cc { get; set; }

    public decimal? NoOfSeat { get; set; }

    public decimal? Weight { get; set; }

    public string ProductTypeCode { get; set; }

    public string ProductTypeDesc { get; set; }

    public string CampaignCode { get; set; }

    public string CampaignName { get; set; }

    public DateOnly? VmiAgreeDate { get; set; }

    public DateOnly? VmiIssueDate { get; set; }

    public DateOnly? VmiStartDate { get; set; }

    public DateOnly? VmiEndDate { get; set; }

    public int? CountDay { get; set; }

    public string VmiMotCode { get; set; }

    public decimal? VmiPremium { get; set; }

    public decimal? VmiStamp { get; set; }

    public decimal? VmiVat { get; set; }

    public decimal? VmiTotal { get; set; }

    public string VmiCommType { get; set; }

    public decimal? VmiComm { get; set; }

    public decimal? VmiCommAmt { get; set; }

    public decimal? VmiCommTax { get; set; }

    public decimal? VmiCommTaxAmt { get; set; }

    public decimal? VmiCommTax1per { get; set; }

    public decimal? VmiCommTax1perAmt { get; set; }

    public decimal? VmiPayment { get; set; }

    public int? IsPayerDriver1 { get; set; }

    public int? PayerDriver1TitleId { get; set; }

    public string PayerDriver1TitleText { get; set; }

    public string PayerDriver1FirstName { get; set; }

    public string PayerDriver1LastName { get; set; }

    public string PayerDriver1CardId { get; set; }

    public DateTime? PayerDriver1BirthDate { get; set; }

    public string PayerDriver1OccupationCode { get; set; }

    public string PayerDriver1Occupation { get; set; }

    public int? IsPayerDriver2 { get; set; }

    public int? PayerDriver2TitleId { get; set; }

    public string PayerDriver2TitleText { get; set; }

    public string PayerDriver2FirstName { get; set; }

    public string PayerDriver2LastName { get; set; }

    public string PayerDriver2CardId { get; set; }

    public DateTime? PayerDriver2BirthDate { get; set; }

    public string PayerDriver2OccupationCode { get; set; }

    public string PayerDriver2Occupation { get; set; }

    public string Beneficiary { get; set; }

    public string FlagCctv { get; set; }

    public string CarAccessories { get; set; }

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

    public int? GarageTypeCd { get; set; }

    public string GarageTypeDesc { get; set; }

    public string AgentCode { get; set; }

    public string BrokerCode { get; set; }

    public string InsurCode { get; set; }

    public string UrlPolicy { get; set; }

    public int? IsDebitNote { get; set; }

    public string DebitNoteRef { get; set; }

    public int? IsReceipt { get; set; }

    public string ReceiptRef { get; set; }

    public int? IsPayInsure { get; set; }

    public string IsPayInsureRef { get; set; }

    public int? IsCancel { get; set; }

    public int? IsDelivery { get; set; }

    public string DeliveryRef { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string UpdateBy { get; set; }

    public string Remark1 { get; set; }

    public string Remark2 { get; set; }

    public string InsureRefNumber1 { get; set; }

    public string InsureRefNumber2 { get; set; }
}
