namespace Mission11.Models
{
    //create a repository interface
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
