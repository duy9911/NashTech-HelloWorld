using System.ComponentModel.DataAnnotations.Schema;

namespace FE_Core_Assignment__day_2_.Models
{
    public class ProductDTO
    {
        public string ProductName { get; set; }
        public string Manufacture { get; set; }
        public int CategoryId { get; set; }
    }
}