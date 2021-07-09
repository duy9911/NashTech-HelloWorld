using Practice7.Serivices;
using Microsoft.AspNetCore.Mvc;
using Practice7.Models;
using System.Collections.Generic;

namespace Practice7.Controllers
{
    public class LibraryController : Controller
    {
        private readonly AuthorService authorService;

        public LibraryController(AuthorService authorService)
        {
            this.authorService = authorService;
        }

        #region author
        [HttpGet("author")]
        public List<Author> GetList()
        {
            return authorService.GetList();
        }

        [HttpPost("author")]
        public Author Create(AuthorDTO authorDTO)
        {
            var author = new Author()
            {
                AuthorName = authorDTO.AuthorName,
            };
            return authorService.Create(author);
        }

        [HttpDelete("author")]
        public bool Delete(int Id)
        {
            return authorService.Delete(Id);
        }

        [HttpPut("author")]
        public Author Update(Author author)
        {
            return authorService.Update(author);
        }

        #endregion author
    }
}
