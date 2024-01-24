using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VcmiCmi
{
    public string TranId { get; set; }

    public string PayerTitleText { get; set; }

    public string PayerFirstname { get; set; }

    public string PayerLastname { get; set; }

    public string CustName { get; set; }

    public string PayerCompanyPrefix { get; set; }

    public string PayerCompanyName { get; set; }

    public string PayerCompanySuffix { get; set; }

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

    public string LongAddress { get; set; }

    public string PayerPhone { get; set; }

    public string BrandName { get; set; }

    public string LicenseNo1 { get; set; }

    public string LicenseNo2 { get; set; }

    public string LicenseProvince { get; set; }

    public string LicenseNo { get; set; }

    public string CmiMotCode { get; set; }

    public string CmiPolicyNo { get; set; }

    public string CmiSignNo { get; set; }

    public DateOnly? CmiAgreeDate { get; set; }

    public DateOnly? CmiStartDate { get; set; }

    public DateOnly? CmiEndDate { get; set; }

    public decimal? CmiPremium { get; set; }

    public decimal? CmiStamp { get; set; }

    public decimal? CmiVat { get; set; }

    public decimal? CmiTotal { get; set; }

    public decimal? CmiDiscount { get; set; }

    public decimal? CmiComm { get; set; }

    public decimal? CmiPayment { get; set; }

    public string UrlPolicy { get; set; }

    public string AgentCode { get; set; }

    public string AgentName { get; set; }

    public string InsurCode { get; set; }

    public string Payment { get; set; }

    public DateTime? TranDate { get; set; }
}
