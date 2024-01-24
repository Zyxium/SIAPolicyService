using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class VmiPayinsurancePay
{
    public int TranId { get; set; }

    public DateTime? TranDate { get; set; }

    public int? PaymentTypeId { get; set; }

    public string PaymentTypeDesc { get; set; }

    public string DocnoRef { get; set; }

    public string BankCode { get; set; }

    public string BankName { get; set; }

    public string BankAccountNo { get; set; }

    public string BankBranch { get; set; }

    public DateTime? BankTranDate { get; set; }

    public decimal? PayAmount { get; set; }

    public string Remark { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string ImgName { get; set; }

    public string ImgType { get; set; }

    public string Img64File { get; set; }
}
