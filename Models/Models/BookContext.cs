using Microsoft.EntityFrameworkCore;

namespace Mission11.Models
{
    //create a BookContext class that inherits from DbContext
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
