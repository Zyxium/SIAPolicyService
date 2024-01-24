using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbBankaccount
{
    public string BankCode { get; set; }

    public string AccountNo { get; set; }

    public string BankName { get; set; }

    public string AccountName { get; set; }

    public string AccountType { get; set; }

    public string AccountBranch { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
