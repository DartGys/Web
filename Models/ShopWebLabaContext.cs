using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebLabaC1.Models;

public partial class ShopWebLabaContext : DbContext
{
    public ShopWebLabaContext()
    {
    }

    public ShopWebLabaContext(DbContextOptions<ShopWebLabaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Shop> Shops { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-CFOLTDF\\SQLEXPRESS;Database=ShopWebLaba;Trusted_Connection=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Image)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Price)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.Shop).WithMany(p => p.Products)
                .HasForeignKey(d => d.ShopId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Shop");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Supplier");
        });

        modelBuilder.Entity<Shop>(entity =>
        {
            entity.ToTable("Shop");

            entity.Property(e => e.Country)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("Supplier");

            entity.Property(e => e.Country)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.Shop).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.ShopId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Supplier_Shop");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
