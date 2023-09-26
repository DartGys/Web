using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebLabaC1.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Price { get; set; } = null!;

    public string Description { get; set; } = null!;
    [Display(Name = "ShopName")]
    public int ShopId { get; set; }
    [Display(Name = "SupplierName")]
    public int SupplierId { get; set; }
    [Display(Name = "ShopName")]
    public virtual Shop Shop { get; set; } = null!;
    [Display(Name = "SupplierName")]
    public virtual Supplier Supplier { get; set; } = null!;
}
