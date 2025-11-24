// KonSanad.Repository\Entities\Beneficiary.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonSanad.Repository.Entities
{
    [Table("Beneficiaries")]
    public class Beneficiary
    {
        [Key]
        public int BeneficiaryId { get; set; }

        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string Status { get; set; } = null!;

        // Naviegation property
        public ICollection<HelpOrder> HelpOrders { get; set; } = new List<HelpOrder>();
        public ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
    }
}