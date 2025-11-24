using KonSanad.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonSanad.Repository.Data.Configurations
{
    public class CampaignResultConfiguration : IEntityTypeConfiguration<CampaignResult>
    {
        public void Configure(EntityTypeBuilder<CampaignResult> builder)
        {

        }
    }
}
