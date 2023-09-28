using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLabaC1.Models;

public partial class Shop
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Country { get; set; }
    [Range(-90.0, 90.0)]
    [Column(TypeName = "FLOAT")]
    public double Latitude { get; set; }
    [Range(-90.0, 90.0)]
    [Column(TypeName = "FLOAT")]
    public double Longitude { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
