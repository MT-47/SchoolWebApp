using Microsoft.EntityFrameworkCore;

namespace Task_002
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PriceOffer> PriceOffers { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                System.Reflection.Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
