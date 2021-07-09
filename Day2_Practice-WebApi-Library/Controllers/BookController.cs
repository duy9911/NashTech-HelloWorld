using Practice7.Serivices;
using Microsoft.AspNetCore.Mvc;
using Practice7.Models;
using System.Collections.Generic;

namespace Practice7.Controllers
{
    public class BookController
    {
        private readonly BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }
        #region book 

        [HttpGet("book")]
        public List<Book> GetListBook()
        {
            return bookService.GetList();
        }

        [HttpPost("book")]
        public Book CreateBook(BookDTO bookDTO)
        {
            var newBook= new Book(){
                BookName=bookDTO.BookName,
                ClientId=bookDTO.ClientId,
            };
            return bookService.Create(newBook);
        }

        [HttpDelete("book")]
        public bool DeleteBook(int Id)
        {
            return bookService.Delete(Id);
        }

        [HttpPut("book")]
        public Book Update(Book book)
        {
            return bookService.Update(book);
        }
        #endregion 
    }
}