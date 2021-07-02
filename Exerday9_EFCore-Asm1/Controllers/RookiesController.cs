using System;
using System.Collections.Generic;
using CoreAPI_ASM2.Models;
using CoreAPI_ASM2.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI_ASM2.Controllers
{
    public class RookiesController : ControllerBase
    {
        private readonly IStudentService _service;
        public RookiesController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet("persons")]
        public List<Student> GetList()
        {
            return _service.GetList();
        }

        [HttpGet("person/{id}")]
        public Student Get(int id)
        {
            return _service.GetSelected(id);
        }

        [HttpPost("person")]
        public List<Student> Create(Student model)
        {
            return _service.Create(model);
        }

        [HttpPut("person")]
        public bool Update(Student model)
        {
            _service.Update(model);
            return true;
        }

        [HttpDelete("person/{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}