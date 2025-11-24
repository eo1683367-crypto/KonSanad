using KonSanad.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KonSanad.Repository.Data.Configurations
{
    public class SupplyMovementConfiguration : IEntityTypeConfiguration<SupplyMovement>
    {
        public void Configure(EntityTypeBuilder<SupplyMovement> builder)
        {

        }
    }
}
