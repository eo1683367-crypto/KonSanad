using KonSanad.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KonSanad.Repository.Data.Configurations
{
    public class HelpOrderItemConfiguration : IEntityTypeConfiguration<HelpOrderItem>
    {
        public void Configure(EntityTypeBuilder<HelpOrderItem> builder)
        {

        }
    }
}
