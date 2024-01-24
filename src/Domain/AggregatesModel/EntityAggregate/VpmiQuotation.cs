using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VpmiQuotation
{
    public string TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public string PayerIdCard { get; set; }

    public string CustName { get; set; }

    public string GroupName { get; set; }

    public int? PayerTitleId { get; set; }

    public string PayerTitleText { get; set; }

    public string PayerFirstname { get; set; }

    public string PayerLastname { get; set; }

    public string PayerPhone { get; set; }

    public string BrandCode { get; set; }

    public string BrandName { get; set; }

    public string ModelCode { get; set; }

    public string ModelName { get; set; }

    public string ModelYear { get; set; }

    public string ModelColorId { get; set; }

    public string ModelColorName { get; set; }

    public string LicenseNo1 { get; set; }

    public string LicenseNo2 { get; set; }

    public int? LicenseProvinceId { get; set; }

    public string LicenseNo { get; set; }

    public string EngineNo { get; set; }

    public string ChassisNo { get; set; }

    public decimal? Cc { get; set; }

    public decimal? NoOfSeat { get; set; }

    public decimal? Weight { get; set; }

    public int? IsConfirm { get; set; }

    public string PayType { get; set; }

    public int? IsCancel { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string UpdateBy { get; set; }
}
