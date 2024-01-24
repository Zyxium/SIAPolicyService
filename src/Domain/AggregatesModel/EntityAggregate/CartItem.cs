using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class CartItem
{
    public string ItemId { get; set; }

    public string CartId { get; set; }

    public decimal? Price { get; set; }

    public int Quantity { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Total { get; set; }

    public DateTime DateCreated { get; set; }

    public int ProductNo { get; set; }

    public string ProductName { get; set; }

    public virtual TbProduct ProductNoNavigation { get; set; }
}
