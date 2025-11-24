// KonSanad.Repository\Entities\Donor.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonSanad.Repository.Entities
{
    [Table("Donor")]
    public class Donor
    {
        [Key]
        public int DonorId { get; set; }

        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string Status { get; set; } = null!;

        public string DonorType { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public ICollection<DonationOrder> DonationOrders { get; set; } = new List<DonationOrder>();
        public ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
    }
}