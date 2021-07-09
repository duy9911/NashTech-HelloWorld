using System;
using System.Collections.Generic;
using System.Linq;
using Practice7.Models;

namespace Practice7.Serivices
{
    
    public class AuthorService : ILibrary<Author>
    {
        private readonly LibraryContext _context;
        public AuthorService(LibraryContext context)
        {
            _context = context; 
        }

        public List<Author> GetList()
        {
            return _context.Authors.ToList();
        }

        public Author Create(Author modelAuthor)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {

                var author = new Author
                {
                    AuthorName = modelAuthor.AuthorName
                };
                _context.Authors.Add(author);
                _context.SaveChanges();
                transaction.Commit();
                return author;
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
                _context.Authors.Remove(GetSelected(Id));
                _context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Author Update(Author author)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var newAuthor = new Author
                {
                    AuthorName = author.AuthorName,
                    AuthorId=author.AuthorId,
                };

                _context.Authors.Update(newAuthor);
                _context.SaveChanges();
                _context.SaveChanges();
                transaction.Commit();
                return newAuthor;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Author GetSelected(int Id)
        {
            var item = _context.Authors.FirstOrDefault(s => s.AuthorId == Id);
            if (item != null)
            {
                return item;
            }
            return null;
        }
    }
}