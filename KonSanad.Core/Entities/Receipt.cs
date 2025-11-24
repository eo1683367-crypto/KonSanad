// KonSanad.Repository\Entities\Receipt.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonSanad.Repository.Entities
{
    [Table("Receipts")]
    public class Receipt
    {
        [Key]
        public int ReceiptId { get; set; }

        public int? DonationOrderId { get; set; }
        [ForeignKey(nameof(DonationOrderId))]
        public DonationOrder? DonationOrder { get; set; }

        public int? ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public Manager? Manager { get; set; }

        public int? BeneficiaryId { get; set; }
        [ForeignKey(nameof(BeneficiaryId))]
        public Beneficiary? Beneficiary { get; set; }

        public int? DonorId { get; set; }
        [ForeignKey(nameof(DonorId))]
        public Donor? Donor { get; set; }

        public decimal? AmountCash { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}