using BookLibraryAPI.Controllers;
using BookLibraryAPI.Models;
using BookLibraryAPI.Service;
using Microsoft.AspNetCore.Mvc;
using UnitTesting.Service;

namespace UnitTesting
{
    public class UnitTest
    {
        private readonly BookController _bookController;
        private readonly IBookService _bookService;
        public UnitTest()
        {
            _bookService = new FakeBookService();
            _bookController = new BookController(_bookService);
        }
        [Fact]
        public void ReturnsAllItems()
        {
            //Act
            var result = _bookController.GetAllBooks() as OkObjectResult;

            //Assert
            var items = Assert.IsType<List<Book>>(result.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void BookIdNotFound()
        {
            //Arrange
            int Id = 1;

            //Act
            var result = _bookController.GetBookById(12);

            //Assert
            Assert.IsType<OkObjectResult>(result as OkObjectResult);
        }

        [Fact]
        public void BookById_ReturnsOkResult ()
        {
            //Arrange
            int Id = 1;

            //Act
            var result = _bookController.GetBookById(1) as OkObjectResult;

            //Assert
            Assert.IsType<Book>(result.Value);
            Assert.Equal(Id, (result.Value as Book).Id);
        }
    }
}