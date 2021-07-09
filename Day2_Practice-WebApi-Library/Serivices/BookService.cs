using System;
using System.Collections.Generic;
using System.Linq;
using Practice7.Models;

namespace Practice7.Serivices
{
    public class BookService : ILibrary<Book>
    {
        private readonly LibraryContext _context;
        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public List<Book> GetList()
        {
            return _context.Books.ToList();
        }

        public Book Create(Book book)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {

                var Book = new Book
                {
                    BookName = book.BookName,
                    ClientId=book.ClientId
                };
                _context.Books.Add(Book);
                _context.SaveChanges();
                transaction.Commit();
                return Book;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Delete(int Id)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Books.Remove(GetSelected(Id));
                _context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Book Update(Book book)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var newBook = new Book
                {
                    BookName = book.BookName,
                    BookId=book.BookId,
                    ClientId=book.ClientId
                };

                _context.Books.Update(newBook);
                _context.SaveChanges();
                _context.SaveChanges();
                transaction.Commit();
                return newBook;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Book GetSelected(int Id)
        {
            var item = _context.Books.FirstOrDefault(s => s.BookId == Id);
            if (item != null)
            {
                return item;
            }
            return null;
        }
    }
}