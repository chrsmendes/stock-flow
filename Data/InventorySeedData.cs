using Microsoft.EntityFrameworkCore;
using stock_flow.Models;

namespace stock_flow.Data;

public static class InventorySeedData
{
    public static async Task EnsureSeededAsync(InventoryDbContext db)
    {
        if (await db.InventoryItems.AnyAsync())
        {
            return;
        }

        db.InventoryItems.AddRange(
            new InventoryItem
            {
                SKU = "MAT-1001",
                Name = "Hammer",
                Description = "16 oz claw hammer for general maintenance tasks.",
                Category = "Tools",
                QuantityOnHand = 24,
                MinimumStockLevel = 10,
                UnitCost = 8.75m,
                RetailPrice = 14.99m,
                PhysicalLocation = "Aisle 3 / Bin 12",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1002",
                Name = "Box of Nails",
                Description = "1 lb box of galvanized framing nails.",
                Category = "Hardware",
                QuantityOnHand = 58,
                MinimumStockLevel = 20,
                UnitCost = 3.20m,
                RetailPrice = 6.49m,
                PhysicalLocation = "Aisle 1 / Bin 04",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1003",
                Name = "Packing Tape",
                Description = "Heavy-duty clear packing tape rolls.",
                Category = "Supplies",
                QuantityOnHand = 14,
                MinimumStockLevel = 12,
                UnitCost = 2.10m,
                RetailPrice = 4.99m,
                PhysicalLocation = "Aisle 2 / Bin 08",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1004",
                Name = "Safety Gloves",
                Description = "Medium nitrile-coated work gloves.",
                Category = "Safety",
                QuantityOnHand = 31,
                MinimumStockLevel = 15,
                UnitCost = 4.60m,
                RetailPrice = 9.99m,
                PhysicalLocation = "Aisle 4 / Bin 03",
                LastUpdated = DateTime.UtcNow
            });

        await db.SaveChangesAsync();
    }
}