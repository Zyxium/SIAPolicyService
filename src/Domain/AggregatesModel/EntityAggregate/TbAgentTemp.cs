using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbAgentTemp
{
    public string AgentCode { get; set; }

    public string IdcartNumber { get; set; }

    public int? TitleId { get; set; }

    public string TitleName { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Address { get; set; }

    public int? SubDistrictCode { get; set; }

    public string SubDistrictName { get; set; }

    public int? DistrictCode { get; set; }

    public string DistrictName { get; set; }

    public int? ProvinceCode { get; set; }

    public string ProvinceName { get; set; }

    public string ZipCode { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }

    public string Mobile { get; set; }

    public string AgentTypeCode { get; set; }

    public int? IsEnable { get; set; }

    public DateTime? CreateDate { get; set; }

    public string AgentTypeId { get; set; }

    public string AgentTypeDesc { get; set; }
}
