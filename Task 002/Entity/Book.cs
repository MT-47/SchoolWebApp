using System.Collections.Generic;

namespace Task_002
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        // One-to-one-or-zero: Book -> PriceOffer
        public PriceOffer PriceOffer { get; set; }

        // One-to-many: Book -> Reviews
        public List<Review> Reviews { get; set; }

        // Many-to-many: Book <-> Author  (via BookAuthor)
        public List<BookAuthor> AuthorsLink { get; set; }

        // Many-to-many: Book <-> Tag  (via BookTag — auto-created by EF Core)
        public List<Tag> Tags { get; set; }
    }
}
