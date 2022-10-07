using BookLibraryAPI.Models;

namespace BookLibraryAPI.Service
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
    }
}
