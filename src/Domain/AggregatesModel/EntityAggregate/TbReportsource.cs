using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbReportsource
{
    public int Id { get; set; }

    public string ReportName { get; set; }

    public string ReportDesc { get; set; }

    public string ReportPath { get; set; }

    public string ReportParamDesc { get; set; }

    public string ReportType { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? CratetDate { get; set; }
}
