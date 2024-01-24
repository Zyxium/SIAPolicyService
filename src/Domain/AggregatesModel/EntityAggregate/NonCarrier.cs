using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class NonCarrier
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string Sec1IdCard { get; set; }

    public string Sec1TypeId { get; set; }

    public string Sec1TypeDesc { get; set; }

    public int? Sec1TitleId { get; set; }

    public string Sec1TitleText { get; set; }

    public string Sec1Firstname { get; set; }

    public string Sec1Lastname { get; set; }

    public string Sec1CompanyPrefix { get; set; }

    public string Sec1CompanyName { get; set; }

    public string Sec1CompanySuffix { get; set; }

    public string Sec1CompanyBranch { get; set; }

    public string Sec1CompanyBranchNumber { get; set; }

    public string Sec1Homeno { get; set; }

    public string Sec1Moo { get; set; }

    public string Sec1Building { get; set; }

    public string Sec1Trok { get; set; }

    public string Sec1Soi { get; set; }

    public string Sec1Street { get; set; }

    public int? Sec1Subdistrictid { get; set; }

    public string Sec1Subdistrictname { get; set; }

    public int? Sec1Districtid { get; set; }

    public string Sec1Districtname { get; set; }

    public int? Sec1Provinceid { get; set; }

    public string Sec1Provincename { get; set; }

    public string Sec1Zipcode { get; set; }

    public string Sec1Phone { get; set; }

    public string Sec2Description { get; set; }

    public int? Sec2Group1 { get; set; }

    public int? Sec2Group2 { get; set; }

    public int? Sec2Group3 { get; set; }

    public int? Sec2Group4 { get; set; }

    public int? Sec2Group5 { get; set; }

    public int? Sec2Group6 { get; set; }

    public int? Sec2Group7 { get; set; }

    public int? Sec3Spec1 { get; set; }

    public int? Sec3Spec2 { get; set; }

    public string Sec3BrandCode { get; set; }

    public string Sec3BrandName { get; set; }

    public string Sec3LicenseNo1 { get; set; }

    public string Sec3LicenseNo2 { get; set; }

    public int? Sec3LicenseProvinceid { get; set; }

    public string Sec3LicenseProvince { get; set; }

    public string Sec3ChassisNo { get; set; }

    public string Sec3EngineNo { get; set; }

    public string Sec3SubBrandCode { get; set; }

    public string Sec3SubBrandName { get; set; }

    public string Sec3SubLicenseNo1 { get; set; }

    public string Sec3SubLicenseNo2 { get; set; }

    public int? Sec3SubLicenseProvinceid { get; set; }

    public string Sec3SubLicenseProvince { get; set; }

    public string Sec3SubChassisNo { get; set; }

    public int? Sec3Car4w1 { get; set; }

    public int? Sec3Car4w2 { get; set; }

    public int? Sec3Car6w1 { get; set; }

    public int? Sec3Car6w2 { get; set; }

    public int? Sec3Car10w1 { get; set; }

    public int? Sec3Car10w2 { get; set; }

    public int? Sec3CarOther1 { get; set; }

    public int? Sec3CarOther2 { get; set; }

    public int? Sec4IsTime { get; set; }

    public int? Sec4IsOnly { get; set; }

    public DateTime? Sec4StartDate { get; set; }

    public DateTime? Sec4EndDate { get; set; }

    public string Sec4StartLocation { get; set; }

    public string Sec4EndLocation { get; set; }

    public int? Sec4InCountry { get; set; }

    public int? Sec4OutCountry { get; set; }

    public string Sec4OutCountryDesc { get; set; }

    public decimal? Sec5Suminsure { get; set; }

    public decimal? Sec521suminsure { get; set; }

    public decimal? Sec522suminsure { get; set; }

    public decimal? Sec53suminsure { get; set; }

    public decimal? Sec6Premium { get; set; }

    public decimal? Sec6Stamp { get; set; }

    public decimal? Sec6Vat { get; set; }

    public decimal? Sec6Total { get; set; }

    public string Sec7Desription { get; set; }

    public string Sec8Desription { get; set; }

    public string Remark { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string ApproveBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string PolicyNo { get; set; }

    public DateTime? PolicyDate { get; set; }

    public string InsureCode { get; set; }

    public string AgentCode { get; set; }

    public int? IsCancel { get; set; }

    public int? IsReceive { get; set; }

    public int? IsPayment { get; set; }

    public int? IsPolicy { get; set; }

    public int? IsApproved { get; set; }
}
