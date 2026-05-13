using System.Collections.Generic;

namespace Task_002
{
    public class Tag
    {
        public int TagId { get; set; }

        // Many-to-many: Tag <-> Book  (BookTag table auto-created by EF Core)
        public List<Book> Books { get; set; }
    }
}
