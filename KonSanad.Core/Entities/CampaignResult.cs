// KonSanad.Repository\Entities\CampaignResult.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonSanad.Repository.Entities
{
    [Table("CampaignResult")]
    public class CampaignResult
    {
        [Key]
        public int CampaignResultId { get; set; }

        public int CampaignId { get; set; }
        [ForeignKey(nameof(CampaignId))]
        public Campaign? Campaign { get; set; }

        public DateTime? ReportDate { get; set; }

        public decimal? TotalCashCollected { get; set; }

        public int? TotalItemsCount { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}