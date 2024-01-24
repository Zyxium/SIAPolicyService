using System;
using System.Collections.Generic;

namespace SIAPolicyService.Domain.AggregatesModel.EntityAggregate;

public partial class TbProduct
{
    public int ProductNo { get; set; }

    public string ProductName { get; set; }

    public string ProductDesc { get; set; }

    public decimal? Price { get; set; }

    public decimal? Stock { get; set; }

    public int? IsEnable { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string OrderBy { get; set; }

    public virtual ICollection<CartInvoice> CartInvoices { get; set; } = new List<CartInvoice>();

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}
