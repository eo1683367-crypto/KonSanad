// KonSanad.Repository\Entities\HelpOrderItem.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonSanad.Repository.Entities
{
    [Table("HelpOrderItem")]
    public class HelpOrderItem : BaseEntity<int>
    {
       

        public int HelpOrderId { get; set; }
        [ForeignKey(nameof(HelpOrderId))]
        public HelpOrder? HelpOrder { get; set; }

        public int SupplyId { get; set; }
        [ForeignKey(nameof(SupplyId))]
        public Supply? Supply { get; set; }

        public int QuantityRequested { get; set; }
    }
}