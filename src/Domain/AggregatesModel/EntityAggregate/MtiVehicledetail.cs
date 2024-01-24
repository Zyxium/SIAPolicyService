using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class MtiVehicledetail
{
    public string VehicleKey { get; set; }

    public string Mtikey { get; set; }

    public string MakeCode { get; set; }

    public string Family { get; set; }

    public string YearGroupId { get; set; }

    public string EngineSize { get; set; }

    public string Description { get; set; }

    public string BodyStyle { get; set; }

    public int? DoorNum { get; set; }

    public int? SeatCapacity { get; set; }

    public string Transmission { get; set; }

    public string FuelType { get; set; }

    public string Drive { get; set; }

    public string CarTypeMap { get; set; }

    public string CarTypeDesc { get; set; }

    public string VehCode { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
