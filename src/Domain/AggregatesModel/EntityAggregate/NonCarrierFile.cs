using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class NonCarrierFile
{
    public int RowNumber { get; set; }

    public string TranId { get; set; }

    public string ImgName { get; set; }

    public string ImgType { get; set; }

    public string Img64File { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
