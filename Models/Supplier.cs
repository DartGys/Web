using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebLabaC1.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Country { get; set; } = null!;
    [Display(Name = "ShopName")]
    public int ShopId { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    [Display(Name="ShopName")]

    public virtual Shop Shop { get; set; } = null!;
}
