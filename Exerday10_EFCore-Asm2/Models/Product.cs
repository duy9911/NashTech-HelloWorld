using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FE_Core_Assignment__day_2_.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId{get; set;}
        public string ProductName{get; set;}
        public string Manufacture{get; set;}
        public int CategoryId {get; set;}
        public Category category { get; set; } 
        
    }
}