using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class PmiPmiFileupload
{
    public int Id { get; set; }

    public string TranId { get; set; }

    public string FileName { get; set; }

    public string FileType { get; set; }

    public string FilePath { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
