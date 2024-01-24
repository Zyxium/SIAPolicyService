using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbReceiptHd
{
    public string DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string UserId { get; set; }

    public string CustCardId { get; set; }

    public string CustTypeId { get; set; }

    public string CustTypeDesc { get; set; }

    public int? CustTitleId { get; set; }

    public string CustTitleText { get; set; }

    public string CustFirstname { get; set; }

    public string CustLastname { get; set; }

    public string CustCompanyPrefix { get; set; }

    public string CustCompanyNme { get; set; }

    public string CustCompanySurfix { get; set; }

    public string CustAddress { get; set; }

    public int? SubDistrictId { get; set; }

    public string SubDistrictName { get; set; }

    public int? DistrictId { get; set; }

    public string DistrictName { get; set; }

    public int? ProvinceId { get; set; }

    public string ProvinceName { get; set; }

    public string Zipcode { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }

    public decimal? Amount { get; set; }

    public string VatType { get; set; }

    public decimal? Vat { get; set; }

    public decimal? VatAmt { get; set; }

    public string DiscountType { get; set; }

    public decimal? Discount { get; set; }

    public decimal? DiscountAmt { get; set; }

    public decimal? Total { get; set; }

    public string DocType { get; set; }

    public int? PayTypeId { get; set; }

    public string PayTypeDesc { get; set; }

    public int? IsEnable { get; set; }

    public int? IsCancel { get; set; }

    public string Remark { get; set; }

    public string LicenseNo { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
