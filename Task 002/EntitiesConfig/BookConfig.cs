using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task_002
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.Title)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(b => b.PublishedOn)
                   .IsRequired();

            builder.Property(b => b.Price)
                   .HasColumnType("decimal(9,2)")
                   .IsRequired();

            builder.Property(b => b.Publisher)
                   .HasMaxLength(64);

            builder.Property(b => b.ImageUrl)
                   .HasMaxLength(512);

            // One-to-one-or-zero: Book -> PriceOffer
            builder.HasOne(b => b.PriceOffer)
                   .WithOne(p => p.Book)
                   .HasForeignKey<PriceOffer>(p => p.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            // One-to-many: Book -> Reviews
            builder.HasMany(b => b.Reviews)
                   .WithOne(r => r.Book)
                   .HasForeignKey(r => r.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Many-to-many via BookTag (auto-created by EF Core)
            builder.HasMany(b => b.Tags)
                   .WithMany(t => t.Books)
                   .UsingEntity(j => j.ToTable("BookTag"));
        }
    }
}
