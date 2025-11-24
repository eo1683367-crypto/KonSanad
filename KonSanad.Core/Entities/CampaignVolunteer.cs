// KonSanad.Repository\Entities\CampaignVolunteer.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonSanad.Repository.Entities
{
    [Table("CampaignVolunteers")]
    public class CampaignVolunteer : BaseEntity<int>
    {
      

        public int CampaignId { get; set; }
        [ForeignKey(nameof(CampaignId))]
        public Campaign? Campaign { get; set; }

        public int VolunteerId { get; set; }
        [ForeignKey(nameof(VolunteerId))]
        public Volunteer? Volunteer { get; set; }

        public DateTime? AssignedAt { get; set; }
    }
}