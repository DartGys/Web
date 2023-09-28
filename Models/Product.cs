using System;
using System.Collections.Generic;

namespace WebLabaC1.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Image { get; set; }

    public string Price { get; set; }

    public string Description { get; set; }

    public int ShopId { get; set; }

    public int SupplierId { get; set; }

    public virtual Shop Shop { get; set; }

    public virtual Supplier Supplier { get; set; }
}
