
namespace Mission11.Models
{
    //create a repository interface
    public class EFBookRepository : IBookRepository
    {
        private BookContext _context;
        public EFBookRepository(BookContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
