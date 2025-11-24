// KonSanad.Repository\Entities\Campaign.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace KonSanad.Repository.Entities
{
    [Table("Campaigns")]
    public class Campaign
    {
        [Key]
        public int CampaignId { get; set; }

        public int? ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public Manager? Manager { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? GoalCash { get; set; }

        public int? GoalSupplies { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Status { get; set; } = null!;

        // Navigation
        public ICollection<DonationOrder> DonationOrders { get; set; } = new List<DonationOrder>();
        public ICollection<CampaignResult> CampaignResults { get; set; } = new List<CampaignResult>();
        public ICollection<Mission> Missions { get; set; } = new List<Mission>();
        public ICollection<CampaignVolunteer> CampaignVolunteers { get; set; } = new List<CampaignVolunteer>();
    }
}