using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stock_flow.Models
{
    public class InventoryItem
    {
        // --- Identification ---
        
        [Key]
        [Required]
        [StringLength(50)]
        [Display(Name = "Stock Keeping Unit")]
        public string SKU { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string Category { get; set; } = string.Empty;

        // --- Quantities ---
        
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative.")]
        public int QuantityOnHand { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [Display(Name = "Reorder Point")]
        public int MinimumStockLevel { get; set; }

        // --- Financials ---

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitCost { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal RetailPrice { get; set; }

        // --- Logistics & Tracking ---

        [StringLength(50)]
        [Display(Name = "Bin/Aisle Location")]
        public string PhysicalLocation { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}