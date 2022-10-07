using BookLibraryAPI.Models;
using BookLibraryAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            List<Book> books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet]
        [Route("GetBookById")]
        public IActionResult GetBookById(int id)
        {
            Book book = _bookService.GetBookById(id);
            if(book != null)
            {
                return Ok(book);
            }
            else
            {
                return BadRequest("Please Enter a valid Id");
            }
        }
    }
}
