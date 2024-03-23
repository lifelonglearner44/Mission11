namespace Mission11.Models.ViewModels
{
    public class BooksListViewModel
    {
        //create an IQueryable object to store the books
        public IQueryable<Book> Books { get; set; }
        //create a PaginationInfo object to store the pagination info
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
