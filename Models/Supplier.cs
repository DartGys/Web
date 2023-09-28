using System;
using System.Collections.Generic;

namespace WebLabaC1.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Country { get; set; }

    public int ShopId { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>(); 

    public virtual Shop Shop { get; set; }
}
