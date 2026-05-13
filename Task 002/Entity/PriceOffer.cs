namespace Task_002
{
    // One-to-one-or-zero with Book
    public class PriceOffer
    {
        public int PriceOfferId { get; set; }
        public decimal NewPrice { get; set; }
        public string PromotionalText { get; set; }

        // FK to Books
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
