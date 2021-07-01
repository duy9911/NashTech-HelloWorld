using System.Collections.Generic;
using EF_ASPCORE.Models;
using EF_ASPCORE.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI_ASM2.Controllers
{
    public class RookiesController
    {
        private readonly IStudentService _service;
        public RookiesController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet("students")]
        public  List<Student> GetList()
        {
            return  _service.GetList();
        }

        [HttpPut("Ssudent")]
        public Student Create([Bind("FirstName,LastName,City,State,")] Student model)
        {
             return _service.Create(model);
        }

        
    }
}