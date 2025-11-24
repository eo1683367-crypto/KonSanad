// KonSanad.Repository\Entities\Supply.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonSanad.Repository.Entities
{
    [Table("Supplies")]
    public class Supply
    {
        [Key]
        public int SupplyId { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Unit { get; set; } = null!;

        public int StockQuantity { get; set; }

        public int MinimumLevel { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Status { get; set; } = null!;

        // Navigation
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<SupplyMovement> SupplyMovements { get; set; } = new List<SupplyMovement>();
    }
}