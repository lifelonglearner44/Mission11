using Microsoft.AspNetCore.Mvc;
using Mission11.Models;
using Mission11.Models.ViewModels;
namespace Mission11.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        //constructor
        public HomeController(IBookRepository temp)
        {
            //create the repository object
            _repo = temp;
        }
        public IActionResult Index(int pageNum)
        {
            //Add pagination to the app
            //so that we list out 10 books per page for as many books as are in the database.
            int pageSize = 10;

            var viewModel = new BooksListViewModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                // Intialize the PaginationInfo object
                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(viewModel);
        }
    }
}