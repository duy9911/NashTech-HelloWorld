using System.Collections.Generic;
using FE_Core_Assignment__day_2_.Models;
namespace FE_Core_Assignment__day_2_.Services
{
    public interface IProductService{
        List<Product> GetList();
        Product Create(ProductDTO model);
        bool Delete(int Id);
        Product Update(ProductDTO model);
    }
}