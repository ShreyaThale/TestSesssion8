using BookLibraryAPI.Models;
using BookLibraryAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Service
{
    public class FakeBookService:IBookService
    {
        List<Book> Books;
        public FakeBookService()
        {
            Books = new List<Book>()
            {
                new Book(){Id = 1, Name = "The Alchemist", Author = "Paulo Coelho", Price = 200},
                new Book(){Id = 2, Name = "Wings Of Fire", Author = " APJ Abdul Kalam", Price = 250},
                new Book(){Id = 3, Name = "Dollar Bahu", Author = " Sudha Murthy", Price = 150 }

            };
        }
        public List<Book> GetAllBooks()
        {
            return Books;
        }

        public Book GetBookById(int id)
        {
            return Books.Find(x => x.Id == id);
        }
    }
}
