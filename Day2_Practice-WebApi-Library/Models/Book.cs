using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice7.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int BookId{get;set;}

        public  string BookName{get;set;}
    
        public int ClientId { get; set; }

        public List<Author> Authors{set;get;}

    }
}