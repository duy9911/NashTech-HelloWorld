using System.Collections.Generic;
using CoreAPI_ASM2.Models;
using CoreAPI_ASM2.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI_ASM2.Controllers
{
    public class RookiesController
    {
        private readonly IPersonService _service;
        public RookiesController(IPersonService service)
        {
            _service = service;
        }

        [HttpGet("persons")]
        public List<PersonModel> GetList()
        {
            return _service.GetList();
        }

        [HttpGet("person/{id}")]
        public PersonModel Get(int id)
        {
            return _service.GetSelected(id);
        }

        [HttpPut("person")]
        public void Create([Bind("FirstName,LastName,Gender,DayOfBirth,BirthPlace")] PersonModel model)
        {
                _service.Create(model);
        }

        [HttpPost("person")]
        public void Update([Bind("FirstName,LastName,Gender,DayOfBirth,BirthPlace")] PersonModel model)
        {
            _service.Update(model);
        }

        [HttpDelete("person/{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }

        [HttpPost("person/filters")]
        public List<PersonModel> Filters(PersonModel model)
        {
            return _service.Filters(model);

        }
    }
}