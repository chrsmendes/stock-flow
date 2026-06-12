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
            },
            new InventoryItem
            {
                SKU = "MAT-1005",
                Name = "Safety Goggles",
                Description = "Anti-fog, scratch-resistant protective eyewear.",
                Category = "Safety",
                QuantityOnHand = 45,
                MinimumStockLevel = 20,
                UnitCost = 5.50m,
                RetailPrice = 12.99m,
                PhysicalLocation = "Aisle 4 / Bin 01",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1006",
                Name = "Earplugs (Box)",
                Description = "Box of 200 disposable foam earplugs.",
                Category = "Safety",
                QuantityOnHand = 12,
                MinimumStockLevel = 5,
                UnitCost = 15.00m,
                RetailPrice = 29.99m,
                PhysicalLocation = "Aisle 4 / Bin 02",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1007",
                Name = "High-Vis Vest",
                Description = "Reflective safety vest, size Large.",
                Category = "Safety",
                QuantityOnHand = 28,
                MinimumStockLevel = 10,
                UnitCost = 8.25m,
                RetailPrice = 18.50m,
                PhysicalLocation = "Aisle 4 / Bin 05",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1008",
                Name = "First Aid Kit",
                Description = "Standard 100-piece industrial first aid kit.",
                Category = "Safety",
                QuantityOnHand = 8,
                MinimumStockLevel = 10, // Triggers reorder
                UnitCost = 22.00m,
                RetailPrice = 45.00m,
                PhysicalLocation = "Aisle 4 / Bin 10",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1009",
                Name = "Screwdriver Set",
                Description = "6-piece magnetic tip screwdriver set.",
                Category = "Tools",
                QuantityOnHand = 18,
                MinimumStockLevel = 10,
                UnitCost = 12.50m,
                RetailPrice = 24.99m,
                PhysicalLocation = "Aisle 3 / Bin 05",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1010",
                Name = "Cordless Drill",
                Description = "18V Lithium-Ion cordless drill with battery.",
                Category = "Tools",
                QuantityOnHand = 5,
                MinimumStockLevel = 5,
                UnitCost = 65.00m,
                RetailPrice = 129.00m,
                PhysicalLocation = "Aisle 3 / Bin 01",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1011",
                Name = "Adjustable Wrench",
                Description = "10-inch forged steel adjustable wrench.",
                Category = "Tools",
                QuantityOnHand = 22,
                MinimumStockLevel = 8,
                UnitCost = 9.75m,
                RetailPrice = 19.99m,
                PhysicalLocation = "Aisle 3 / Bin 08",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1012",
                Name = "Tape Measure",
                Description = "25-foot heavy-duty tape measure.",
                Category = "Tools",
                QuantityOnHand = 35,
                MinimumStockLevel = 15,
                UnitCost = 6.20m,
                RetailPrice = 14.50m,
                PhysicalLocation = "Aisle 3 / Bin 09",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1013",
                Name = "Utility Knife",
                Description = "Retractable utility knife with 5 spare blades.",
                Category = "Tools",
                QuantityOnHand = 40,
                MinimumStockLevel = 20,
                UnitCost = 4.10m,
                RetailPrice = 8.99m,
                PhysicalLocation = "Aisle 3 / Bin 11",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1014",
                Name = "Wood Screws",
                Description = "Box of 100 2-inch Philips head wood screws.",
                Category = "Hardware",
                QuantityOnHand = 85,
                MinimumStockLevel = 30,
                UnitCost = 4.50m,
                RetailPrice = 9.99m,
                PhysicalLocation = "Aisle 1 / Bin 05",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1015",
                Name = "Hex Nuts (1/4\")",
                Description = "Bag of 50 stainless steel 1/4\" hex nuts.",
                Category = "Hardware",
                QuantityOnHand = 110,
                MinimumStockLevel = 50,
                UnitCost = 2.00m,
                RetailPrice = 5.50m,
                PhysicalLocation = "Aisle 1 / Bin 08",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1016",
                Name = "Washers (1/4\")",
                Description = "Bag of 100 stainless steel 1/4\" flat washers.",
                Category = "Hardware",
                QuantityOnHand = 150,
                MinimumStockLevel = 50,
                UnitCost = 1.75m,
                RetailPrice = 4.99m,
                PhysicalLocation = "Aisle 1 / Bin 09",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1017",
                Name = "Door Hinges",
                Description = "Pair of 3-inch brass door hinges.",
                Category = "Hardware",
                QuantityOnHand = 16,
                MinimumStockLevel = 10,
                UnitCost = 5.30m,
                RetailPrice = 11.99m,
                PhysicalLocation = "Aisle 1 / Bin 12",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1018",
                Name = "Heavy Duty Padlock",
                Description = "Weather-resistant steel padlock with 2 keys.",
                Category = "Hardware",
                QuantityOnHand = 9,
                MinimumStockLevel = 12, // Triggers reorder
                UnitCost = 12.00m,
                RetailPrice = 24.50m,
                PhysicalLocation = "Aisle 1 / Bin 15",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1019",
                Name = "Bubble Wrap Roll",
                Description = "100-foot roll of large bubble wrap.",
                Category = "Supplies",
                QuantityOnHand = 6,
                MinimumStockLevel = 10, // Triggers reorder
                UnitCost = 18.50m,
                RetailPrice = 35.00m,
                PhysicalLocation = "Aisle 2 / Bin 01",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1020",
                Name = "Cardboard Box (M)",
                Description = "Medium corrugated shipping box (18x18x16).",
                Category = "Supplies",
                QuantityOnHand = 120,
                MinimumStockLevel = 50,
                UnitCost = 1.10m,
                RetailPrice = 2.50m,
                PhysicalLocation = "Aisle 2 / Bin 04",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1021",
                Name = "Zip Ties",
                Description = "Pack of 500 8-inch black nylon zip ties.",
                Category = "Supplies",
                QuantityOnHand = 42,
                MinimumStockLevel = 15,
                UnitCost = 6.00m,
                RetailPrice = 14.99m,
                PhysicalLocation = "Aisle 2 / Bin 06",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1022",
                Name = "Duct Tape",
                Description = "Heavy-duty silver duct tape roll.",
                Category = "Supplies",
                QuantityOnHand = 27,
                MinimumStockLevel = 10,
                UnitCost = 4.25m,
                RetailPrice = 8.50m,
                PhysicalLocation = "Aisle 2 / Bin 09",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1023",
                Name = "Permanent Markers",
                Description = "12-pack of black permanent markers.",
                Category = "Supplies",
                QuantityOnHand = 15,
                MinimumStockLevel = 5,
                UnitCost = 7.50m,
                RetailPrice = 15.00m,
                PhysicalLocation = "Aisle 2 / Bin 11",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1024",
                Name = "Extension Cord",
                Description = "50-foot outdoor rated extension cord (14 AWG).",
                Category = "Electrical",
                QuantityOnHand = 11,
                MinimumStockLevel = 8,
                UnitCost = 22.00m,
                RetailPrice = 45.99m,
                PhysicalLocation = "Aisle 5 / Bin 01",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1025",
                Name = "Wire Strippers",
                Description = "Professional multi-tool wire stripper and cutter.",
                Category = "Electrical",
                QuantityOnHand = 14,
                MinimumStockLevel = 5,
                UnitCost = 11.20m,
                RetailPrice = 22.50m,
                PhysicalLocation = "Aisle 5 / Bin 03",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1026",
                Name = "Electrical Tape",
                Description = "Roll of black vinyl electrical insulation tape.",
                Category = "Electrical",
                QuantityOnHand = 65,
                MinimumStockLevel = 20,
                UnitCost = 1.50m,
                RetailPrice = 3.99m,
                PhysicalLocation = "Aisle 5 / Bin 04",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1027",
                Name = "LED Bulbs",
                Description = "4-pack of 60W equivalent daylight LED bulbs.",
                Category = "Electrical",
                QuantityOnHand = 32,
                MinimumStockLevel = 15,
                UnitCost = 8.00m,
                RetailPrice = 16.99m,
                PhysicalLocation = "Aisle 5 / Bin 06",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1028",
                Name = "Digital Multimeter",
                Description = "Auto-ranging digital multimeter with probes.",
                Category = "Electrical",
                QuantityOnHand = 4,
                MinimumStockLevel = 5, // Triggers reorder
                UnitCost = 28.50m,
                RetailPrice = 59.99m,
                PhysicalLocation = "Aisle 5 / Bin 08",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1029",
                Name = "PVC Pipe",
                Description = "1-inch Schedule 40 PVC pipe (10 ft length).",
                Category = "Plumbing",
                QuantityOnHand = 40,
                MinimumStockLevel = 20,
                UnitCost = 3.80m,
                RetailPrice = 8.50m,
                PhysicalLocation = "Aisle 6 / Rack A",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1030",
                Name = "Teflon Tape",
                Description = "Roll of thread seal tape for plumbing.",
                Category = "Plumbing",
                QuantityOnHand = 80,
                MinimumStockLevel = 30,
                UnitCost = 0.75m,
                RetailPrice = 1.99m,
                PhysicalLocation = "Aisle 6 / Bin 02",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1031",
                Name = "Pipe Wrench",
                Description = "14-inch heavy-duty cast iron pipe wrench.",
                Category = "Plumbing",
                QuantityOnHand = 12,
                MinimumStockLevel = 5,
                UnitCost = 16.50m,
                RetailPrice = 34.00m,
                PhysicalLocation = "Aisle 6 / Bin 05",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1032",
                Name = "Plunger",
                Description = "Heavy-duty rubber toilet plunger with wooden handle.",
                Category = "Plumbing",
                QuantityOnHand = 18,
                MinimumStockLevel = 10,
                UnitCost = 5.20m,
                RetailPrice = 11.50m,
                PhysicalLocation = "Aisle 6 / Bin 08",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1033",
                Name = "Drain Snake",
                Description = "25-foot manual plumbing snake auger.",
                Category = "Plumbing",
                QuantityOnHand = 7,
                MinimumStockLevel = 5,
                UnitCost = 14.00m,
                RetailPrice = 28.99m,
                PhysicalLocation = "Aisle 6 / Bin 10",
                LastUpdated = DateTime.UtcNow
            },
            new InventoryItem
            {
                SKU = "MAT-1034",
                Name = "Shop Towels",
                Description = "Box of 200 disposable blue shop towels.",
                Category = "Supplies",
                QuantityOnHand = 22,
                MinimumStockLevel = 10,
                UnitCost = 12.50m,
                RetailPrice = 24.99m,
                PhysicalLocation = "Aisle 2 / Bin 12",
                LastUpdated = DateTime.UtcNow
            });

        await db.SaveChangesAsync();
    }
}