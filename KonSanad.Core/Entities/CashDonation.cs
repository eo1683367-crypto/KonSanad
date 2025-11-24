// KonSanad.Repository\Entities\CashDonation.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonSanad.Repository.Entities
{
    [Table("CashDonation")]
    public class CashDonation
    {
        [Key]
        public int CashDonationId { get; set; }

        public int DonationOrderId { get; set; }
        [ForeignKey(nameof(DonationOrderId))]
        public DonationOrder? DonationOrder { get; set; }

        public decimal Amount { get; set; }
    }
}