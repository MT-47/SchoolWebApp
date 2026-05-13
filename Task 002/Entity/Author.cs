using System.Collections.Generic;

namespace Task_002
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        // Many-to-many: Author <-> Book  (via BookAuthor)
        public List<BookAuthor> BooksLink { get; set; }
    }
}
