using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class AagiVmiPremium
{
    public string Packaged { get; set; }

    public string CoverType { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string VehicleUsage { get; set; }

    public string RegionType { get; set; }

    public string GarageType { get; set; }

    public decimal? SumInsured { get; set; }

    public decimal? Deductible { get; set; }

    public decimal? Flood { get; set; }

    public decimal? TpbiPerson { get; set; }

    public decimal? TpbiAccident { get; set; }

    public decimal? Tppd { get; set; }

    public decimal? Pa { get; set; }

    public decimal? Me { get; set; }

    public decimal? Bb { get; set; }

    public string RoadsideAssistance { get; set; }

    public int? Seat { get; set; }

    public int? MinAge { get; set; }

    public int? MaxAge { get; set; }

    public decimal? NetPremium { get; set; }

    public decimal? Vat { get; set; }

    public decimal? Stamp { get; set; }

    public decimal? GrossTotal { get; set; }

    public int? IsEnable { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
