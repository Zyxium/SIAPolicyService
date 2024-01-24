using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class IniMotorcode
{
    public string MotCode { get; set; }

    public string Description { get; set; }

    public decimal? Cc { get; set; }

    public decimal? Weigth { get; set; }

    public decimal? Seat { get; set; }

    public decimal? NetPrem { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Duty { get; set; }

    public decimal? TaxPrem { get; set; }

    public decimal? DutyPrem { get; set; }

    public decimal? TotalPrem { get; set; }

    public string BodyType { get; set; }

    public string Usage { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreateBy { get; set; }
}
