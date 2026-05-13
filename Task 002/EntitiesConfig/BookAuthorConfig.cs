using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task_002
{
    public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            // Composite primary key
            builder.HasKey(ba => new { ba.BookId, ba.AuthorId });

            builder.Property(ba => ba.Order)
                   .IsRequired();

            // Many-to-many: BookAuthor -> Book
            builder.HasOne(ba => ba.Book)
                   .WithMany(b => b.AuthorsLink)
                   .HasForeignKey(ba => ba.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Many-to-many: BookAuthor -> Author
            builder.HasOne(ba => ba.Author)
                   .WithMany(a => a.BooksLink)
                   .HasForeignKey(ba => ba.AuthorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
