using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class ViiVmiPackageRate
{
    public int RowId { get; set; }

    public string CarnameCode { get; set; }

    public string BrandId { get; set; }

    public string BrandName { get; set; }

    public string ModelId { get; set; }

    public string ModelName { get; set; }

    public string SubModelId { get; set; }

    public string SubModelName { get; set; }

    public string RateCode { get; set; }

    public string RateName { get; set; }

    public int? CarCc { get; set; }

    public int? CarWeight { get; set; }

    public int? CarSeat { get; set; }

    public string CarGroup { get; set; }

    public string RegistrationYear { get; set; }

    public string VehicleTypeCode { get; set; }

    public string CarCamera { get; set; }

    public decimal? SumInsure { get; set; }

    public decimal? AccessoriesSumInsure { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? StopDate { get; set; }

    public int? InsureType { get; set; }

    public string FlagRepairType { get; set; }

    public string PeriodType { get; set; }

    public string QuotationNumber { get; set; }

    public decimal? TpbiPersonSumStd { get; set; }

    public decimal? TpbiTimeSumStd { get; set; }

    public decimal? TppdTimeSumStd { get; set; }

    public decimal? TppdDeduct { get; set; }

    public decimal? Deduct { get; set; }

    public decimal? FireTheft { get; set; }

    public decimal? DrvSumInsure { get; set; }

    public decimal? DrvCompensate { get; set; }

    public decimal? PsgSumInsure { get; set; }

    public decimal? PsgPermDisable { get; set; }

    public decimal? PsgCompensate { get; set; }

    public decimal? PsgTempDisable { get; set; }

    public decimal? MeSuminsureStd { get; set; }

    public decimal? BbSumStd { get; set; }

    public string TerrorismExclusion { get; set; }

    public string FlagDriver { get; set; }

    public decimal? Premium { get; set; }

    public decimal? Stamp { get; set; }

    public decimal? Vat { get; set; }

    public decimal? Total { get; set; }

    public int? FlagChkFactor { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
