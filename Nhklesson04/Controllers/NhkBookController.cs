using Microsoft.AspNetCore.Mvc;
using Nhklesson04.Models;
using System.Collections.Generic;

namespace Nhklesson04.Controllers
{
    public class NhkBookController : Controller
    {
        private readonly BookService _bookService;

        public NhkBookController()
        {
            _bookService = new BookService();
        }

        public IActionResult NhkIndex()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }
    }

    // Gộp BookService vào cùng file
    public class BookService
    {
        private List<NhkBook> Nhkbooks = new List<NhkBook>
        {
            new NhkBook { Id = "1", NhkTitle = "Book Title 1", NhkDescription = "Description for book 1", NhkImage = "/image/book1.jpg", NhkPrice = "$6.99", NhkPage = "100" },
            new NhkBook { Id = "2", NhkTitle = "Book Title 2", NhkDescription = "Description for book 2", NhkImage = "/image/book2.jpg", NhkPrice = "$7.99", NhkPage = "200" },
            new NhkBook { Id = "3", NhkTitle = "Book Title 3", NhkDescription = "Description for book 3", NhkImage = "/image/book3.jpg", NhkPrice = "$8.99", NhkPage = "300" },
            new NhkBook { Id = "4", NhkTitle = "Book Title 4", NhkDescription = "Description for book 4", NhkImage = "/image/book4.jpg", NhkPrice = "$9.99", NhkPage = "400" },
            new NhkBook { Id = "5", NhkTitle = "Book Title 5", NhkDescription = "Description for book 5", NhkImage = "/image/book5.jpg", NhkPrice = "$10.99", NhkPage = "500" }
        };

        public List<NhkBook> GetAllBooks()
        {
            return Nhkbooks;
        }
    }
}
