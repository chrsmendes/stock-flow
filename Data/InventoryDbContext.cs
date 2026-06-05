using Microsoft.EntityFrameworkCore;
using stock_flow.Models;

namespace stock_flow.Data;

public class InventoryDbContext : DbContext
{
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
        : base(options)
    {
    }

    public DbSet<InventoryItem> InventoryItems => Set<InventoryItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<InventoryItem>(entity =>
        {
            entity.Property(item => item.UnitCost).HasPrecision(18, 2);
            entity.Property(item => item.RetailPrice).HasPrecision(18, 2);
        });
    }
}