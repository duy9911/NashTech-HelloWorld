using System;
using Microsoft.AspNetCore.Mvc;
using FE_Core_Assignment__day_2_.Services;
using System.Collections.Generic;
using FE_Core_Assignment__day_2_.Models;

namespace FE_Core_Assignment__day_2_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet("products")]
        public List<Product> GetList()        
        {
            return _service.GetList();  
        }

        [HttpPost("product")]
        public Product Create(ProductDTO model)
        {
            return _service.Create(model);
        }

        [HttpDelete("person/{Id}")]
        public bool Delete(int Id){
            return _service.Delete(Id);
        }

        [HttpPut("person")]
        public Product  Update(ProductDTO model){
            return _service.Update(model);
        }
        
    }
}