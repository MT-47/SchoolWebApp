using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task_002
{
    public class PriceOfferConfig : IEntityTypeConfiguration<PriceOffer>
    {
        public void Configure(EntityTypeBuilder<PriceOffer> builder)
        {
            builder.HasKey(p => p.PriceOfferId);

            builder.Property(p => p.NewPrice)
                   .HasColumnType("decimal(9,2)")
                   .IsRequired();

            builder.Property(p => p.PromotionalText)
                   .HasMaxLength(200);
        }
    }
}
