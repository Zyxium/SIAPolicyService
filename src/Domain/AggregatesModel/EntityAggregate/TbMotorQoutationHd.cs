using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbMotorQoutationHd
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

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

    public string EngineNo { get; set; }

    public string ChassisNo { get; set; }

    public decimal? Cc { get; set; }

    public decimal? NoOfSeat { get; set; }

    public decimal? Weight { get; set; }

    public int? IsConfirm { get; set; }

    public int? IsCancel { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string UpdateBy { get; set; }

    public string ApproveBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string MotCode { get; set; }

    public string AdditionalDesc { get; set; }

    public string Remark { get; set; }
}
