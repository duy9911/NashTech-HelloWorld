using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice7.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        public string AuthorName{ get; set; }
        
        public List<Book> Books{set;get;}

    }
}