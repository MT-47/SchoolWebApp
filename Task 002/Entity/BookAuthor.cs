namespace Task_002
{
    public class BookAuthor
    {
        // Composite PK: (BookId, AuthorId)
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public int Order { get; set; }

        // Navigation properties
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
