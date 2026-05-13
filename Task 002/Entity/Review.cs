namespace Task_002
{
    // One-to-many: one Book has many Reviews
    public class Review
    {
        public int ReviewId { get; set; }
        public string VoterName { get; set; }
        public int NumStars { get; set; }
        public string Comment { get; set; }

        // FK to Books
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
