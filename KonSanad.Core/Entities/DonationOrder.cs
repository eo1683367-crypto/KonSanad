// KonSanad.Repository\Entities\DonationOrder.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace KonSanad.Repository.Entities
{
    [Table("DonationOrders")]
    public class DonationOrder
    {
        [Key]
        public int DonationOrderId { get; set; }

        public int? DonorId { get; set; }
        [ForeignKey(nameof(DonorId))]
        public Donor? Donor { get; set; }

        public int? CampaignId { get; set; }
        [ForeignKey(nameof(CampaignId))]
        public Campaign? Campaign { get; set; }

        // If you have a DonationType table use this FK, otherwise keep as int/enum
        public int? DonationTypeId { get; set; }

        public int? ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public Manager? Manager { get; set; }

        public string DonationCategoryStatus { get; set; } = null!;

        public decimal? CashAmount { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? OrderDate { get; set; }

        // Navigation
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
        public CashDonation? CashDonation { get; set; }
    }
}