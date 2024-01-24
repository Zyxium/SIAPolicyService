using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TroCarcheck
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public DateTime? DateOfRegister { get; set; }

    public string BrandCode { get; set; }

    public string BrandName { get; set; }

    public string LicNo1 { get; set; }

    public string LicNo2 { get; set; }

    public int? LicProvinceId { get; set; }

    public string LicProvince { get; set; }

    public string EngineNo { get; set; }

    public string ChassisNo { get; set; }

    public double? Cc { get; set; }

    public double? Seat { get; set; }

    public double? Weigth { get; set; }

    public int? TypeId { get; set; }

    public string TypeCode { get; set; }

    public string CustTypeId { get; set; }

    public string CustTypeDesc { get; set; }

    public string CustIdcard { get; set; }

    public int? CustTitleId { get; set; }

    public string CustTitleText { get; set; }

    public string CustFirstname { get; set; }

    public string CustLastname { get; set; }

    public string CustHomeNo { get; set; }

    public string CustMoo { get; set; }

    public string CustBuilding { get; set; }

    public string CustTrok { get; set; }

    public string CustSoi { get; set; }

    public string CustStreet { get; set; }

    public int? CustSubDistrictId { get; set; }

    public string CustSubDistrictName { get; set; }

    public int? CustDistrictId { get; set; }

    public string CustDistrictName { get; set; }

    public int? CustProvinceId { get; set; }

    public string CustProvinceName { get; set; }

    public string CustZipcode { get; set; }

    public string CustPhone { get; set; }

    public string InspectionId { get; set; }

    public string InspectionTech { get; set; }

    public decimal? ServiceCharge { get; set; }

    public int? IsCancel { get; set; }

    public string UserId { get; set; }

    public string Remark { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
