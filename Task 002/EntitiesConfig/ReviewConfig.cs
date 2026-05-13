using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task_002
{
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.ReviewId);

            builder.Property(r => r.VoterName)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(r => r.NumStars)
                   .IsRequired();

            builder.Property(r => r.Comment)
                   .HasMaxLength(500);
        }
    }
}
