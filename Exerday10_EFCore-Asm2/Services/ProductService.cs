using System;
using System.Collections.Generic;
using System.Linq;
using FE_Core_Assignment__day_2_.Models;
namespace FE_Core_Assignment__day_2_.Services
{
    public class ProductService : IProductService
    {
        public ProductContext _context;
        public ProductService(ProductContext context)
        {
            _context = context;
        }
        public List<Product> GetList()
        {
            return _context.Product.ToList();
        }

        public Product Create(ProductDTO productDTO)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var product = new Product
                {
                    ProductName = productDTO.ProductName,
                    CategoryId = productDTO.CategoryId,
                    Manufacture = productDTO.Manufacture
                };
                _context.Product.Add(product);
                _context.SaveChanges();
                transaction.Commit();
                return product;
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
                _context.Product.Remove(GetSelected(Id));
                _context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Product Update(ProductDTO productDTO)
        {
            using var transaction = _context.Database.BeginTransaction();
            try{
            var product = new Product
            {
                ProductName = productDTO.ProductName,
                CategoryId = productDTO.CategoryId,
                Manufacture = productDTO.Manufacture
            };

            _context.Product.Update(product);
            _context.SaveChanges();
            _context.SaveChanges();
            transaction.Commit();
            return product;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public Product GetSelected(int id)
        {
            return _context.Product.FirstOrDefault(s => s.ProductId == id);
        }
    }
}