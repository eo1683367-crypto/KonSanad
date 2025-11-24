// KonSanad.Repository\Entities\HelpOrder.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonSanad.Repository.Entities
{
    [Table("HelpOrders")]
    public class HelpOrder
    {
        [Key]
        public int HelpOrderId { get; set; }

        public int? BeneficiaryId { get; set; }
        [ForeignKey(nameof(BeneficiaryId))]
        public Beneficiary? Beneficiary { get; set; }

        public int? ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public Manager? Manager { get; set; }

        public string Description { get; set; } = null!;

        public string Status { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public ICollection<HelpOrderItem> HelpOrderItems { get; set; } = new List<HelpOrderItem>();
    }
}